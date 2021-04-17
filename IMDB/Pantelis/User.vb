Imports System.Data

Public Class User
    Private id As Integer
    Private first_name As String
    Private last_name As String
    Private email As String
    Private username As String
    Private password As String

    Sub GetAllUsers(ByRef results As DataTable)
        Dim con As New Connection
        con.RunQuery("select * from Users", results)
    End Sub
End Class
