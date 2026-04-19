<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        lblJudul = New Label()
        lblBahan = New Label()
        cmbBahan = New ComboBox()
        lblStokInfo = New Label()
        lblJumlah = New Label()
        txtJumlah = New TextBox()
        lblTanggal = New Label()
        dtpTanggal = New DateTimePicker()
        lblKeterangan = New Label()
        txtKeterangan = New TextBox()
        btnSimpan = New Button()
        btnHapus = New Button()
        btnBersih = New Button()
        btnKembali = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        GroupBox1 = New GroupBox()
        dgvTransaksi = New DataGridView()
        lblIdInfo = New Label()
        txtIdEdit = New TextBox()
        GroupBox1.SuspendLayout()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(100), CByte(200), CByte(255))
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(479, 37)
        lblJudul.TabIndex = 0
        lblJudul.Text = "📋 Update Penggunaan Bahan Baku"
        ' 
        ' lblBahan
        ' 
        lblBahan.AutoSize = True
        lblBahan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBahan.ForeColor = Color.White
        lblBahan.Location = New Point(20, 60)
        lblBahan.Name = "lblBahan"
        lblBahan.Size = New Size(126, 20)
        lblBahan.TabIndex = 9
        lblBahan.Text = "Pilih Bahan Baku"
        ' 
        ' cmbBahan
        ' 
        cmbBahan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        cmbBahan.FlatStyle = FlatStyle.Popup
        cmbBahan.Font = New Font("Segoe UI", 13F)
        cmbBahan.ForeColor = Color.White
        cmbBahan.FormattingEnabled = True
        cmbBahan.Location = New Point(20, 82)
        cmbBahan.Name = "cmbBahan"
        cmbBahan.Size = New Size(450, 38)
        cmbBahan.TabIndex = 1
        ' 
        ' lblStokInfo
        ' 
        lblStokInfo.AutoSize = True
        lblStokInfo.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblStokInfo.ForeColor = Color.LightGreen
        lblStokInfo.Location = New Point(480, 91)
        lblStokInfo.Name = "lblStokInfo"
        lblStokInfo.Size = New Size(49, 20)
        lblStokInfo.TabIndex = 10
        lblStokInfo.Text = "Stok: -"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJumlah.ForeColor = Color.White
        lblJumlah.Location = New Point(20, 135)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(101, 20)
        lblJumlah.TabIndex = 11
        lblJumlah.Text = "Jumlah Pakai"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtJumlah.BorderStyle = BorderStyle.FixedSingle
        txtJumlah.Font = New Font("Segoe UI", 13F)
        txtJumlah.ForeColor = Color.White
        txtJumlah.Location = New Point(20, 157)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(200, 36)
        txtJumlah.TabIndex = 2
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.White
        lblTanggal.Location = New Point(240, 135)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(64, 20)
        lblTanggal.TabIndex = 12
        lblTanggal.Text = "Tanggal"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarForeColor = Color.Black
        dtpTanggal.Font = New Font("Segoe UI", 12F)
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(240, 157)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(230, 34)
        dtpTanggal.TabIndex = 3
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblKeterangan.ForeColor = Color.White
        lblKeterangan.Location = New Point(20, 210)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(90, 20)
        lblKeterangan.TabIndex = 13
        lblKeterangan.Text = "Keterangan"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtKeterangan.BorderStyle = BorderStyle.FixedSingle
        txtKeterangan.Font = New Font("Segoe UI", 12F)
        txtKeterangan.ForeColor = Color.White
        txtKeterangan.Location = New Point(20, 232)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(450, 34)
        txtKeterangan.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(20, 310)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(130, 45)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "💾 Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(50), CByte(50))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(165, 310)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(130, 45)
        btnHapus.TabIndex = 6
        btnHapus.Text = "🗑️ Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBersih
        ' 
        btnBersih.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnBersih.FlatStyle = FlatStyle.Flat
        btnBersih.Font = New Font("Segoe UI", 10F)
        btnBersih.ForeColor = Color.White
        btnBersih.Location = New Point(310, 310)
        btnBersih.Name = "btnBersih"
        btnBersih.Size = New Size(130, 45)
        btnBersih.TabIndex = 7
        btnBersih.Text = "🔄 Bersihkan"
        btnBersih.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10F)
        btnKembali.ForeColor = Color.LightBlue
        btnKembali.Location = New Point(660, 15)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(140, 40)
        btnKembali.TabIndex = 8
        btnKembali.Text = "← Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCari.ForeColor = Color.White
        lblCari.Location = New Point(20, 370)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(131, 20)
        lblCari.TabIndex = 16
        lblCari.Text = "🔍 Cari Transaksi"
        ' 
        ' txtCari
        ' 
        txtCari.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        txtCari.BorderStyle = BorderStyle.FixedSingle
        txtCari.Font = New Font("Segoe UI", 13F)
        txtCari.ForeColor = Color.White
        txtCari.Location = New Point(20, 392)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama bahan atau keterangan..."
        txtCari.Size = New Size(780, 36)
        txtCari.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvTransaksi)
        GroupBox1.ForeColor = Color.Silver
        GroupBox1.Location = New Point(20, 440)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(780, 295)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Transaksi"
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(100), CByte(180))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvTransaksi.DefaultCellStyle = DataGridViewCellStyle1
        dgvTransaksi.GridColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        dgvTransaksi.Location = New Point(0, 0)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.ReadOnly = True
        dgvTransaksi.RowHeadersWidth = 51
        dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransaksi.Size = New Size(778, 290)
        dgvTransaksi.TabIndex = 1
        ' 
        ' lblIdInfo
        ' 
        lblIdInfo.AutoSize = True
        lblIdInfo.Font = New Font("Segoe UI", 8F, FontStyle.Italic)
        lblIdInfo.ForeColor = Color.Silver
        lblIdInfo.Location = New Point(20, 285)
        lblIdInfo.Name = "lblIdInfo"
        lblIdInfo.Size = New Size(67, 19)
        lblIdInfo.TabIndex = 14
        lblIdInfo.Text = "ID: (auto)"
        ' 
        ' txtIdEdit
        ' 
        txtIdEdit.Location = New Point(20, 302)
        txtIdEdit.Name = "txtIdEdit"
        txtIdEdit.Size = New Size(1, 27)
        txtIdEdit.TabIndex = 15
        txtIdEdit.Visible = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(820, 750)
        Controls.Add(lblJudul)
        Controls.Add(btnKembali)
        Controls.Add(lblBahan)
        Controls.Add(cmbBahan)
        Controls.Add(lblStokInfo)
        Controls.Add(lblJumlah)
        Controls.Add(txtJumlah)
        Controls.Add(lblTanggal)
        Controls.Add(dtpTanggal)
        Controls.Add(lblKeterangan)
        Controls.Add(txtKeterangan)
        Controls.Add(lblIdInfo)
        Controls.Add(txtIdEdit)
        Controls.Add(btnSimpan)
        Controls.Add(btnHapus)
        Controls.Add(btnBersih)
        Controls.Add(lblCari)
        Controls.Add(txtCari)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        Name = "Form3"
        Text = "Transaksi Penggunaan Bahan"
        GroupBox1.ResumeLayout(False)
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblBahan As Label
    Friend WithEvents cmbBahan As ComboBox
    Friend WithEvents lblStokInfo As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents lblTanggal As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblIdInfo As Label
    Friend WithEvents txtIdEdit As TextBox
End Class