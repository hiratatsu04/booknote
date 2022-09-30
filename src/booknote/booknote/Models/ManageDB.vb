Option Strict On

Imports System.Data.SQLite

Public Class ManageDB

    ' データベース関連変数の作成
    Private connectToDB As SQLiteConnection
    Private commandDB As SQLiteCommand
    Private dataReader As SQLiteDataReader

    ' データベースの保管場所
    Private dbPath As String = System.Environment.CurrentDirectory + "\database\books.db"

    ''' <summary>
    ''' データベースへ接続
    ''' </summary>
    Private Sub ConnectDB()

        connectToDB = New SQLiteConnection()
        commandDB = New SQLiteCommand()
        dataReader = Nothing

        connectToDB.ConnectionString = "Data Source=" + dbPath
        connectToDB.Open()

    End Sub

    Public Sub DeleteBookData(book As Book)
        Try
            ConnectDB()   ' データベースへ接続
            commandDB.Connection = connectToDB
            commandDB.CommandText = $"DELETE FROM books WHERE id=@id;"
            AddSqlParameter(commandDB, "@id", DbType.Int32, book.ID)
            commandDB.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connectToDB.Close()
        End Try
    End Sub

    ''' <summary>
    ''' データベースの値を引数bookに更新する。
    ''' </summary>
    ''' <param name="book"></param>
    Public Sub UpdateBookData(book As Book)

        Try
            ConnectDB()   ' データベースへ接続
            commandDB.Connection = connectToDB

            commandDB.CommandText =
                $"UPDATE books SET title = @title, author = @author, book_image = @book_image,
            genre = @genre, review_value = @review_value, memo = @memo, buy_date = @buy_date, start_date = @start_date, end_date = @end_date, update_date = @update_date WHERE id = @id;"

            AddSqlParameter(commandDB, "@title", DbType.String, book.Title)
            AddSqlParameter(commandDB, "@author", DbType.String, book.Author)
            AddSqlParameter(commandDB, "@book_image", DbType.Binary, ConvertImageToByte(book.BookImage))
            AddSqlParameter(commandDB, "@genre", DbType.String, book.Genre)
            AddSqlParameter(commandDB, "@review_value", DbType.String, book.ReviewValue)
            AddSqlParameter(commandDB, "@memo", DbType.String, book.Memo)
            AddSqlParameter(commandDB, "@buy_date", DbType.String, book.BuyDate)
            AddSqlParameter(commandDB, "@start_date", DbType.String, book.StartReadDate)
            AddSqlParameter(commandDB, "@end_date", DbType.String, book.EndReadDate)
            AddSqlParameter(commandDB, "@update_date", DbType.String, System.DateTime.Now)
            AddSqlParameter(commandDB, "@id", DbType.Int32, book.ID)


            commandDB.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connectToDB.Close()
        End Try

    End Sub

    ''' <summary>
    ''' 引数IDに該当するデータをデータベースから取得する
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function GetOneBookData(id As Integer) As Book

        Dim bookInfo As New Book()

        Try
            ConnectDB()   ' データベースへ接続
            commandDB.Connection = connectToDB
            commandDB.CommandText = $"SELECT * FROM books WHERE id=@id;"
            AddSqlParameter(commandDB, "@id", DbType.Int32, id)
            commandDB.ExecuteNonQuery()

            ' SQLの実行結果を受け取る
            dataReader = commandDB.ExecuteReader()

            ' idと一致するデータをプロパティに設定
            If (dataReader.HasRows) Then
                While (dataReader.Read())
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
                End While
                dataReader.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connectToDB.Close()
        End Try

        Return bookInfo

    End Function

    ''' <summary>
    ''' データベースに保存されている全データを取得する
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllBookData() As List(Of Book)

        Dim bookList As New List(Of Book)

        Try
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
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connectToDB.Close()
        End Try

        Return bookList
    End Function

    ''' <summary>
    ''' 引数bookの値をデータベースに新規登録する
    ''' </summary>
    ''' <param name="book"></param>
    Public Sub RecodeBook(book As Book)

        Try
            ConnectDB()   ' データベースへ接続
            commandDB.Connection = connectToDB

            commandDB.CommandText =
                $"INSERT INTO books(title, author, book_image, genre, review_value,
            memo, buy_date, start_date, end_date )
            VALUES(@title, @author, @book_image, @genre,
            @review_value, @memo, @buy_date, @start_date,
            @end_date);"

            AddSqlParameter(commandDB, "@title", DbType.String, book.Title)
            AddSqlParameter(commandDB, "@author", DbType.String, book.Author)
            AddSqlParameter(commandDB, "@genre", DbType.String, book.Genre)
            AddSqlParameter(commandDB, "@review_value", DbType.String, book.ReviewValue)
            AddSqlParameter(commandDB, "@memo", DbType.String, book.Memo)
            AddSqlParameter(commandDB, "@buy_date", DbType.String, book.BuyDate)
            AddSqlParameter(commandDB, "@start_date", DbType.String, book.StartReadDate)
            AddSqlParameter(commandDB, "@end_date", DbType.String, book.EndReadDate)

            ' 書籍データが無ければNoImage画像を保存する
            If book.BookImage Is Nothing Then
                Dim filePath As String = System.Environment.CurrentDirectory + "\image\noimage.png"
                Dim noImage As Image = Bitmap.FromFile(filePath)
                AddSqlParameter(commandDB, "@book_image", DbType.Binary, ConvertImageToByte(noImage))
            Else
                AddSqlParameter(commandDB, "@book_image", DbType.Binary, ConvertImageToByte(book.BookImage))
            End If

            commandDB.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connectToDB.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Image型からByte型へ変換する
    ''' </summary>
    ''' <param name="image"></param>
    ''' <returns></returns>
    Public Shared Function ConvertImageToByte(image As Image) As Byte()

        If image IsNot Nothing Then
            Dim converter As New ImageConverter()
            Dim imageByte As Byte() = CType(converter.ConvertTo(image, GetType(Byte())), Byte())
            Return imageByte
        End If

        Dim returnData As Byte() = Nothing
        Return returnData
    End Function

    ''' <summary>
    ''' BLOB型からImage型へ変換する
    ''' </summary>
    ''' <param name="imageObject"></param>
    ''' <returns></returns>
    Public Shared Function ConvertBLOBToImage(imageObject As Object) As Image
        Dim image As Image = Nothing

        ' オブジェクトの値がNULLでなければImage型へ変換する
        If Not DBNull.Value.Equals(imageObject) Then
            image = CType(New ImageConverter().ConvertFrom(imageObject), Image)
        End If

        Return image
    End Function

    ''' <summary>
    ''' 引数の値がDBNullかどうか判定する
    ''' DBNullであればNothingを返す
    ''' DBNullでなければ、そのまま返す
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Shared Function CheckDBNull(value As Object) As Object
        Dim returnValue As Object = Nothing

        If Not DBNull.Value.Equals(value) Then
            returnValue = value
        End If

        Return returnValue
    End Function

    ''' <summary>
    ''' @で始まるパラメータに対して、プレースホルダー処理を行い、ByRefでSQLiteCommandに追加する
    ''' </summary>
    ''' <param name="command"></param>
    ''' <param name="parameterName"></param>
    ''' <param name="type"></param>
    ''' <param name="value"></param>
    Public Shared Sub AddSqlParameter(ByRef command As SQLiteCommand, parameterName As String, type As DbType, value As Object)

        Dim param As SQLiteParameter = command.CreateParameter()
        param.ParameterName = parameterName
        param.DbType = type
        param.Direction = ParameterDirection.Input
        param.Value = value
        command.Parameters.Add(param)

    End Sub

End Class
