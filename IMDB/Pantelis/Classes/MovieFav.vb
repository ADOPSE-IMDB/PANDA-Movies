Imports System.Data
Imports MySql.Data.MySqlClient
Public Class MovieFav
    Private fid As Integer
    Private fmovie_id As Integer
    Private fuser_id As Integer

    Public Property Id() As Integer
        Get
            Return fid
        End Get
        Set(ByVal value As Integer)
            fid = value
        End Set
    End Property
    Public Property Movie_Id() As Integer
        Get
            Return fmovie_id
        End Get
        Set(ByVal value As Integer)
            fmovie_id = value
        End Set
    End Property
    Public Property User_Id() As Integer
        Get
            Return fuser_id
        End Get
        Set(ByVal value As Integer)
            fuser_id = value
        End Set
    End Property

    Sub Print()
        Console.WriteLine(Me.Id)
        Console.WriteLine(Me.Movie_Id)
        Console.WriteLine(Me.User_Id)

    End Sub
End Class
