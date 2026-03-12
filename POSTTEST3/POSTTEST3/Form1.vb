Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtUmur_TextChanged(sender As Object, e As EventArgs) Handles txtUmur.TextChanged

    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grpHobby.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpJenisKelamin.Enter

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        Dim cek As Boolean = False

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    cek = True
                End If
            End If
        Next

        If cek = False Then
            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub
        End If

        Dim formHasil As New Form2

        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text
        formHasil.lblTelepon.Text = txtTelepon.Text
        formHasil.lblTanggal.Text = dtTanggalLahir.Value
        formHasil.lblAlamat.Text = txtAlamat.Text

        If rbLaki.Checked Then
            formHasil.lblGender.Text = "Laki-Laki"
        Else
            formHasil.lblGender.Text = "Perempuan"
        End If

        Dim hobby As String = ""

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hobby &= ctrl.Text & ", "
                End If
            End If
        Next

        formHasil.lblHobby.Text = hobby

        formHasil.picHasilFoto.Image = picFoto.Image
        formHasil.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim open As New OpenFileDialog

        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If open.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(open.FileName)
        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If



    End Sub

End Class
