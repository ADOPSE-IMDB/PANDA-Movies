Imports System.Data

Public Class Actor
    ReadOnly con As New Connection

    Private aid As Integer
    Private aname As String
    Private asurname As String

    Public Property Id() As Integer
        Get
            Return aid
        End Get
        Set(ByVal value As Integer)
            aid = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return aname
        End Get
        Set(ByVal value As String)
            aname = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return asurname
        End Get
        Set(ByVal value As String)
            asurname = value
        End Set
    End Property

    Sub GetAllActors(ByRef results As DataTable)
        con.RunQuery("select * from Actors", results)
    End Sub
End Class
