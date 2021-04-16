Imports MySql.Data.MySqlClient

Public Class MoviesMain
    Inherits Form
    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)
        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()
    End Sub

    Private Sub paintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawFormGradient(Color.Black, Color.White)
    End Sub



    Public SelectedMovie As Integer
    Public Structure MovieArrayStructure
        Dim Index As Integer
        Dim Name As String
        Dim reDate As Date
        Dim rate As Integer
        Dim Des As String
        Dim isFavorite As Boolean
    End Structure

    Public Shared MovieArray(20) As MovieArrayStructure
    Public Shared cMovie(20) As PictureBox

    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

        'loads all movies to custom Array
        Dim c = 1
        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("   Select * from Movies", con.getConnection())
        con.openConnection()
        Try
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    MovieArray(c).Index = reader.GetInt16(0)
                    MovieArray(c).Name = reader.GetString(1)
                    MovieArray(c).reDate = reader.GetDateTime(2)
                    MovieArray(c).Des = reader.GetString(3)
                    MovieArray(c).rate = reader.GetInt16(4)
                    MovieArray(c).isFavorite = False
                    c += 1
                End While
                con.closeConnection()
            End Using
        Catch
            con.closeConnection()
        End Try




        'Create Array for every PictureBox and adds Onclick Event

        Load_Movies(20, AllMoviesPanel, cMovie, 100)


        Dim TopArray(11) As PictureBox
        TopArray = {Nothing, Top1, Top2, Top3, Top4, Top5, Top6, Top7, Top8, Top9, Top10}

        For index As Integer = 1 To 10
            AddHandler TopArray(index).Click, AddressOf AllMoviesCLick
            TopArray(index).TabIndex = MovieArray(index).Index
        Next

        'Movies in our data base

    End Sub




    'Manage CurrentMovie Form to display information for the selected movie
    Private ReadOnly Movie = Main.Container
    Public Sub AllMoviesCLick(sender As Object, ByVal e As EventArgs)
        Dim MovieBox As PictureBox = TryCast(sender, PictureBox)
        If MovieBox IsNot Nothing Then
            Movie.Visible = True
            CurrentMovie.TopLevel = False
            Movie.Controls.Add(CurrentMovie)
            CurrentMovie.Show()

            SelectedMovie = MovieBox.TabIndex

            CurrentMovie.MovieName.Text = MovieArray(SelectedMovie).Name

            CurrentMovie.MovieDate.Text = MovieArray(SelectedMovie).reDate

            CurrentMovie.Rate.Text = MovieArray(SelectedMovie).rate & "/5"

            CurrentMovie.Description.Text = MovieArray(SelectedMovie).Des

            CurrentMovie.MoPic.BackColor = Color.Black


            If MovieArray(SelectedMovie).isFavorite Then
                CurrentMovie.AddRem.Text = "Remove from Favorite"
            Else
                CurrentMovie.AddRem.Text = "Add to Favorite"
            End If

        End If
    End Sub

#Region "Loads all movies"
    Public Shared Sub Load_Movies(h As Integer, panel As Panel, array() As PictureBox, PosY As Integer)

        'Check height of the Movies Panel
        If h Mod 5 = 0 Then
            panel.Height = (h / 5) * 275 + 160
        Else
            panel.Height = (h \ 5) * 275 + 435
        End If

        'Places Labels for each movie
        Dim PosX = 55

        For index As Integer = 1 To h
            Dim MovieBox As New PictureBox With {
                .Size = New Size(190, 250),
                .Location = New Point(PosX, PosY),
                .BackColor = Color.Red,
                .Text = index,
                .Cursor = Cursors.Hand
            }
            panel.Controls.Add(MovieBox)
            MovieBox.TabIndex = index
            'Add Labels on array
            array(index) = MovieBox
            'Adds click even for every label
            AddHandler array(index).Click, AddressOf MoviesMain.AllMoviesCLick

            PosX += 245
            If index Mod 5 = 0 Then
                PosY += 275
                PosX = 55
            End If
        Next
    End Sub
#End Region


    Dim n = 20
    Dim tainies = 89

    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        n -= 20
        Main.SearchBox.Text = n
        ne.Enabled = True

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next

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


        Dim cMovie(20) As PictureBox
        Load_Movies(20, AllMoviesPanel, cMovie, 100)
    End Sub

    Private Sub ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        n += 20
        Main.SearchBox.Text = n
        Pre.Enabled = True

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next


        If n > tainies Then
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = "End"

            Dim t = tainies Mod 20
            Dim cMovie(t) As PictureBox
            Load_Movies(t, AllMoviesPanel, cMovie, 100)
            ne.Enabled = False

        ElseIf n > tainies - 20 Then

            Pre.Text = curr.Text
            curr.Text = ne.Text
            Dim t = tainies Mod 20
            ne.Text = n + 1 & " -> " & tainies

            Dim cMovie(20) As PictureBox
            Load_Movies(20, AllMoviesPanel, cMovie, 100)
        Else
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & n + 20

            Dim cMovie(20) As PictureBox
            Load_Movies(20, AllMoviesPanel, cMovie, 100)



        End If

    End Sub
End Class