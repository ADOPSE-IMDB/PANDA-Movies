Public Class ResultForm



    Public Sub Search_Movie(resultMovies() As Movie)
        If resultMovies.Length = 0 Then
            SLabel.Text = "Sorry we found " & resultMovies.Length & " for : " & Main.SearchBox.Text
        Else
            SLabel.Text = "We found " & resultMovies.Length & " for : " & Main.SearchBox.Text
            MoviesLoad(result, resultMovies, 50)
        End If
        Main.SearchBox.Text = ""
    End Sub


    Public Sub Search_common(resultMovies() As Movie, name As String)
        If resultMovies.Length = 0 Then
            SLabel.Text = "We did not find any common movies with : " & name
        Else
            MoviesLoad(result, resultMovies, 50)
            SLabel.Text = "We found those movies in common with : " & name
        End If
    End Sub
End Class