Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Movie
    Private id As Integer
    Private title As String
    Private year As Date
    Private description As String
    Private rating As Double

    Sub GetAllMovies(ByRef results As DataTable)
        Dim con As New Connection
        con.RunQuery("select * from Movies", results)
    End Sub

    Sub GetTopMovies(ByRef results As DataTable)
        Dim con As New Connection
        con.RunQuery("select * from Movies where rating > 9.0 limit 10", results)
    End Sub

    Sub CountMovies(ByRef results As DataTable)
        Dim con As New Connection
        con.RunQuery("select MAX(id) as TotalMovies from Movies", results)
    End Sub

    Sub GetMoviesFromTo(ByVal fromNum As Integer, ByVal toNum As Integer, ByRef results As DataTable)
        Dim con As New Connection
        Dim DReader As MySqlDataReader
        Dim cmd As MySqlCommand = New MySqlCommand()

        Try
            con.Connect()
            cmd.Connection = con.getConnection
            cmd.CommandText = "select * from Movies where id between @fromNum and @toNum"
            cmd.Parameters.Add("@fromNum", MySqlDbType.Int32).Value = fromNum
            cmd.Parameters.Add("@toNum", MySqlDbType.Int32).Value = toNum
            DReader = cmd.ExecuteReader
            results.Clear()
            results.Constraints.Clear()
            results.Load(DReader)
        Catch ex As Exception
            Console.WriteLine("Problem with Query Execution (GetMoviesFromTo)")
        Finally
            DReader.Close()
            con.Disconnect()
        End Try
    End Sub
End Class
