<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label7 = New Label()
        txtCari = New TextBox()
        Label6 = New Label()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        btnTransaksi = New Button()   ' <<< TOMBOL BARU
        cmbSatuan = New ComboBox()
        cmbKategori = New ComboBox()
        txtStok = New TextBox()
        txtNamaBahan = New TextBox()
        txtKodeBahan = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dgvBahan = New DataGridView()
        GroupBox1 = New GroupBox()
        CType(dgvBahan, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()

        ' Label7
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.0F, FontStyle.Bold Or FontStyle.Italic)
        Label7.ForeColor = Color.Silver
        Label7.Location = New Point(34, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(187, 15)
        Label7.TabIndex = 15
        Label7.Text = "D (Daging), S (Sayur), P (Plastik)"

        ' txtCari
        txtCari.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Font = New Font("Segoe UI", 17.0F)
        txtCari.ForeColor = Color.White
        txtCari.Location = New Point(31, 452)
        txtCari.Multiline = True
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(770, 53)
        txtCari.TabIndex = 14

        ' Label6
        Label6.AutoSize = True
        Label6.Location = New Point(31, 427)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 13
        Label6.Text = "Search               "

        ' btnHapus
        btnHapus.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(325, 361)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(115, 50)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True

        ' btnUbah
        btnUbah.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(178, 361)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(115, 50)
        btnUbah.TabIndex = 11
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True

        ' btnSimpan
        btnSimpan.FlatAppearance.BorderColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(34, 361)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(115, 50)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True

        ' btnTransaksi (TOMBOL BARU - navigasi ke Form3)
        btnTransaksi.BackColor = Color.FromArgb(0, 120, 215)
        btnTransaksi.FlatAppearance.BorderColor = Color.FromArgb(0, 90, 180)
        btnTransaksi.FlatStyle = FlatStyle.Flat
        btnTransaksi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTransaksi.ForeColor = Color.White
        btnTransaksi.Location = New Point(600, 361)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Size = New Size(200, 50)
        btnTransaksi.TabIndex = 17
        btnTransaksi.Text = "📋 Transaksi Bahan"
        btnTransaksi.UseVisualStyleBackColor = False

        ' cmbSatuan
        cmbSatuan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbSatuan.FlatStyle = FlatStyle.Popup
        cmbSatuan.Font = New Font("Segoe UI", 20.0F)
        cmbSatuan.ForeColor = Color.White
        cmbSatuan.FormattingEnabled = True
        cmbSatuan.Items.AddRange(New Object() {"Kg", "Ikat", "Pcs"})
        cmbSatuan.Location = New Point(34, 282)
        cmbSatuan.Name = "cmbSatuan"
        cmbSatuan.Size = New Size(360, 53)
        cmbSatuan.TabIndex = 9

        ' cmbKategori
        cmbKategori.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbKategori.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbKategori.FlatStyle = FlatStyle.Popup
        cmbKategori.Font = New Font("Segoe UI", 20.0F)
        cmbKategori.ForeColor = Color.White
        cmbKategori.FormattingEnabled = True
        cmbKategori.Items.AddRange(New Object() {"Daging", "Sayur", "Plastik"})
        cmbKategori.Location = New Point(34, 192)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(360, 53)
        cmbKategori.TabIndex = 8

        ' txtStok
        txtStok.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtStok.BorderStyle = BorderStyle.FixedSingle
        txtStok.Font = New Font("Segoe UI", 17.0F)
        txtStok.ForeColor = Color.White
        txtStok.Location = New Point(434, 198)
        txtStok.Multiline = True
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(367, 52)
        txtStok.TabIndex = 7

        ' txtNamaBahan
        txtNamaBahan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtNamaBahan.BorderStyle = BorderStyle.FixedSingle
        txtNamaBahan.Font = New Font("Segoe UI", 17.0F)
        txtNamaBahan.ForeColor = Color.White
        txtNamaBahan.Location = New Point(434, 90)
        txtNamaBahan.Multiline = True
        txtNamaBahan.Name = "txtNamaBahan"
        txtNamaBahan.Size = New Size(367, 53)
        txtNamaBahan.TabIndex = 6

        ' txtKodeBahan
        txtKodeBahan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtKodeBahan.BorderStyle = BorderStyle.FixedSingle
        txtKodeBahan.CharacterCasing = CharacterCasing.Upper
        txtKodeBahan.Font = New Font("Segoe UI", 17.0F)
        txtKodeBahan.ForeColor = Color.White
        txtKodeBahan.Location = New Point(34, 90)
        txtKodeBahan.Multiline = True
        txtKodeBahan.Name = "txtKodeBahan"
        txtKodeBahan.PlaceholderText = "D000"
        txtKodeBahan.Size = New Size(360, 53)
        txtKodeBahan.TabIndex = 5

        ' Label5
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.Location = New Point(33, 259)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 20)
        Label5.TabIndex = 4
        Label5.Text = "Satuan               "

        ' Label4
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Label4.Location = New Point(438, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 19)
        Label4.TabIndex = 3
        Label4.Text = "Stok                "

        ' Label3
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Label3.Location = New Point(32, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 19)
        Label3.TabIndex = 2
        Label3.Text = "Kategori            "

        ' Label2
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Label2.Location = New Point(434, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 19)
        Label2.TabIndex = 1
        Label2.Text = "Nama Bahan     "

        ' Label1
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Label1.Location = New Point(34, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 19)
        Label1.TabIndex = 0
        Label1.Text = "Kode Bahan       "

        ' dgvBahan
        dgvBahan.BackgroundColor = Color.Gray
        dgvBahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvBahan.DefaultCellStyle = DataGridViewCellStyle1
        dgvBahan.GridColor = Color.Black
        dgvBahan.Location = New Point(0, 0)
        dgvBahan.Name = "dgvBahan"
        dgvBahan.RowHeadersWidth = 51
        dgvBahan.Size = New Size(778, 317)
        dgvBahan.TabIndex = 1

        ' GroupBox1
        GroupBox1.Controls.Add(dgvBahan)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(23, 515)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(778, 317)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False

        ' Form2
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(839, 844)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnTransaksi)   ' <<< TAMBAHKAN KE CONTROLS
        Controls.Add(Label6)
        Controls.Add(txtCari)
        Controls.Add(Label7)
        Controls.Add(txtKodeBahan)
        Controls.Add(txtNamaBahan)
        Controls.Add(Label5)
        Controls.Add(cmbSatuan)
        Controls.Add(Label1)
        Controls.Add(txtStok)
        Controls.Add(Label4)
        Controls.Add(cmbKategori)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        Name = "Form2"
        Text = "Form2"
        CType(dgvBahan, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents cmbKategori As ComboBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtNamaBahan As TextBox
    Friend WithEvents txtKodeBahan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBahan As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTransaksi As Button   ' <<< DEKLARASI BARU
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class