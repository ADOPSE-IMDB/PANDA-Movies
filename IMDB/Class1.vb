Imports MySql.Data.MySqlClient
Public Class Class1
    Private db_con As New MySqlConnection
    Private Sub connect()
        Dim dbname As String = "mySQL"
        Dim dbhost As String = "dblabs.it.teithe.gr"
        Dim user As String = "it185223"
        Dim pass As String = "spider22"


        If Not db_con Is Nothing Then db_con.Close()
        db_con.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", dbhost, user, pass, dbname)

        Try
            db_con.Open()
        Catch ex As MySqlException
            MsgBox("Database Error:[" & ex.Message & "]")
        End Try
    End Sub
End Class