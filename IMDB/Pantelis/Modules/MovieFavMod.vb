Module MovieFavMod

    'Show the Movies that added to Favorites
    Public Function Show_Fav(ByVal user_id)
        Dim args() As String = {user_id}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("SELECT  distinct user_id,movie_id,title,year,description,rating,Mo.image_url from MovieFavorites AS M
                      
                      inner join Movies as Mo on Mo.id=M.movie_id
                      inner join Users as U on M.user_id=@0", args, results)

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

    'Count the rows of the Favorites Movies of the Logged User
    Public Function Count(ByVal user_id)
        Dim args() As String = {user_id}

        Dim con As New Connection
        Dim results As New DataTable

        'con.RunQuery("select distinct user_id,movie_id,title,year,description,rating,image_url from MovieFavorites 
        'inner join Movies on MovieFavorites.movie_id=Movies.id and MovieFavorites.user_id =@0", args, results) kept as back up

        'numbering the rows also
        con.RunQuery("SET @row_number = 0;   
SELECT   @row_number:=@row_number+1 AS row_number,user_id,movie_id,title,year,description,rating,Mo.image_url from MovieFavorites AS M
                      
                      inner join Movies as Mo on Mo.id=M.movie_id
                      inner join Users as U on M.user_id=@0
                      group by movie_id
                      having 
                      count(movie_id) >1 and row_number between @1 and @2", args, results)
        Dim FavoriteCountMovies As Integer   'number of Favorite Movies 

        FavoriteCountMovies = results.Rows.Count


        Return FavoriteCountMovies

    End Function
    'Add movie to Favorites
    Public Sub addToFav(ByVal id_movie, id_user)
        Dim args() As String = {id_movie, id_user}
        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("INSERT INTO `it185223`.`MovieFavorites` (`movie_id`, `user_id`) VALUES (@0, @1);", args, results)
    End Sub

    Public Sub removeFav(ByVal id_movie, id_user)
        Dim args() As String = {id_movie, id_user}
        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("delete from MovieFavorites where movie_id=@0 and user_id=@1", args, results)
    End Sub

    'check if the movie is already to Favorites
    Public Function checkIfFavExists(ByVal id_movie, id_user)
        Dim args() As String = {id_movie, id_user}
        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("select * from MovieFavorites where movie_id=@0 and user_id=@1", args, results)
        If (results.Rows.Count.Equals(0)) Then
            con.RunQuery("INSERT INTO `it185223`.`MovieFavorites` (`movie_id`, `user_id`) VALUES (@0, @1);", args, results)
            Return False
        Else
            Return True
        End If
    End Function

End Module
