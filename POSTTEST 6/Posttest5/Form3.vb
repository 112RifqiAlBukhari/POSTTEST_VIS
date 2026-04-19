Imports MySqlConnector

Public Class Form3

    ' --- 1. SUB TAMPIL DATA TRANSAKSI ---
    Sub TampilData()
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim dt As New DataTable
                Dim sql As String =
                    "SELECT t.id_transaksi, t.tanggal, b.nama_bahan, t.jumlah_pakai, b.satuan, t.keterangan " &
                    "FROM tb_transaksi t " &
                    "INNER JOIN tb_bahanbaku b ON t.kodebahanbaku = b.kodebahanbaku " &
                    "ORDER BY t.tanggal DESC"
                Dim adapter As New MySqlDataAdapter(sql, conn)
                adapter.Fill(dt)
                dgvTransaksi.DataSource = dt
                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Rename header kolom agar lebih rapi
                dgvTransaksi.Columns(0).HeaderText = "ID"
                dgvTransaksi.Columns(1).HeaderText = "Tanggal"
                dgvTransaksi.Columns(2).HeaderText = "Nama Bahan"
                dgvTransaksi.Columns(3).HeaderText = "Jumlah Pakai"
                dgvTransaksi.Columns(4).HeaderText = "Satuan"
                dgvTransaksi.Columns(5).HeaderText = "Keterangan"
            Catch ex As Exception
                MsgBox("Gagal memuat data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 2. ISI COMBOBOX BAHAN (dari tb_bahanbaku) ---
    Sub IsiComboBahan()
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT kodebahanbaku, nama_bahan FROM tb_bahanbaku ORDER BY nama_bahan"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                cmbBahan.Items.Clear()
                While dr.Read()
                    cmbBahan.Items.Add(dr("kodebahanbaku").ToString() & " - " & dr("nama_bahan").ToString())
                End While
            Catch ex As Exception
                MsgBox("Gagal memuat bahan: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 3. BERSIHKAN FORM ---
    Sub BersihkanForm()
        cmbBahan.SelectedIndex = -1
        txtJumlah.Clear()
        txtKeterangan.Clear()
        dtpTanggal.Value = DateTime.Now
        lblStokInfo.Text = "Stok: -"
        lblIdInfo.Text = "ID: (auto)"
        txtIdEdit.Text = ""
    End Sub

    ' --- 4. LOAD ---
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = DateTime.Now
        IsiComboBahan()
        TampilData()
    End Sub

    ' --- 5. SAAT PILIH BAHAN DI COMBOBOX, TAMPILKAN STOK ---
    Private Sub cmbBahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBahan.SelectedIndexChanged
        If cmbBahan.SelectedIndex < 0 Then Exit Sub

        Dim kode As String = cmbBahan.Text.Split("-"c)(0).Trim()

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT stok, satuan FROM tb_bahanbaku WHERE kodebahanbaku = @kode"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kode", kode)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    lblStokInfo.Text = "Stok: " & dr("stok").ToString() & " " & dr("satuan").ToString()
                End If
            Catch ex As Exception
                lblStokInfo.Text = "Stok: Error"
            End Try
        End Using
    End Sub

    ' --- 6. TOMBOL SIMPAN TRANSAKSI ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbBahan.SelectedIndex < 0 Or txtJumlah.Text = "" Then
            MsgBox("Pilih bahan dan isi jumlah terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim kode As String = cmbBahan.Text.Split("-"c)(0).Trim()
        Dim jumlah As Integer

        If Not Integer.TryParse(txtJumlah.Text, jumlah) Or jumlah <= 0 Then
            MsgBox("Jumlah pakai harus berupa angka positif!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Cek apakah stok mencukupi
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()

                Dim sqlCek As String = "SELECT stok FROM tb_bahanbaku WHERE kodebahanbaku = @kode"
                Dim cmdCek As New MySqlCommand(sqlCek, conn)
                cmdCek.Parameters.AddWithValue("@kode", kode)
                Dim stokSekarang As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())

                If jumlah > stokSekarang Then
                    MsgBox("Stok tidak mencukupi! Stok tersedia: " & stokSekarang, MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                ' Insert transaksi
                Dim sqlInsert As String =
                    "INSERT INTO tb_transaksi (tanggal, kodebahanbaku, jumlah_pakai, keterangan) " &
                    "VALUES (@tgl, @kode, @jml, @ket)"
                Dim cmdInsert As New MySqlCommand(sqlInsert, conn)
                cmdInsert.Parameters.AddWithValue("@tgl", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                cmdInsert.Parameters.AddWithValue("@kode", kode)
                cmdInsert.Parameters.AddWithValue("@jml", jumlah)
                cmdInsert.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                cmdInsert.ExecuteNonQuery()

                ' Kurangi stok di tb_bahanbaku
                Dim sqlUpdate As String =
                    "UPDATE tb_bahanbaku SET stok = stok - @jml WHERE kodebahanbaku = @kode"
                Dim cmdUpdate As New MySqlCommand(sqlUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@jml", jumlah)
                cmdUpdate.Parameters.AddWithValue("@kode", kode)
                cmdUpdate.ExecuteNonQuery()

                MsgBox("Transaksi berhasil disimpan dan stok telah dikurangi!", MsgBoxStyle.Information)
                TampilData()
                IsiComboBahan()
                BersihkanForm()
            Catch ex As Exception
                MsgBox("Gagal menyimpan transaksi: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    ' --- 7. TOMBOL HAPUS TRANSAKSI ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdEdit.Text = "" Then
            MsgBox("Pilih data transaksi di tabel terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Yakin ingin menghapus transaksi ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()

                    ' Ambil data transaksi dulu (untuk kembalikan stok)
                    Dim sqlGet As String = "SELECT kodebahanbaku, jumlah_pakai FROM tb_transaksi WHERE id_transaksi = @id"
                    Dim cmdGet As New MySqlCommand(sqlGet, conn)
                    cmdGet.Parameters.AddWithValue("@id", txtIdEdit.Text)
                    Dim dr As MySqlDataReader = cmdGet.ExecuteReader()

                    Dim kodeHapus As String = ""
                    Dim jumlahHapus As Integer = 0
                    If dr.Read() Then
                        kodeHapus = dr("kodebahanbaku").ToString()
                        jumlahHapus = Convert.ToInt32(dr("jumlah_pakai"))
                    End If
                    dr.Close()

                    ' Hapus transaksi
                    Dim sqlHapus As String = "DELETE FROM tb_transaksi WHERE id_transaksi = @id"
                    Dim cmdHapus As New MySqlCommand(sqlHapus, conn)
                    cmdHapus.Parameters.AddWithValue("@id", txtIdEdit.Text)
                    cmdHapus.ExecuteNonQuery()

                    ' Kembalikan stok
                    If kodeHapus <> "" Then
                        Dim sqlKembali As String = "UPDATE tb_bahanbaku SET stok = stok + @jml WHERE kodebahanbaku = @kode"
                        Dim cmdKembali As New MySqlCommand(sqlKembali, conn)
                        cmdKembali.Parameters.AddWithValue("@jml", jumlahHapus)
                        cmdKembali.Parameters.AddWithValue("@kode", kodeHapus)
                        cmdKembali.ExecuteNonQuery()
                    End If

                    MsgBox("Transaksi dihapus dan stok dikembalikan!", MsgBoxStyle.Information)
                    TampilData()
                    IsiComboBahan()
                    BersihkanForm()
                Catch ex As Exception
                    MsgBox("Gagal menghapus: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub

    ' --- 8. KLIK BARIS TABEL UNTUK SELECT ---
    Private Sub dgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaksi.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTransaksi.Rows(e.RowIndex)
            txtIdEdit.Text = row.Cells(0).Value.ToString()
            lblIdInfo.Text = "ID Terpilih: " & txtIdEdit.Text

            ' Isi field lain untuk referensi
            Dim namaBahan As String = row.Cells(2).Value.ToString()
            txtJumlah.Text = row.Cells(3).Value.ToString()
            txtKeterangan.Text = row.Cells(5).Value.ToString()

            ' Set combobox ke bahan yang sesuai
            For i As Integer = 0 To cmbBahan.Items.Count - 1
                If cmbBahan.Items(i).ToString().Contains(namaBahan) Then
                    cmbBahan.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    ' --- 9. TOMBOL BERSIHKAN ---
    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        BersihkanForm()
    End Sub

    ' --- 10. TOMBOL KEMBALI KE FORM2 ---
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form2.Show()
        Me.Hide()
    End Sub

    ' --- 11. FITUR PENCARIAN TRANSAKSI ---
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String =
                    "SELECT t.id_transaksi, t.tanggal, b.nama_bahan, t.jumlah_pakai, b.satuan, t.keterangan " &
                    "FROM tb_transaksi t " &
                    "INNER JOIN tb_bahanbaku b ON t.kodebahanbaku = b.kodebahanbaku " &
                    "WHERE b.nama_bahan LIKE @cari OR t.keterangan LIKE @cari " &
                    "ORDER BY t.tanggal DESC"
                Dim adapter As New MySqlDataAdapter(sql, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")
                Dim dt As New DataTable
                adapter.Fill(dt)
                dgvTransaksi.DataSource = dt
            Catch ex As Exception
                ' biarkan kosong saat mengetik
            End Try
        End Using
    End Sub

End Class