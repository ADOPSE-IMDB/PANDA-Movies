Module ActorMod
    Public Function ShowActors(ByVal movie_id)

        Dim args() As String = {movie_id}

        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("SELECT name from Actors AS A 
		              inner join  MovieCasts as MC on MC.id=A.id and MC.movie_id=@0", args, results)

        Dim numberOfActors As New Integer

        numberOfActors = countActors(movie_id)

        Dim allActors(numberOfActors - 1) As Actor  'numberOfActors : number of Actors (-1 size of the Array)
        Try
            For i = 0 To allActors.Length - 1
                allActors(i) = New Actor With {
                    .Name = results.Rows(i)("name").ToString
                }
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, ex.Message & " Show Actors Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Return allActors

    End Function

    Public Function countActors(ByVal movie_id)

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select count(*) as num from MovieCasts where movie_id = " & movie_id, results)
        Return results.Rows(0)("num").ToString()
    End Function


End Module
