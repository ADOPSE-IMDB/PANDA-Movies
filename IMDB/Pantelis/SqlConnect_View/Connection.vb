Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Connection
    Private con As New MySqlConnection("Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;Allow User Variables=True")

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
            DReader.Close()
        Catch ex As Exception
            MessageBox.Show("RunQuery Error" & vbCrLf & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Sub RunQuery(ByVal query As String, ByVal args As Array, ByRef results As DataTable)
        Dim cmd As MySqlCommand = New MySqlCommand()
        Dim DReader As MySqlDataReader


        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = query
            'Add Parameters
            For i = 0 To args.Length - 1
                cmd.Parameters.Add(New MySqlParameter(i.ToString, args(i)))
            Next
            DReader = cmd.ExecuteReader
            results.Clear()
            results.Constraints.Clear()
            results.Load(DReader)
            DReader.Close()
        Catch ex As Exception
            MessageBox.Show(vbCrLf & ex.Message & vbCrLf & vbCrLf & ex.ToString, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub


End Class
