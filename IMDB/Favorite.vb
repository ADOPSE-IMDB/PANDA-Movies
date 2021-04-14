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

        Dim Favorite(h) As PictureBox
        Main.Load_Movies(h, FavoritePanel, Favorite, 50)

    End Sub


    Private Sub load_table()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Querry As String
            Querry = "SELECT 
    `Movies`.`title`,
    `Movies`.`year`,
    `Movies`.`description`,
    `Movies`.`rating`
FROM `it185223`.`Movies`;
SELECT * FROM it185223.Movies;"
            COMMAND = New MySqlCommand(Querry, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub
    Private Sub ButtonLoadTable_Click(sender As Object, e As EventArgs) Handles ButtonLoadTable.Click


        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Querry As String
            Querry = "SELECT 
    `Movies`.`title`,
    `Movies`.`year`,
    `Movies`.`description`,
    `Movies`.`rating`
FROM `it185223`.`Movies`;
SELECT * FROM it185223.Movies;"

            COMMAND = New MySqlCommand(Querry, MySqlConn)
                SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub


End Class