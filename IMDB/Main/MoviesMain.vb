Public Class MoviesMain
    'top movie Array
    Public Shared TopTen(9) As Movie

    'Main page Movies
    Public Shared MovieArray(19) As Movie

    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
#Region "url"
        'https://i.ibb.co/8B9qK6L/inception.jpg
        'https://i.ibb.co/R0RTKdk/Parasite.jpg
        'https://i.ibb.co/wBy2fbL/Interstellar.jpg
        'https://i.ibb.co/sFJGP4J/Joker.jpg
        'https://i.ibb.co/8g2FP1L/A-Beautiful-Mind.jpg
#End Region
        If tainies < 40 Then
            ne.Text = "21 - > " & tainies
        End If


        'Fill main movies
        MovieArray = GetMoviesFromTo(1, 20)
        LoadPictureBox.Create(AllMoviesPanel, MovieArray, 100)


        'get top ten movies
        TopTen = GetTopMovies()
        'Top Ten Movie Array with picturebox
        Dim TopArray(9) As PictureBox
        TopArray = {Top1, Top2, Top3, Top4, Top5, Top6, Top7, Top8, Top9, Top10}
        For index As Integer = 0 To TopTen.Length - 1

            TopArray(index).TabIndex = index
            TopArray(index).Image = My.Resources._200
            If TopArray(index).ImageLocation = TopTen(index).Url Then
                TopArray(index).Image = TopArray(index).ErrorImage
            Else
                TopArray(index).ImageLocation = TopTen(index).Url
            End If

            AddHandler TopArray(index).Click, AddressOf LoadPictureBox.AllMoviesCLick
        Next

    End Sub


    Dim n = 20
    Private ReadOnly tainies = CountMovies()

    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click


        n -= 20
        If Not ne.Enabled Then
            ne.Enabled = True
        End If

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next

        MovieArray = GetMoviesFromTo(n - 19, n)

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
        LoadPictureBox.Create(AllMoviesPanel, MovieArray, 100)


        AutoScrollPosition = New Point(0, 625)
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        AutoScrollPosition = New Point(0, 625)
        n += 20
        If Not Pre.Enabled Then
            Pre.Enabled = True
        End If

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next



        If n > tainies Then
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = "End"

            MovieArray = GetMoviesFromTo(n - 19, tainies)

            Dim t = tainies Mod 20
            Dim cMovie(t - 1) As PictureBox
            LoadPictureBox.Create(AllMoviesPanel, MovieArray, 100)
            ne.Enabled = False

        ElseIf n > tainies - 20 Then

            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & tainies

            MovieArray = GetMoviesFromTo(n - 19, n)


            Dim t = tainies Mod 20
            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(AllMoviesPanel, MovieArray, 100)
        Else
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & n + 20

            MovieArray = GetMoviesFromTo(n - 19, n)

            Dim cMovie(19) As PictureBox
            LoadPictureBox.Create(AllMoviesPanel, MovieArray, 100)

        End If

    End Sub

End Class