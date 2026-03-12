<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        picHasilFoto = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        lblGender = New Label()
        lblTelepon = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        Panel1 = New Panel()
        CType(picHasilFoto, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picHasilFoto
        ' 
        picHasilFoto.BackColor = Color.Linen
        picHasilFoto.BackgroundImageLayout = ImageLayout.Stretch
        picHasilFoto.Location = New Point(153, 185)
        picHasilFoto.Name = "picHasilFoto"
        picHasilFoto.Size = New Size(156, 238)
        picHasilFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picHasilFoto.TabIndex = 0
        picHasilFoto.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MidnightBlue
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(293, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama                          :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MidnightBlue
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(293, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 20)
        Label2.TabIndex = 2
        Label2.Text = "Umur                           :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MidnightBlue
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(293, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 20)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir              :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.MidnightBlue
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(293, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(157, 20)
        Label4.TabIndex = 4
        Label4.Text = "Jenis Kelamin              :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MidnightBlue
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(293, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 20)
        Label5.TabIndex = 5
        Label5.Text = "No Telepon                 :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MidnightBlue
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(293, 288)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 6
        Label6.Text = "Hobby                         :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MidnightBlue
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(293, 330)
        Label7.Name = "Label7"
        Label7.Size = New Size(156, 20)
        Label7.TabIndex = 7
        Label7.Text = "Alamat                        :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.MidnightBlue
        lblNama.ForeColor = SystemColors.ControlLightLight
        lblNama.Location = New Point(487, 66)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(15, 20)
        lblNama.TabIndex = 8
        lblNama.Text = "-"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.MidnightBlue
        lblUmur.ForeColor = SystemColors.ControlLightLight
        lblUmur.Location = New Point(487, 112)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(15, 20)
        lblUmur.TabIndex = 9
        lblUmur.Text = "-"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.BackColor = Color.MidnightBlue
        lblTanggal.ForeColor = SystemColors.ControlLightLight
        lblTanggal.Location = New Point(487, 155)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(15, 20)
        lblTanggal.TabIndex = 10
        lblTanggal.Text = "-"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.MidnightBlue
        lblGender.ForeColor = SystemColors.ControlLightLight
        lblGender.Location = New Point(487, 200)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(15, 20)
        lblGender.TabIndex = 11
        lblGender.Text = "-"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.BackColor = Color.MidnightBlue
        lblTelepon.ForeColor = SystemColors.ControlLightLight
        lblTelepon.Location = New Point(487, 245)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(15, 20)
        lblTelepon.TabIndex = 12
        lblTelepon.Text = "-"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = Color.MidnightBlue
        lblHobby.ForeColor = SystemColors.ControlLightLight
        lblHobby.Location = New Point(487, 288)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(15, 20)
        lblHobby.TabIndex = 13
        lblHobby.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.MidnightBlue
        lblAlamat.ForeColor = SystemColors.ControlLightLight
        lblAlamat.Location = New Point(487, 330)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(15, 20)
        lblAlamat.TabIndex = 14
        lblAlamat.Text = "-"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(picHasilFoto)
        Panel1.Location = New Point(-34, -73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(844, 532)
        Panel1.TabIndex = 15
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblTelepon)
        Controls.Add(lblGender)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        CType(picHasilFoto, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasilFoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents Panel1 As Panel
End Class
