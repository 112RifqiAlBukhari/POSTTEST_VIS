Imports MySqlConnector

Public Class FormDaftar
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtNama.Text = "" Then
            MsgBox("Semua data wajib diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        Using conn = GetConnection()
            Try
                conn.Open()

                Dim sql = "INSERT INTO tb_user (Username, Password, Nama) VALUES (@user, @pass, @nama)"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text)
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)

                cmd.ExecuteNonQuery()


                MsgBox("Pendaftaran Berhasil! Silakan Login.", MsgBoxStyle.Information)


                Form1.Show()
                Me.Close()

            Catch ex As Exception
                MsgBox("Gagal Daftar: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub


End Class