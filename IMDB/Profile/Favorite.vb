Imports MySql.Data.MySqlClient

Public Class Favorite
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As New MySqlCommand

    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_table()

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        'Movies in our data base
        Dim h = 10
        'Create Array for every PictureBox


    End Sub


    Private Sub load_table()



    End Sub
    Private Sub ButtonLoadTable_Click(sender As Object, e As EventArgs) Handles ButtonLoadTable.Click



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class