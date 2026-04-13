Imports MySqlConnector

Public Class Form1


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()

                Dim sql As String = "SELECT * FROM tb_user WHERE Username=@user AND Password=@pass"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@user", txtLgUsername.Text)
                cmd.Parameters.AddWithValue("@pass", txtLgPassword.Text)

                Dim dr As MySqlDataReader = cmd.ExecuteReader

                If dr.HasRows Then
                    MsgBox("Login Berhasil!")
                    Form2.Show() ' Membuka Form CRUD
                    Me.Hide()
                Else
                    MsgBox("Username atau Password salah!")
                End If
            Catch ex As Exception
                MsgBox("Error Login: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LinkDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDaftar.LinkClicked
        FormDaftar.Show()
        Me.Hide()
    End Sub

End Class