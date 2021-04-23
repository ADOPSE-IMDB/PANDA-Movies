Imports MySql.Data.MySqlClient

Public Class Favorite
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim tFavorite = 10
    Public Shared FavoriteMovie() As Movie


    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load


        If tFavorite < 20 Then
            ne.Visible = False
            Pre.Visible = False
            curr.Visible = False
            FavoriteMovie = GetMoviesFromTo(1, tFavorite)
            Dim cMovie(tFavorite - 1) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
        ElseIf tFavorite < 40 Then
            ne.Text = "21 - > " & tFavorite
            FavoriteMovie = GetMoviesFromTo(1, 20)
            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
        Else
            FavoriteMovie = GetMoviesFromTo(1, 20)
            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
        End If



        load_table()

    End Sub


    Dim n = 20

    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click


        n -= 20
        If Not ne.Enabled Then
            ne.Enabled = True
        End If

        For Each pb In FavoritePanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next

        FavoriteMovie = GetMoviesFromTo(n - 19, n)

        If n = 20 Then
            ne.Text = curr.Text
            curr.Text = Pre.Text
            Pre.Text = "Start"
            Pre.Enabled = False
        Else
            ne.Text = curr.Text
            curr.Text = Pre.Text
            Pre.Text = n - 39 & " -> " & n - 20

        End If


        Dim cMovie(19) As PictureBox
        LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 100)


        AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        AutoScrollPosition = New Point(0, 0)
        n += 20
        If Not Pre.Enabled Then
            Pre.Enabled = True
        End If

        For Each pb In FavoritePanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next



        If n > tFavorite Then
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = "End"

            FavoriteMovie = GetMoviesFromTo(n - 19, tFavorite)

            Dim t = tFavorite Mod 20
            Dim cMovie(t - 1) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 100)
            ne.Enabled = False

        ElseIf n > tFavorite - 20 Then

            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & tFavorite

            FavoriteMovie = GetMoviesFromTo(n - 19, n)


            Dim t = tFavorite Mod 20
            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 100)
        Else
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & n + 20

            FavoriteMovie = GetMoviesFromTo(n - 19, n)

            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 100)

        End If

    End Sub
    Private Sub ButtonLoadTable_Click(sender As Object, e As EventArgs)


        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MySqlConn.Open()
            Dim Querry As String
            Querry = "select user_id,movie_id,title,year,description,rating from MovieLists inner join Movies on MovieLists.movie_id=Movies.id
"

            COMMAND = New MySqlCommand(Querry, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet

            SDA.Update(dbDataSet)
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub load_table()
        Dim con As New Connection
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("   select distinct user_id,movie_id,title,year,description,rating from MovieLists inner join Movies on MovieLists.movie_id=Movies.id and MovieLists.user_id = @idd", con.getConnection())

        command.Parameters.Add("@idd", MySqlDbType.VarChar).Value = 1
        con.Connect()

        Try
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    MessageBox.Show(reader.GetString(2), "Happ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End While

                con.Disconnect()
            End Using
        Catch
            con.Disconnect()

        End Try


    End Sub

End Class