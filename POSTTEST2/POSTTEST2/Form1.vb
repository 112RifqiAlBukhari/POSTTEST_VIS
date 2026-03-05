Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub TambahBuku(ByVal buku As String)

        daftarBuku(jumlahBuku) = buku
        jumlahBuku += 1

    End Sub
    Function FormatBuku(judul As String, genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text
        Dim genre As String = txtGenre.Text
        Dim data As String
        data = FormatBuku(judul, genre)
        TambahBuku(data)
        listBuku.Items.Add(data)
        txtJudul.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapus.Text
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).Contains(judul) Then
                listBuku.Items.Remove(daftarBuku(i))
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j) = daftarBuku(j + 1)
                Next
                jumlahBuku -= 1
                Exit For
            End If
        Next
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
