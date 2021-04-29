Public Class MoviesMain

    'top movie Array
    Private Topten(9) As Movie
    'Main page Movies
    Private MovieArray(19) As Movie
    Private ReadOnly tainies = CountMovies()
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

        'get top ten movies

        TopTen = GetTopMovies()
        MoviesLoad(TopMoviesPanel, Topten, 70)


        If tainies < 40 Then
            ne.Text = "21 - > " & tainies
            MovieArray = GetMoviesFromTo(1, 20)
        ElseIf tainies < 20 Then
            ne.Visible = False
            Pre.Visible = False
            curr.Text = "1 - > " & tainies
            MovieArray = GetMoviesFromTo(1, tainies)
        Else
            MovieArray = GetMoviesFromTo(1, 20)
        End If

        'Fill main movies
        MoviesLoad(AllMoviesPanel, MovieArray, 70)
        ne.Visible = True

    End Sub


    Dim n = 20


    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        n -= 20

        If Not ne.Enabled Then
            ne.Enabled = True
        End If

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

        MovieArray = GetMoviesFromTo(n - 19, n)

        MoviesLoad(AllMoviesPanel, MovieArray, 60)
        AutoScrollPosition = New Point(0, 683)
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        n += 20
        AutoScrollPosition = New Point(0, 683)



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
            ne.Enabled = False

            MovieArray = GetMoviesFromTo(n - 19, tainies)
        ElseIf n > tainies - 20 Then
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & tainies

            MovieArray = GetMoviesFromTo(n - 19, n)
        Else
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & n + 20

            MovieArray = GetMoviesFromTo(n - 19, n)
        End If

        MoviesLoad(AllMoviesPanel, MovieArray, 60)

    End Sub

    Private Sub curr_Click(sender As Object, e As EventArgs) Handles curr.Click

    End Sub
End Class