Public Class BookList
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim f As New BookDetail()
        f.ShowDialog(Me)

    End Sub
End Class
