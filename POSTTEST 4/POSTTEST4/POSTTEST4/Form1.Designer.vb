<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mktNohp = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage3 = New TabPage()
        btnSimpan = New Button()
        GroupBox1 = New GroupBox()
        cbHobi8 = New CheckBox()
        cbHobi7 = New CheckBox()
        cbHobi6 = New CheckBox()
        cbHobi5 = New CheckBox()
        cbHobi4 = New CheckBox()
        cbHobi3 = New CheckBox()
        cbHobi2 = New CheckBox()
        cbHobi1 = New CheckBox()
        Label11 = New Label()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CbJabatan = New CheckBox()
        Label10 = New Label()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.RoyalBlue
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(595, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(205, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(405, 38)
        Label1.TabIndex = 2
        Label1.Text = "ID BEM Kampus Merdeka"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(60, 94)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(567, 305)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(559, 272)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cmbDivisi
        ' 
        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"Humas", "Ketua", "Wakil Ketua", "Kestari", "Kwh", "Media", "Kpsdm"})
        cmbDivisi.Location = New Point(172, 179)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(250, 28)
        cmbDivisi.TabIndex = 10
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(312, 133)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(172, 134)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(172, 94)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 6
        Label6.Text = "Divisi"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(172, 54)
        txtID.Name = "txtID"
        txtID.Size = New Size(250, 27)
        txtID.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(172, 19)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 3
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 1
        Label3.Text = "ID Anggota"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mktNohp)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(559, 272)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(152, 162)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(195, 27)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(152, 104)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(195, 27)
        txtEmail.TabIndex = 4
        ' 
        ' mktNohp
        ' 
        mktNohp.Location = New Point(152, 46)
        mktNohp.Mask = "0000-0000-0000"
        mktNohp.Name = "mktNohp"
        mktNohp.Size = New Size(195, 27)
        mktNohp.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(36, 162)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(36, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(36, 46)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 0
        Label7.Text = "No HP"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(picProfil)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(559, 272)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(183, 237)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(350, 29)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan dan Cetak Kartu"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbHobi8)
        GroupBox1.Controls.Add(cbHobi7)
        GroupBox1.Controls.Add(cbHobi6)
        GroupBox1.Controls.Add(cbHobi5)
        GroupBox1.Controls.Add(cbHobi4)
        GroupBox1.Controls.Add(cbHobi3)
        GroupBox1.Controls.Add(cbHobi2)
        GroupBox1.Controls.Add(cbHobi1)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CbJabatan)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Location = New Point(183, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 207)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' cbHobi8
        ' 
        cbHobi8.AutoSize = True
        cbHobi8.Location = New Point(233, 182)
        cbHobi8.Name = "cbHobi8"
        cbHobi8.Size = New Size(74, 24)
        cbHobi8.TabIndex = 13
        cbHobi8.Text = "Basket"
        cbHobi8.UseVisualStyleBackColor = True
        ' 
        ' cbHobi7
        ' 
        cbHobi7.AutoSize = True
        cbHobi7.Location = New Point(81, 181)
        cbHobi7.Name = "cbHobi7"
        cbHobi7.Size = New Size(104, 24)
        cbHobi7.TabIndex = 12
        cbHobi7.Text = "Badminton"
        cbHobi7.UseVisualStyleBackColor = True
        ' 
        ' cbHobi6
        ' 
        cbHobi6.AutoSize = True
        cbHobi6.Location = New Point(233, 154)
        cbHobi6.Name = "cbHobi6"
        cbHobi6.Size = New Size(67, 24)
        cbHobi6.TabIndex = 11
        cbHobi6.Text = "Padel"
        cbHobi6.UseVisualStyleBackColor = True
        ' 
        ' cbHobi5
        ' 
        cbHobi5.AutoSize = True
        cbHobi5.Location = New Point(233, 128)
        cbHobi5.Name = "cbHobi5"
        cbHobi5.Size = New Size(55, 24)
        cbHobi5.TabIndex = 10
        cbHobi5.Text = "Lari"
        cbHobi5.UseVisualStyleBackColor = True
        ' 
        ' cbHobi4
        ' 
        cbHobi4.AutoSize = True
        cbHobi4.Location = New Point(233, 98)
        cbHobi4.Name = "cbHobi4"
        cbHobi4.Size = New Size(92, 24)
        cbHobi4.TabIndex = 9
        cbHobi4.Text = "Fotografi"
        cbHobi4.UseVisualStyleBackColor = True
        ' 
        ' cbHobi3
        ' 
        cbHobi3.AutoSize = True
        cbHobi3.Location = New Point(83, 155)
        cbHobi3.Name = "cbHobi3"
        cbHobi3.Size = New Size(69, 24)
        cbHobi3.TabIndex = 8
        cbHobi3.Text = "Futsal"
        cbHobi3.UseVisualStyleBackColor = True
        ' 
        ' cbHobi2
        ' 
        cbHobi2.AutoSize = True
        cbHobi2.Location = New Point(83, 128)
        cbHobi2.Name = "cbHobi2"
        cbHobi2.Size = New Size(97, 24)
        cbHobi2.TabIndex = 7
        cbHobi2.Text = "Membaca"
        cbHobi2.UseVisualStyleBackColor = True
        ' 
        ' cbHobi1
        ' 
        cbHobi1.AutoSize = True
        cbHobi1.Location = New Point(83, 98)
        cbHobi1.Name = "cbHobi1"
        cbHobi1.Size = New Size(79, 24)
        cbHobi1.TabIndex = 6
        cbHobi1.Text = "Coding"
        cbHobi1.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(54, 20)
        Label11.TabIndex = 5
        Label11.Text = "Hobby"
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(234, 61)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(89, 24)
        CheckBox4.TabIndex = 4
        CheckBox4.Text = "Anggota"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(233, 24)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(109, 24)
        CheckBox3.TabIndex = 3
        CheckBox3.Text = "Wakil Ketua"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(85, 60)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(154, 24)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Ketua departemen"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CbJabatan
        ' 
        CbJabatan.AutoSize = True
        CbJabatan.Location = New Point(85, 25)
        CbJabatan.Name = "CbJabatan"
        CbJabatan.Size = New Size(69, 24)
        CbJabatan.TabIndex = 1
        CbJabatan.Text = "Ketua"
        CbJabatan.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 25)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 20)
        Label10.TabIndex = 0
        Label10.Text = "Jabatan"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(37, 237)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.Location = New Point(16, 24)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(147, 207)
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mktNohp As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CbJabatan As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbHobi6 As CheckBox
    Friend WithEvents cbHobi5 As CheckBox
    Friend WithEvents cbHobi4 As CheckBox
    Friend WithEvents cbHobi3 As CheckBox
    Friend WithEvents cbHobi2 As CheckBox
    Friend WithEvents cbHobi1 As CheckBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbHobi8 As CheckBox
    Friend WithEvents cbHobi7 As CheckBox

End Class
