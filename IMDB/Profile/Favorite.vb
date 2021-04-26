Imports MySql.Data.MySqlClient

Public Class Favorite

    Public Shared FavoriteMovie() As Movie
    Dim tFavorite
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load





        tFavorite = Count(LogInForm.u.Id)
        If tFavorite = 0 Then
            ne.Visible = False
            Pre.Visible = False
            curr.Visible = False
            info.Visible = True
        ElseIf tFavorite < 20 Then
            ne.Visible = False
            Pre.Visible = False
            curr.Visible = False
            Try
                FavoriteMovie = Show_Fav(LogInForm.u.Id, 0, tFavorite - 1)
                LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
            Catch ex As Exception
                MessageBox.Show(ex.ToString, ex.Message & " Fav Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                info.Text = ("Something went Wrong")
                info.Visible = True
            End Try

        ElseIf tFavorite < 40 Then
            ne.Text = "21 - > " & tFavorite
            FavoriteMovie = Show_Fav(LogInForm.u.Id, 0, 19)
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
        Else
            FavoriteMovie = Show_Fav(LogInForm.u.Id, 0, 19)
            LoadPictureBox.Create(FavoritePanel, FavoriteMovie, 50)
        End If
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
End Class