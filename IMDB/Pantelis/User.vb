Imports System.Data

Public Class User
    ReadOnly con As New Connection

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

    Sub LogIn(ByVal username, ByVal password)
        Dim results As New DataTable
        Dim args() As String = {username, password}

        con.RunQuery("select * from Users where username=@0 and password=@1", args, results)

        'Assign Values to Object
        For Each row As DataRow In results.Rows

            For Each col As DataColumn In results.Columns
                If col.ColumnName.Equals("id") Then
                    Me.Id = row(col)
                ElseIf col.ColumnName.Equals("first_name") Then
                    Me.First_name = row(col)
                ElseIf col.ColumnName.Equals("last_name") Then
                    Me.Last_name = row(col)
                ElseIf col.ColumnName.Equals("email") Then
                    Me.Email = row(col)
                ElseIf col.ColumnName.Equals("username") Then
                    Me.Username = row(col)
                End If

            Next

        Next
    End Sub

    Sub GetAllUsers(ByRef results As DataTable)
        con.RunQuery("select * from Users", results)
    End Sub
End Class
