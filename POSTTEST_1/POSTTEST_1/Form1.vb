Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ip As Double

        If Double.TryParse(TextBox1.Text, ip) Then

            If ip < 0 Or ip > 4 Then
                MessageBox.Show("IP harus antara 0 - 4")
                Exit Sub
            End If

            totalIP += ip
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester

            TextBox2.Text = ipk.ToString("F2")
            Label4.Text = HitungPredikat(ipk)

            TextBox1.Clear()

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function HitungPredikat(ipk As Double) As String
        If ipk >= 2.0 And ipk <= 2.75 Then
            Return "Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            Return "Memuaskan"
        ElseIf ipk >= 3.01 Then
            Return "Sangat Memuaskan"
        Else
            Return "-"
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalIP = 0
        jumlahSemester = 0

        TextBox1.Clear()
        TextBox2.Text = "0.00"
        Label4.Text = "-"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
