Public Class Genre
    Private gid As Integer
    Private gname As String

    Public Property Id() As Integer
        Get
            Return gid
        End Get
        Set(ByVal value As Integer)
            gid = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return gname
        End Get
        Set(ByVal value As String)
            gname = value
        End Set
    End Property

    Sub Print()
        Console.WriteLine(Me.Id)
        Console.WriteLine(Me.Name)
    End Sub
End Class
