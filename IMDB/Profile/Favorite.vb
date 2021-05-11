Imports MySql.Data.MySqlClient

Public Class Favorite

    Public Shared FavoriteMovies() As Movie
    Dim tFavorite
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

        tFavorite = Count(LogInForm.u.Id)

        If tFavorite = 0 Then
            ne.Parent.Visible = False
            Pre.Parent.Visible = False
            curr.Visible = False
            info.Visible = True
        ElseIf tFavorite <= 20 Then

            ne.Parent.Visible = False
            Pre.Parent.Visible = False
            curr.Visible = False

            FavoriteMovies = Show_Fav(LogInForm.u.Id, 0, tFavorite - 1)
            MoviesLoad(FavoritePanel, FavoriteMovies, 50)


        ElseIf tFavorite < 40 Then
            ne.Text = "21 - > " & tFavorite
            FavoriteMovies = Show_Fav(LogInForm.u.Id, 0, 19)
            MoviesLoad(FavoritePanel, FavoriteMovies, 50)
        Else
            FavoriteMovies = Show_Fav(LogInForm.u.Id, 0, 19)
            MoviesLoad(FavoritePanel, FavoriteMovies, 50)
        End If
    End Sub



    Dim n = 20


    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        If Pre.Parent.BackColor = Color.Transparent Then

            n -= 20
            If ne.Parent.BackColor = Color.Black Then
                ne.Parent.BackColor = Color.Transparent
                ne.Parent.BackgroundImage = My.Resources.GeneralBtn1
                ne.Cursor = Cursors.Hand
            End If

            For Each pb In FavoritePanel.Controls.OfType(Of PictureBox)().ToArray()
                pb.Dispose()
            Next


            If n = 20 Then
                ne.Text = curr.Text
                curr.Text = Pre.Text
                Pre.Text = "Start"

                'Disable the button
                Pre.Parent.BackgroundImage = My.Resources.Indicator
                Pre.Parent.BackColor = Color.Black
                Pre.Cursor = Cursors.Default

            Else
                ne.Text = curr.Text
                curr.Text = Pre.Text
                Pre.Text = n - 39 & " -> " & n - 20
            End If

            FavoriteMovies = GetMoviesFromTo(n - 19, n)

            MoviesLoad(FavoritePanel, FavoriteMovies, 60)
            AutoScrollPosition = New Point(0, 683)
        End If
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        If ne.Parent.BackColor = Color.Transparent Then
            n += 20

            If Pre.Parent.BackColor = Color.Black Then
                Pre.Parent.BackColor = Color.Transparent
                Pre.Parent.BackgroundImage = My.Resources.GeneralBtn1
                Pre.Cursor = Cursors.Hand
            End If


            For Each pb In FavoritePanel.Controls.OfType(Of PictureBox)().ToArray()
                pb.Dispose()
            Next



            If n > tFavorite Then
                Pre.Text = curr.Text
                curr.Text = ne.Text
                ne.Text = "End"

                'Disable the button
                ne.Parent.BackgroundImage = My.Resources.Indicator
                ne.Parent.BackColor = Color.Black
                ne.Cursor = Cursors.Default


                FavoriteMovies = GetMoviesFromTo(n - 19, tFavorite)
            ElseIf n > tFavorite - 20 Then
                Pre.Text = curr.Text
                curr.Text = ne.Text
                ne.Text = n + 1 & " -> " & tFavorite
                FavoriteMovies = GetMoviesFromTo(n - 19, n)
            Else
                Pre.Text = curr.Text
                curr.Text = ne.Text
                ne.Text = n + 1 & " -> " & n + 20
                FavoriteMovies = GetMoviesFromTo(n - 19, n)
            End If

            MoviesLoad(FavoritePanel, FavoriteMovies, 60)
            AutoScrollPosition = New Point(0, 683)

        End If
    End Sub

    Private Sub Ne_Enter(sender As Object, e As EventArgs) Handles ne.MouseEnter, Pre.MouseEnter
        If sender.parent.backcolor = Color.Transparent Then
            btnEnter(sender.Parent)
        End If
    End Sub

    Private Sub Mouse_Leave(sender As Object, e As EventArgs) Handles ne.MouseLeave, Pre.MouseLeave
        If sender.parent.backcolor = Color.Transparent Then
            btnLeave(sender.Parent)
        End If
    End Sub
End Class