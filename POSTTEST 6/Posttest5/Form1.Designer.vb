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
        Label9 = New Label()
        LinkDaftar = New LinkLabel()
        btnLogin = New Button()
        txtLgPassword = New TextBox()
        txtLgUsername = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(65, 318)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 20)
        Label9.TabIndex = 7
        Label9.Text = "Belum Punya Akun?"
        ' 
        ' LinkDaftar
        ' 
        LinkDaftar.AutoSize = True
        LinkDaftar.LinkColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        LinkDaftar.Location = New Point(209, 318)
        LinkDaftar.Name = "LinkDaftar"
        LinkDaftar.Size = New Size(51, 20)
        LinkDaftar.TabIndex = 6
        LinkDaftar.TabStop = True
        LinkDaftar.Text = "Daftar"
        ' 
        ' btnLogin
        ' 
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(79, 270)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(167, 29)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtLgPassword
        ' 
        txtLgPassword.Location = New Point(138, 208)
        txtLgPassword.Name = "txtLgPassword"
        txtLgPassword.PasswordChar = "*"c
        txtLgPassword.Size = New Size(166, 27)
        txtLgPassword.TabIndex = 4
        ' 
        ' txtLgUsername
        ' 
        txtLgUsername.Location = New Point(138, 151)
        txtLgUsername.Name = "txtLgUsername"
        txtLgUsername.Size = New Size(166, 27)
        txtLgUsername.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 211)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 20)
        Label8.TabIndex = 2
        Label8.Text = "Password    :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 20)
        Label7.TabIndex = 1
        Label7.Text = "Username   :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label6.Location = New Point(36, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(268, 30)
        Label6.TabIndex = 0
        Label6.Text = "Selamat Datang Kembali"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(332, 374)
        Controls.Add(Label9)
        Controls.Add(LinkDaftar)
        Controls.Add(Label6)
        Controls.Add(btnLogin)
        Controls.Add(txtLgUsername)
        Controls.Add(txtLgPassword)
        Controls.Add(Label7)
        Controls.Add(Label8)
        ForeColor = Color.White
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLgPassword As TextBox
    Friend WithEvents txtLgUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkDaftar As LinkLabel

End Class
