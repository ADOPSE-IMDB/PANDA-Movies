Module RatingMovies
    Public Sub RateMovie(ByVal movieID, ByVal userID, ByVal rating)


        Dim con As New Connection
        Dim args() As String = {movieID, userID, rating}
        Dim results As New DataTable
        con.RunQuery("Insert into UserRating(movie_id,user_id,rating) values (@0,@1,@2)", args, results)


    End Sub

    Public Function CheckIfRated(ByVal movieID, ByVal userID)
        Dim con As New Connection
        Dim args() As String = {movieID, userID}
        Dim results As New DataTable
        con.RunQuery("Select * from UserRating where movie_id=@0 and user_id=@1", args, results)
        If (results.Rows.Count.Equals(0)) Then
            Return -1
        Else

            Return results.Rows(0)("rating").ToString

        End If
    End Function

    Public Sub UpdateRatedMovie(ByVal movieID, ByVal userID, ByVal rating)


        Dim con As New Connection
        Dim args() As String = {movieID, userID, rating}
        Dim results As New DataTable
        con.RunQuery("Update UserRating SET rating =@2 where user_id=@1 and movie_id=@0 ", args, results)


    End Sub

    Public Function returnRatedMovie(ByVal movie_id)
        Dim con As New Connection
        Dim args() As String = {movie_id}
        Dim results As New DataTable
        con.RunQuery("Select rating from Movies where Id=@0", args, results)
        Return results.Rows(0)("rating")

    End Function




End Module
