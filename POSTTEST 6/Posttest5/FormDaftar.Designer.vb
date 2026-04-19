<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftar
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
        txtUsername = New TextBox()
        txtNama = New TextBox()
        btnDaftar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(137, 233)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(167, 27)
        txtUsername.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(137, 183)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(167, 27)
        txtNama.TabIndex = 6
        ' 
        ' btnDaftar
        ' 
        btnDaftar.ForeColor = Color.Black
        btnDaftar.Location = New Point(72, 344)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(167, 29)
        btnDaftar.TabIndex = 4
        btnDaftar.Text = "Daftar"
        btnDaftar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 3
        Label4.Text = "Nama        :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password   :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username  :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(39, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 30)
        Label1.TabIndex = 0
        Label1.Text = "Silahkan Membuat Akun"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(137, 280)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(167, 27)
        txtPassword.TabIndex = 8
        ' 
        ' FormDaftar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(334, 450)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(btnDaftar)
        Controls.Add(Label4)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(Label3)
        ForeColor = Color.White
        Name = "FormDaftar"
        Text = "FormDaftar"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
End Class
