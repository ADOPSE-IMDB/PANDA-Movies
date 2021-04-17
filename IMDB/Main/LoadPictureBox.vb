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

            'Add pictureBoxs on array
            array(index) = MovieBox
            'Adds click even for every label

            AddHandler array(index).Click, AddressOf AllMoviesCLick

            PosX += 245
            If index Mod 5 = 0 Then
                PosY += 275
                PosX = 55
            End If
        Next
    End Sub

    Public Shared Sub AllMoviesCLick(sender As Object, ByVal e As EventArgs)
        Dim MovieBox As PictureBox = TryCast(sender, PictureBox)
        Dim a
        If MovieBox IsNot Nothing Then
            Main.Container.Visible = True
            CurrentMovie.TopLevel = False
            Main.Container.Controls.Add(CurrentMovie)

            Dim cm = MovieBox.TabIndex

            If MoviesMain.TopMoviesPanel.Controls.Contains(MovieBox) Then
                a = MoviesMain.TopTen
            Else
                a = MoviesMain.MovieArray
            End If

            CurrentMovie.MovieName.Text = a(cm).Name
            CurrentMovie.Rate.Text = a(cm).rate
            CurrentMovie.MovieDate.Text = a(cm).reDate
            CurrentMovie.Description.Text = a(cm).Des

            CurrentMovie.Show()

        End If
    End Sub


    End Class
