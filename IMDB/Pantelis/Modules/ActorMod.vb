Module ActorMod
    Public Function ShowActors(ByVal movie_id)

        Dim args() As String = {movie_id}

        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("SELECT name,surname from Actors AS A 
		              inner join  MovieCasts as MC on MC.id=A.id and MC.movie_id=@0", args, results)
        Dim numberOfActors As New Integer
        numberOfActors = CountMovies()
        Dim allActors(numberOfActors - 1) As Actor  'numberOfActors : number of Actors (-1 size of the Array)
        Try
            For i = 0 To allActors.Length - 1
                allActors(i) = New Actor
                allActors(i).Id = results.Rows(i)("id").ToString
                allActors(i).Name = results.Rows(i)("name").ToString
                allActors(i).Surname = results.Rows(i)("surname").ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, ex.Message & " Show Actors Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Return numberOfActors

    End Function

    Public Function countActors()
        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select count(*) as num from MovieCasts", results)

        Return results.Rows(0)("num").ToString()
    End Function


End Module
