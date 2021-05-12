Public Class ResultForm
    Public Shared resultMovies() As Movie
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Main.SearchBox.Text = "" Then
            If resultMovies.Length = 0 Then
                SLabel.Text = "Sorry we found " & resultMovies.Length & " for : " & Main.SearchBox.Text
            Else
                SLabel.Text = "We found " & resultMovies.Length & " for : " & Main.SearchBox.Text
                MoviesLoad(result, resultMovies, 50)
            End If
            Main.SearchBox.Text = ""
        Else
            If resultMovies.Length = 0 Then
                SLabel.Text = "We did not fina any common movies with : " & Main.SearchUsername.Text
            Else
                MoviesLoad(result, resultMovies, 50)
                SLabel.Text = "We found those movies in common with : " & Main.SearchUsername.Text
            End If
            Main.SearchUsername.Text = ""
        End If
    End Sub
End Class