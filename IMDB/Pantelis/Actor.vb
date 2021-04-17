Imports System.Data

Public Class Actor
    Private id As Integer
    Private name As String
    Private surname As String

    Sub GetAllActors(ByRef results As DataTable)
        Dim con As New Connection
        con.RunQuery("select * from Actors", results)
    End Sub
End Class
