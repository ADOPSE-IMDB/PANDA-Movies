Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Connection
    Private con As New MySqlConnection("Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return con
        End Get
    End Property

    Sub Connect()
        con.Open()
    End Sub

    Sub Disconnect()
        con.Close()
    End Sub

    Sub RunQuery(ByVal query As String, ByRef results As DataTable)
        Dim cmd As MySqlCommand = New MySqlCommand()
        Dim DReader As MySqlDataReader

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = query
            DReader = cmd.ExecuteReader
            results.Clear()
            results.Constraints.Clear()
            results.Load(DReader)
        Catch ex As Exception
            Console.WriteLine("Problem with Query Execution")
        Finally
            DReader.Close()
            con.Close()
        End Try
    End Sub
End Class
