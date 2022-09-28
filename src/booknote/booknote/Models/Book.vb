Option Strict On

Public Class Book

    ' フィールドの定義
    Public Property ID As Integer
    Public Property Title As String
    Public Property Author As String

    'Private _bookImage As Byte()
    'Public Property BookImage As Image
    '    Get
    '        Dim converter As New ImageConverter()
    '        Dim img As Image = CType(converter.ConvertFrom(_bookImage), Image)
    '        Return img
    '    End Get
    '    Set(value As Image)
    '        Dim converter As New ImageConverter()
    '        _bookImage = CType(converter.ConvertTo(value, GetType(Byte())), Byte())
    '    End Set
    'End Property

    Public Property BookImage As Image

    Public Property Genre As String
    Public Property ReviewValue As Double
    Public Property Memo As String
    Public Property BuyDate As Date
    Public Property StartReadDate As Date
    Public Property EndReadDate As Date
    Public Property RecodeDate As Date
    Public Property UpdateDate As Date


End Class
