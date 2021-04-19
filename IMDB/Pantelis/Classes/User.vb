Imports System.Data

Public Class User
    Private uid As Integer
    Private ufirst_name As String
    Private ulast_name As String
    Private uemail As String
    Private uusername As String

    Public Property Id() As Integer
        Get
            Return uid
        End Get
        Set(ByVal value As Integer)
            uid = value
        End Set
    End Property
    Public Property First_name() As String
        Get
            Return ufirst_name
        End Get
        Set(ByVal value As String)
            ufirst_name = value
        End Set
    End Property
    Public Property Last_name() As String
        Get
            Return ulast_name
        End Get
        Set(ByVal value As String)
            ulast_name = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return uemail
        End Get
        Set(ByVal value As String)
            uemail = value
        End Set
    End Property
    Public Property Username() As String
        Get
            Return uusername
        End Get
        Set(ByVal value As String)
            uusername = value
        End Set
    End Property

    Sub Print()
        Console.WriteLine(Me.Id)
        Console.WriteLine(Me.First_name)
        Console.WriteLine(Me.Last_name)
        Console.WriteLine(Me.Email)
        Console.WriteLine(Me.Username)
    End Sub
End Class
