Option Strict On

Public Class BookList

    Dim bookList As List(Of Book)
    Dim manageDB As ManageDB

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim f As New BookDetail()
        f.ShowDialog(Me)

    End Sub

    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ManageDB = New ManageDB()
        bookList = manageDB.GetAllBookData()
        BookListBox.Items.Add(bookList)

    End Sub
End Class
