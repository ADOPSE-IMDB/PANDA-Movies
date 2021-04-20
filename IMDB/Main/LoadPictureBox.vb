Imports MySql.Data.MySqlClient
Public Class LoadPictureBox
    Structure s
        Public Index As Integer
        Public Name As String
        Public reDate As Date
        Public rate As Integer
        Public Des As String
        Public isFavorite As Boolean
    End Structure





    Public Shared Sub Create(h As Integer, panel As Panel, array() As PictureBox, PosY As Integer)

        'Check height of the Movies Panel
        If h Mod 5 = 0 Then
            panel.Height = (h / 5) * 295 + 160
        Else
            panel.Height = ((h \ 5) + 1) * 295 + 160
        End If

        'Places Labels for each movie
        Dim PosX = 55

        For index As Integer = 1 To h
            Dim MovieBox As New PictureBox With {
                    .BackColor = Color.Transparent,
                    .Size = New Size(190, 270),
                    .Location = New Point(PosX, PosY),
                    .Cursor = Cursors.Hand,
                    .Image = My.Resources._200
                }
            panel.Controls.Add(MovieBox)
            MovieBox.TabIndex = index

            'Add pictureBoxs on array
            array(index) = MovieBox
            'Adds click even for every label

            AddHandler array(index).Click, AddressOf AllMoviesCLick

            PosX += 245
            If index Mod 5 = 0 Then
                PosY += 295
                PosX = 55
            End If
        Next
    End Sub



    Public Shared Sub AllMoviesCLick(sender As Object, ByVal e As EventArgs)
        Dim MovieBox As PictureBox = TryCast(sender, PictureBox)

        If MovieBox IsNot Nothing Then
            Main.Container.Visible = True
            CurrentMovie.TopLevel = False
            Main.Container.Controls.Add(CurrentMovie)

            Dim a
            Dim c = MovieBox.TabIndex
            If MoviesMain.TopMoviesPanel.Controls.Contains(MovieBox) Then

                a = MoviesMain.TopTen
                CurrentMovie.MovieName.Text = a(c).Title
                CurrentMovie.Rate.Text = a(c).Rating & "/5"
                CurrentMovie.MovieDate.Text = a(c).Year
                CurrentMovie.Description.Text = a(c).Description
                CurrentMovie.MoPic.Image = MovieBox.Image

            Else

                a = MoviesMain.MovieArray
                CurrentMovie.MovieName.Text = a(c).Name
                CurrentMovie.Rate.Text = a(c).rate & "/5"
                CurrentMovie.MovieDate.Text = a(c).reDate
                CurrentMovie.Description.Text = a(c).Des

            End If

            CurrentMovie.Show()

        End If
    End Sub


End Class
