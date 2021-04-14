Imports MySql.Data.MySqlClient

Public Class MY_CONNECTION
    Private connection As New MySqlConnection("Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;")

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    Sub openConnection()
        If connection.State = connection.State.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub
End Class
