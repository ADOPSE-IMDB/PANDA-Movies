Public Class CurrentMovie
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub CloseMovie_Click(sender As Object, e As EventArgs) Handles CloseMovie.Click
        Me.Close()
        Main.Container.Visible = False
    End Sub

    Private Sub AddRem_Click(sender As Object, e As EventArgs) Handles AddRem.Click
        If MoviesMain.MovieArray(MoviesMain.SelectedMovie).isFavorite Then
            MoviesMain.MovieArray(MoviesMain.SelectedMovie).isFavorite = False
            AddRem.Text = "Add to Favorite"
        Else
            MoviesMain.MovieArray(MoviesMain.SelectedMovie).isFavorite = True
            AddRem.Text = "Remove from Favorite"
        End If
    End Sub
End Class