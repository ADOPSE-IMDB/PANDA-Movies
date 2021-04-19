Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Movie
    Private mid As Integer
    Private mtitle As String
    Private myear As Date
    Private mdescription As String
    Private mrating As Double

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

    Sub Print()
        Console.WriteLine(Me.Id)
        Console.WriteLine(Me.Title)
        Console.WriteLine(Me.Year)
        Console.WriteLine(Me.Description)
        Console.WriteLine(Me.Rating)
    End Sub
End Class
