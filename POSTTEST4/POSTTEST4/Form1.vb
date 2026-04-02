Public Class Form1
    ' Validasi: Nama Hanya Huruf
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validasi: ID Anggota Hanya Angka
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
            picProfil.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If CekValidasi() Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                    writer.WriteLine("--- DATA MAHASISWA ---")
                    writer.WriteLine("Nama: " & txtNama.Text)
                    writer.WriteLine("ID: " & txtID.Text)
                    writer.WriteLine("Divisi: " & cmbDivisi.SelectedItem.ToString())
                    writer.WriteLine("Telepon: " & mktNohp.Text)
                End Using
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' MENGGUNAKAN ERRORPROVIDER: Panggil fungsi CekValidasi() yang kita buat tadi
        ' Fungsi ini akan memberikan tanda seru merah jika ada yang kosong
        If CekValidasi() = True Then

            ' Munculkan MessageBox konfirmasi sesuai instruksi D (Fitur Lainnya)
            Dim tanya = MessageBox.Show("Konfirmasi cetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If tanya = DialogResult.Yes Then
                ' 1. Mengirim data teks ke Form 2
                Form2.lblNamaHasil.Text = txtNama.Text
                Form2.lblIDHasil.Text = txtID.Text
                Form2.lblDivisiHasil.Text = cmbDivisi.Text
                Form2.lblKontakHasil.Text = mktNohp.Text

                ' 2. Logika menggabungkan Hobi (CheckBox)
                Dim hobiTerpilih As String = ""
                ' Sesuaikan array di bawah ini dengan jumlah CheckBox hobi yang kamu punya (minimal 8)
                Dim listCB() As CheckBox = {cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8}

                For Each cb In listCB
                    If cb.Checked Then
                        hobiTerpilih &= cb.Text & ", "
                    End If
                Next

                ' Hapus koma di paling ujung teks agar rapi
                Form2.lblHobiHasil.Text = hobiTerpilih.TrimEnd(", ".ToCharArray())

                ' 3. Mengirim foto profil
                ' Pastikan user sudah upload foto, jika belum tampilkan placeholder/kosong
                If picProfil.Image IsNot Nothing Then
                    Form2.picKartuHasil.Image = picProfil.Image
                    Form2.picKartuHasil.SizeMode = PictureBoxSizeMode.Zoom
                End If

                ' 4. Berpindah Form (Menampilkan Form 2)
                Form2.Show()
            End If
        Else
            ' Jika validasi gagal (ada yang kosong), beri pesan peringatan
            MessageBox.Show("Inputan tidak boleh kosong! Periksa tanda merah di samping inputan.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Function CekValidasi() As Boolean
        ' Asumsikan awal validasi adalah True
        Dim status As Boolean = True

        ' Bersihkan semua error lama sebelum pengecekan ulang
        ErrorProvider1.Clear()

        ' 1. Validasi TextBox Nama
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 2. Validasi TextBox ID Anggota
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 3. Validasi ComboBox Divisi
        If cmbDivisi.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbDivisi, "Inputan tidak boleh kosong")
            status = False
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            status = False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 4. Validasi MaskedTextBox No HP
        ' .MaskFull memastikan user mengisi semua angka sesuai format
        If Not mktNohp.MaskFull Then
            ErrorProvider1.SetError(mktNohp, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 5. Validasi CheckBox (Minimal 1 harus dicentang)
        Dim hobiDicentang As Boolean = False
        ' Masukkan semua checkbox hobi kamu ke dalam array untuk dicek
        Dim listHobi() As CheckBox = {cbHobi1, cbHobi2, cbHobi3, cbHobi4, cbHobi5, cbHobi6, cbHobi7, cbHobi8}

        For Each cb In listHobi
            If cb.Checked Then
                hobiDicentang = True
                Exit For
            End If
        Next

        If Not hobiDicentang Then
            ' Berikan error pada CheckBox pertama sebagai perwakilan
            ErrorProvider1.SetError(cbHobi1, "Inputan tidak boleh kosong")
            status = False
        End If
        If Not hobiDicentang Then
            ' Berikan error pada CheckBox pertama sebagai perwakilan
            ErrorProvider1.SetError(CbJabatan, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 6. Validasi Foto di PictureBox
        If picProfil.Image Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Inputan tidak boleh kosong")
            status = False
        End If

        ' 7. Validasi RadioButton Jenis Kelamin
        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            ' Berikan error pada salah satu RadioButton (biasanya yang pertama)
            ErrorProvider1.SetError(rbLaki, "Inputan tidak boleh kosong")
            status = False
        Else
            ' Hapus error jika salah satu sudah terpilih
            ErrorProvider1.SetError(rbLaki, "")
        End If
        Return status
    End Function

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Application.Exit() ' Menutup seluruh aplikasi
        End If
    End Sub
End Class
