Option Strict On

Imports System.Data.SQLite

Public Class ManageDB

    ' データベース関連変数の作成
    Private connectToDB As SQLiteConnection
    Private commandDB As SQLiteCommand
    Private dataReader As SQLiteDataReader

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

    Public Function GetOneBookData(ID As Integer) As Book

        Dim bookInfo As New Book()

        ConnectDB()   ' データベースへ接続
        commandDB.Connection = connectToDB
        commandDB.CommandText = "SELECT * FROM books;"

        ' SQLの実行結果を受け取る
        dataReader = commandDB.ExecuteReader()

        ' IDと一致するデータをプロパティに設定
        If (dataReader.HasRows) Then
            While (dataReader.Read())
                If CType(dataReader("id"), Integer) = ID Then
                    bookInfo.ID = CType(dataReader("id"), Integer)
                    bookInfo.Title = dataReader("title").ToString()
                    bookInfo.Author = dataReader("author").ToString()
                    bookInfo.BookImage = ConvertBLOBToImage(dataReader("book_image"))
                    bookInfo.Genre = dataReader("genre").ToString()
                    bookInfo.ReviewValue = CType(CheckDBNull(dataReader("review_value")), Double)
                    bookInfo.Memo = dataReader("memo").ToString()
                    bookInfo.BuyDate = CType(CheckDBNull(dataReader("buy_date")), Date)
                    bookInfo.StartReadDate = CType(CheckDBNull(dataReader("start_date")), Date)
                    bookInfo.EndReadDate = CType(CheckDBNull(dataReader("end_date")), Date)
                    bookInfo.RecodeDate = CType(CheckDBNull(dataReader("recode_date")), Date)
                    bookInfo.UpdateDate = CType(CheckDBNull(dataReader("update_date")), Date)
                End If
            End While
            dataReader.Close()
        End If
        connectToDB.Close()

        Return bookInfo

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllBookData() As List(Of Book)

        Dim bookList As New List(Of Book)

        ConnectDB()   ' データベースへ接続
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
                bookInfo.BookImage = ConvertBLOBToImage(dataReader("book_image"))
                bookInfo.Genre = dataReader("genre").ToString()
                bookInfo.ReviewValue = CType(CheckDBNull(dataReader("review_value")), Double)
                bookInfo.Memo = dataReader("memo").ToString()
                bookInfo.BuyDate = CType(CheckDBNull(dataReader("buy_date")), Date)
                bookInfo.StartReadDate = CType(CheckDBNull(dataReader("start_date")), Date)
                bookInfo.EndReadDate = CType(CheckDBNull(dataReader("end_date")), Date)
                bookInfo.RecodeDate = CType(CheckDBNull(dataReader("recode_date")), Date)
                bookInfo.UpdateDate = CType(CheckDBNull(dataReader("update_date")), Date)

                bookList.Add(bookInfo)
            End While
            dataReader.Close()
        End If
        connectToDB.Close()

        Return bookList
    End Function

    Public Sub RecodeBook(book As Book)

        ConnectDB()   ' データベースへ接続
        commandDB.Connection = connectToDB

        commandDB.CommandText =
            $"INSERT INTO books(title, author, book_image, genre, review_value,
            memo, buy_date, start_date, end_date )
            VALUES('{book.Title}', '{book.Author}', @image, '{book.Genre}',
            '{book.ReviewValue}', '{book.Memo}', '{book.BuyDate}', '{book.StartReadDate}',
            '{book.EndReadDate}');"

        ' ここ何をしているのか不明
        Dim imageData As Byte() = ConvertImageToByte(book.BookImage)
        Dim param As SQLiteParameter = New SQLiteParameter("@image", DbType.Binary)
        param.Value = imageData
        commandDB.Parameters.Add(param)
        commandDB.ExecuteNonQuery()

        connectToDB.Close()
    End Sub

    Public Shared Function ConvertImageToByte(image As Image) As Byte()
        Dim converter As New ImageConverter()
        Dim imageByte As Byte() = CType(converter.ConvertTo(image, GetType(Byte())), Byte())
        Return imageByte
    End Function

    Public Shared Function ConvertBLOBToImage(imageObject As Object) As Image
        Dim image As Image = Nothing

        ' オブジェクトの値がNULLでなければImage型へ変換する
        If Not DBNull.Value.Equals(imageObject) Then
            image = CType(New ImageConverter().ConvertFrom(imageObject), Image)
        End If

        Return image
    End Function

    Public Shared Function CheckDBNull(value As Object) As Object
        Dim returnValue As Object = Nothing

        If Not DBNull.Value.Equals(value) Then
            returnValue = value
        End If

        Return returnValue
    End Function

End Class
