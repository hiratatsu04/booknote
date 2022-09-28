Option Strict On

Imports System.Data.SQLite

Public Class ManageDB

    ' データベース関連変数の作成
    Public Property connectToDB As SQLiteConnection
    Public Property commandDB As SQLiteCommand
    Public Property dataReader As SQLiteDataReader

    ' データベースの保管場所
    Private Const dbPath As String = "C:\Users\tatsuya-hirano\Documents\repos\booknote\src\booknote\db\books.db"

    ' データベースへ接続
    Public Sub ConnectDB()

        connectToDB = New SQLiteConnection()
        commandDB = New SQLiteCommand()
        dataReader = Nothing

        connectToDB.ConnectionString = "Data Source=" + dbPath
        connectToDB.Open()

    End Sub

    Public Function GetAllBookData() As List(Of Book)

        Dim bookList As List(Of Book) = Nothing

        ConnectDB()

        commandDB.Connection = connectToDB
        commandDB.CommandText = "SELECT * FROM books;"

        ' SQLの実行結果を受け取る
        dataReader = commandDB.ExecuteReader()
        If (dataReader.HasRows) Then

            While (dataReader.Read())

                Dim bookInfo As New Book()

                bookInfo.ID = CType(dataReader("id"), Integer)
                bookInfo.Title = dataReader("title").ToString()
                bookInfo.Author = dataReader("author").ToString()

                Dim converter As New ImageConverter()
                If dataReader("book_image") = Nothing Then
                    bookInfo.BookImage = CType(converter.ConvertFrom(dataReader("book_image")), Image)
                End If

                bookInfo.Genre = dataReader("genre").ToString()
                bookInfo.ReviewValue = CType(dataReader("review_value"), Double)
                bookInfo.Memo = dataReader("memo").ToString()
                bookInfo.BuyDate = CType(dataReader("buy_date"), Date)
                bookInfo.StartReadDate = CType(dataReader("start_date"), Date)
                bookInfo.EndReadDate = CType(dataReader("end_date"), Date)
                bookInfo.RecodeDate = CType(dataReader("recode_date"), Date)
                bookInfo.UpdateDate = CType(dataReader("update_date"), Date)

                bookList.Add(bookInfo)

            End While
            dataReader.Close()

        End If

        connectToDB.Close()

        Return bookList

    End Function

End Class
