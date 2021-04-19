Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Movie
    ReadOnly con As New Connection

    Private mid As Integer
    Private mtitle As String
    Private myear As Date
    Private mdescription As String
    Private mrating As Double
    'private fav As Boolean

    Public Property Id() As Integer
        Get
            Return mid
        End Get
        Set(ByVal value As Integer)
            mid = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return mtitle
        End Get
        Set(ByVal value As String)
            mtitle = value
        End Set
    End Property

    Public Property Year() As String
        Get
            Return myear
        End Get
        Set(ByVal value As String)
            myear = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return mdescription
        End Get
        Set(ByVal value As String)
            mdescription = value
        End Set
    End Property

    Public Property Rating() As String
        Get
            Return mrating
        End Get
        Set(ByVal value As String)
            mrating = value
        End Set
    End Property

    Sub GetAllMovies(ByRef results As DataTable)
        con.RunQuery("select * from Movies", results)
    End Sub

    Sub GetTopMovies(ByRef results As DataTable)
        con.RunQuery("select * from Movies order by rating limit 10", results)
    End Sub

    Public Function CountMovies()
        Dim results As New DataTable
        con.RunQuery("select count(*) as num from Movies", results)
        Return results.Rows(0)("num").ToString()
    End Function

    Function GetMoviesFromTo(ByVal fromNum As Integer, ByVal toNum As Integer)
        Dim args() As String = {fromNum, toNum}
        Dim c = 1
        Dim results As New DataTable
        con.RunQuery("select * from Movies where id between @0 and @1", args, results)

        Return results
    End Function
End Class
