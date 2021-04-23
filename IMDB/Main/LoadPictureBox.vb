Imports MySql.Data.MySqlClient
Public Class LoadPictureBox
    Public Shared Sub Create(panel As Panel, array() As Movie, PosY As Integer)

        'Check height of the Movies Panel
        If array.Length Mod 5 = 0 Then
            panel.Height = (array.Length / 5) * 293 + 160
        Else
            panel.Height = ((array.Length \ 5) + 1) * 293 + 160
        End If

        'Places Labels for each movie
        Dim PosX = 59

        For index As Integer = 0 To array.Length - 1
            Dim MovieBox As New PictureBox With {
                    .BackColor = Color.Transparent,
                    .Size = New Size(182, 268),
                    .Location = New Point(PosX, PosY),
                    .Cursor = Cursors.Hand,
                    .Image = My.Resources._200,
                    .ImageLocation = array(index).Url
                }
            If MovieBox.ImageLocation = array(index).Url Then

            Else
                MovieBox.ImageLocation = array(index).Url
            End If
            panel.Controls.Add(MovieBox)
            MovieBox.TabIndex = index

            'Add pictureBoxs on array
            array(index).P = MovieBox
            'Adds click even for every label

            AddHandler array(index).P.Click, AddressOf AllMoviesCLick

            PosX += 245
            If (index + 1) Mod 5 = 0 Then
                PosY += 293
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
            ElseIf MoviesMain.AllMoviesPanel.Controls.Contains(MovieBox) Then
                a = MoviesMain.MovieArray
            Else
                a = Favorite.FavoriteMovie
            End If

            CurrentMovie.MovieName.Text = a(c).Title
            CurrentMovie.Rate.Text = a(c).Rating & "/10"
            CurrentMovie.MovieDate.Text = a(c).Year
            CurrentMovie.Description.Text = a(c).Description
            CurrentMovie.MoPic.Image = MovieBox.Image
            CurrentMovie.Show()

        End If
    End Sub


End Class
