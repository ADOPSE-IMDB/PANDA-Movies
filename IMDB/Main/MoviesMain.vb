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
            Ne.Text = "21 - > " & tainies
            MovieArray = GetMoviesFromTo(1, 20)
        ElseIf tainies < 20 Then
            Ne.Parent.Visible = False
            Pre.Parent.Visible = False
            curr.Text = "1 - > " & tainies
            MovieArray = GetMoviesFromTo(1, tainies)
        Else
            MovieArray = GetMoviesFromTo(1, 20)
        End If

        'Fill main movies
        MoviesLoad(AllMoviesPanel, MovieArray, 70)
    End Sub


    Dim n = 20


    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        If Pre.Parent.BackColor = Color.Transparent Then

            n -= 20
            If Ne.Parent.BackColor = Color.Black Then
                Ne.Parent.BackColor = Color.Transparent
                Ne.Parent.BackgroundImage = My.Resources.GeneralBtn1
                Ne.Cursor = Cursors.Hand
            End If

            For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
                pb.Dispose()
            Next


            If n = 20 Then
                Ne.Text = curr.Text
                curr.Text = Pre.Text
                Pre.Text = "Start"

                'Disable the button
                Pre.Parent.BackgroundImage = My.Resources.Indicator
                Pre.Parent.BackColor = Color.Black
                Pre.Cursor = Cursors.Default

            Else
                Ne.Text = curr.Text
                curr.Text = Pre.Text
                Pre.Text = n - 39 & " -> " & n - 20
            End If

            MovieArray = GetMoviesFromTo(n - 19, n)

            MoviesLoad(AllMoviesPanel, MovieArray, 60)
            AutoScrollPosition = New Point(0, 683)
        End If
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles Ne.Click
        If Ne.Parent.BackColor = Color.Transparent Then
            n += 20

            If Pre.Parent.BackColor = Color.Black Then
                Pre.Parent.BackColor = Color.Transparent
                Pre.Parent.BackgroundImage = My.Resources.GeneralBtn1
                Pre.Cursor = Cursors.Hand
            End If


            For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
                pb.Dispose()
            Next



            If n > tainies Then
                Pre.Text = curr.Text
                curr.Text = Ne.Text
                Ne.Text = "End"

                'Disable the button
                Ne.Parent.BackgroundImage = My.Resources.Indicator
                Ne.Parent.BackColor = Color.Black
                Ne.Cursor = Cursors.Default


                MovieArray = GetMoviesFromTo(n - 19, tainies)
            ElseIf n > tainies - 20 Then
                Pre.Text = curr.Text
                curr.Text = Ne.Text
                Ne.Text = n + 1 & " -> " & tainies
                MovieArray = GetMoviesFromTo(n - 19, n)
            Else
                Pre.Text = curr.Text
                curr.Text = Ne.Text
                Ne.Text = n + 1 & " -> " & n + 20
                MovieArray = GetMoviesFromTo(n - 19, n)
            End If

            MoviesLoad(AllMoviesPanel, MovieArray, 60)
            AutoScrollPosition = New Point(0, 683)

        End If
    End Sub

    Private Sub Ne_Enter(sender As Object, e As EventArgs) Handles Ne.MouseEnter, Pre.MouseEnter
        If sender.parent.backcolor = Color.Transparent Then
            btnEnter(sender.Parent)
        End If
    End Sub

    Private Sub Mouse_Leave(sender As Object, e As EventArgs) Handles Ne.MouseLeave, Pre.MouseLeave
        If sender.parent.backcolor = Color.Transparent Then
            btnLeave(sender.Parent)
        End If
    End Sub
End Class