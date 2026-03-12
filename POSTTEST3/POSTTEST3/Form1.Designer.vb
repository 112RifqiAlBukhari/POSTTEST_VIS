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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblNama = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtAlamat = New TextBox()
        txtTelepon = New TextBox()
        dtTanggalLahir = New DateTimePicker()
        grpJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        cbFilm = New CheckBox()
        cbMenulis = New CheckBox()
        cbFotografi = New CheckBox()
        cbMemasak = New CheckBox()
        cbCoding = New CheckBox()
        cbTraveling = New CheckBox()
        cbMusik = New CheckBox()
        cbGame = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetak = New Button()
        Panel1 = New Panel()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(305, 82)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(305, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 1
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(305, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(307, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 3
        Label4.Text = "No telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(307, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 4
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(590, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 5
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.BurlyWood
        txtNama.Location = New Point(417, 82)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(253, 27)
        txtNama.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.BurlyWood
        txtUmur.Location = New Point(417, 124)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(253, 27)
        txtUmur.TabIndex = 7
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.BurlyWood
        txtAlamat.Location = New Point(417, 236)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(253, 27)
        txtAlamat.TabIndex = 8
        ' 
        ' txtTelepon
        ' 
        txtTelepon.BackColor = Color.BurlyWood
        txtTelepon.Location = New Point(417, 201)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(253, 27)
        txtTelepon.TabIndex = 9
        ' 
        ' dtTanggalLahir
        ' 
        dtTanggalLahir.CalendarMonthBackground = Color.BurlyWood
        dtTanggalLahir.Location = New Point(417, 163)
        dtTanggalLahir.Name = "dtTanggalLahir"
        dtTanggalLahir.Size = New Size(250, 27)
        dtTanggalLahir.TabIndex = 10
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.BackColor = Color.Linen
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Controls.Add(rbLaki)
        grpJenisKelamin.Location = New Point(307, 282)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(250, 195)
        grpJenisKelamin.TabIndex = 11
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(17, 75)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(17, 35)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.Linen
        grpHobby.Controls.Add(cbFilm)
        grpHobby.Controls.Add(cbMenulis)
        grpHobby.Controls.Add(cbFotografi)
        grpHobby.Controls.Add(cbMemasak)
        grpHobby.Controls.Add(cbCoding)
        grpHobby.Controls.Add(cbTraveling)
        grpHobby.Controls.Add(cbMusik)
        grpHobby.Controls.Add(cbGame)
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Location = New Point(563, 282)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(262, 195)
        grpHobby.TabIndex = 12
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbFilm
        ' 
        cbFilm.AutoSize = True
        cbFilm.Location = New Point(140, 136)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(59, 24)
        cbFilm.TabIndex = 9
        cbFilm.Text = "Film"
        cbFilm.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(140, 107)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 8
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(140, 80)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(92, 24)
        cbFotografi.TabIndex = 7
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(140, 54)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(94, 24)
        cbMemasak.TabIndex = 6
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(140, 26)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 5
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(14, 136)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(91, 24)
        cbTraveling.TabIndex = 4
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(14, 107)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(69, 24)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbGame
        ' 
        cbGame.AutoSize = True
        cbGame.Location = New Point(14, 80)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(70, 24)
        cbGame.TabIndex = 2
        cbGame.Text = "Game"
        cbGame.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(14, 54)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 1
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(14, 26)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.Linen
        picFoto.BackgroundImageLayout = ImageLayout.Stretch
        picFoto.Location = New Point(40, 82)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(259, 395)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 13
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SeaShell
        btnBrowse.Location = New Point(106, 479)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(113, 33)
        btnBrowse.TabIndex = 14
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.SeaShell
        btnCetak.Location = New Point(304, 480)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(519, 29)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(grpJenisKelamin)
        Panel1.Controls.Add(grpHobby)
        Panel1.Controls.Add(picFoto)
        Panel1.Controls.Add(btnCetak)
        Panel1.Controls.Add(txtAlamat)
        Panel1.Controls.Add(txtTelepon)
        Panel1.Controls.Add(dtTanggalLahir)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtUmur)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(-28, -70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(873, 581)
        Panel1.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents dtTanggalLahir As DateTimePicker
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGame As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents Panel1 As Panel

End Class
