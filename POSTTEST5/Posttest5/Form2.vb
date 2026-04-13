Imports MySqlConnector

Public Class Form2

    ' --- 1. SUB TAMPIL DATA (Untuk Refresh DataGridView) ---
    Sub TampilData()
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim dt As New DataTable
                Dim sql As String = "SELECT * FROM tb_bahanbaku"
                Dim adapter As New MySqlDataAdapter(sql, conn)
                adapter.Fill(dt)
                dgvBahan.DataSource = dt

                ' Mempercantik tampilan tabel
                dgvBahan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MsgBox("Gagal memuat data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 2. SUB BERSIHKAN (Reset Inputan) ---
    Sub BersihkanForm()
        txtKodeBahan.Clear()
        txtNamaBahan.Clear()
        txtStok.Clear()
        cmbKategori.SelectedIndex = -1
        cmbSatuan.SelectedIndex = -1
        txtKodeBahan.ReadOnly = False
        txtKodeBahan.Focus()
    End Sub

    ' --- 3. EVENT LOAD (Saat Form Pertama Kali Terbuka) ---
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' --- 4. TOMBOL SIMPAN (INSERT) ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBahan.Text = "" Or txtNamaBahan.Text = "" Or txtStok.Text = "" Then
            MsgBox("Lengkapi semua data terlebih dahulu!")
            Exit Sub
        End If

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO tb_bahanbaku VALUES (@kode, @nama, @kat, @stok, @sat)"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kode", txtKodeBahan.Text)
                cmd.Parameters.AddWithValue("@nama", txtNamaBahan.Text)
                cmd.Parameters.AddWithValue("@kat", cmbKategori.Text)
                cmd.Parameters.AddWithValue("@stok", txtStok.Text)
                cmd.Parameters.AddWithValue("@sat", cmbSatuan.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan!")
                TampilData()
                BersihkanForm()
            Catch ex As Exception
                MsgBox("Gagal Simpan: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 5. TOMBOL UBAH (UPDATE) ---
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "UPDATE tb_bahanbaku SET nama_bahan=@nama, kategori=@kat, stok=@stok, satuan=@sat WHERE kodebahanbaku=@kode"
                Dim cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama", txtNamaBahan.Text)
                cmd.Parameters.AddWithValue("@kat", cmbKategori.Text)
                cmd.Parameters.AddWithValue("@stok", txtStok.Text)
                cmd.Parameters.AddWithValue("@sat", cmbSatuan.Text)
                cmd.Parameters.AddWithValue("@kode", txtKodeBahan.Text)

                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diperbarui!")
                TampilData()
                BersihkanForm()
            Catch ex As Exception
                MsgBox("Gagal Update: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- 6. TOMBOL HAPUS (DELETE) ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeBahan.Text = "" Then
            MsgBox("Pilih data yang ingin dihapus terlebih dahulu!")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Using conn As MySqlConnection = GetConnection()
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM tb_bahanbaku WHERE kodebahanbaku=@kode"
                    Dim cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@kode", txtKodeBahan.Text)

                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil Dihapus!")
                    TampilData()
                    BersihkanForm()
                Catch ex As Exception
                    MsgBox("Gagal Hapus: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    ' --- 7. EVENT CELL CLICK (Klik Tabel Muncul di Inputan) ---
    Private Sub dgvBahan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBahan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBahan.Rows(e.RowIndex)
            txtKodeBahan.Text = row.Cells(0).Value.ToString()
            txtNamaBahan.Text = row.Cells(1).Value.ToString()
            cmbKategori.Text = row.Cells(2).Value.ToString()
            txtStok.Text = row.Cells(3).Value.ToString()
            cmbSatuan.Text = row.Cells(4).Value.ToString()

            txtKodeBahan.ReadOnly = True ' Kode tidak boleh diganti saat edit
        End If
    End Sub

    ' --- 8. FITUR PENCARIAN (SEARCH) ---
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim sql As String = "SELECT * FROM tb_bahanbaku WHERE nama_bahan LIKE @cari OR kategori LIKE @cari"
                Dim adapter As New MySqlDataAdapter(sql, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtCari.Text & "%")

                Dim dt As New DataTable
                adapter.Fill(dt)
                dgvBahan.DataSource = dt
            Catch ex As Exception
                ' Biarkan kosong agar tidak mengganggu saat mengetik
            End Try
        End Using
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class