Public Class SearchForm
    Public Shared resultMovies() As Movie
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

        resultMovies = MvcLuceneSampleApp.Search.LuceneSearch.SearchMovieResults(Main.SearchBox.Text)

        If resultMovies.Length = 0 Then
            SLabel.Text = "Sorry we found " & resultMovies.Length & " for : " & Main.SearchBox.Text
        Else
            SLabel.Text = "We found " & resultMovies.Length & " for : " & Main.SearchBox.Text
            MoviesLoad(result, resultMovies, 50)
        End If

    End Sub
End Class