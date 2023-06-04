Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If tbUsername.Text = "admin" And tbPassword.Text = "admin123" Then
            Me.Hide()
            MainApp.Show()
        ElseIf tbUsername.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Tolong Isi Username & Password Terlebih Dahulu")
        Else
            MsgBox("Username & Password Yang Anda Masukkan Salah")

        End If
    End Sub
End Class
