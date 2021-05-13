
Module LoadPictureBox

    Public Sub MoviesLoad(panel As Panel, array() As Movie, PosY As Integer)

        'Check height of the Movies Panel
        If array.Length Mod 5 = 0 Then
            panel.Height = (array.Length / 5 * 293) + 100
        Else
            panel.Height = (((array.Length \ 5) + 1) * 293) + 100
        End If

        'Places Labels for each movie
        Dim PosX = 50

        For index As Integer = 0 To array.Length - 1
            Dim MovieBox As New PictureBox With {
                    .SizeMode = PictureBoxSizeMode.CenterImage,
                    .BackColor = Color.Transparent,
                    .Size = New Size(182, 268),
                    .Location = New Point(PosX, PosY),
                    .Cursor = Cursors.Hand,
                    .Image = My.Resources._200,
                    .ImageLocation = array(index).Url,
                    .BorderStyle = BorderStyle.Fixed3D
            }

            panel.Controls.Add(MovieBox)


            'Adds click even for every label
            Dim mv As Movie = array(index)
            AddHandler MovieBox.Click, Sub() AllMoviesCLick(mv)

            PosX += 245
            If (index + 1) Mod 5 = 0 Then
                PosY += 293
                PosX = 50
            End If
        Next
    End Sub


    Public Sub AllMoviesCLick(movie As Movie)
        Main.SearchBox.Text = ""
        Main.MovieContainer.Visible = True
        CurrentMovie.TopLevel = False
        Main.MovieContainer.Controls.Add(CurrentMovie)
        CurrentMovie.Show()

        CurrentMovie.mID = movie.Id
        CurrentMovie.MovieName.Text = movie.Title
        CurrentMovie.Rate.Text = Math.Round(movie.Rating, 1) & "/10"
        CurrentMovie.MovieDate.Text = movie.Year
        CurrentMovie.Description.Text = movie.Description
        CurrentMovie.MoPic.ImageLocation = movie.Url


        If checkIfFavExists(movie.Id, LogInForm.u.Id) Then
            CurrentMovie.AddRem.Text = "Remove from Favorites"
            CurrentMovie.ARflag = True
        Else
            CurrentMovie.AddRem.Text = "Add to Favorites"
            CurrentMovie.ARflag = False
        End If
        CurrentMovie.actors.Text = ShowActors(movie.Id)
        CurrentMovie.MovieGenre.Text = showGenres(movie.Id)
    End Sub

End Module
