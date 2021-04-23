Module MovieFavMod
    Public Function Show_Fav(ByVal user_id)
        Dim args() As String = {user_id}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select distinct user_id,movie_id,title,year,description,rating,image_url from MovieFavorites 
                      inner join Movies on MovieFavorites.movie_id=Movies.id and MovieFavorites.user_id =@0", args, results)

        Dim FavoriteMovies(results.Rows.Count - 1) As Movie    'toNum - fromNum : number of movies (-1 size of the Array)


        For i = 0 To FavoriteMovies.Length - 1
            FavoriteMovies(i) = New Movie
            FavoriteMovies(i).Id = results.Rows(i)("movie_id").ToString
            FavoriteMovies(i).Title = results.Rows(i)("title").ToString
            FavoriteMovies(i).Year = results.Rows(i)("year").ToString
            FavoriteMovies(i).Description = results.Rows(i)("description").ToString
            FavoriteMovies(i).Rating = results.Rows(i)("rating").ToString
            FavoriteMovies(i).Url = results.Rows(i)("image_url").ToString
        Next

        Return FavoriteMovies

    End Function

    Public Function Count(ByVal user_id)
        Dim args() As String = {user_id}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select distinct user_id,movie_id,title,year,description,rating,image_url from MovieFavorites 
                      inner join Movies on MovieFavorites.movie_id=Movies.id and MovieFavorites.user_id =@0", args, results)

        Dim FavoriteCountMovies(results.Rows.Count) As Movie    'toNum - fromNum : number of movies (-1 size of the Array)




        Return FavoriteCountMovies

    End Function

End Module
