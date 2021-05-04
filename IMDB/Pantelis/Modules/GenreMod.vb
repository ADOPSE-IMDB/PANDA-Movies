Module GenreMod
    Public Function showGenres(ByVal movieID)
        Dim args() As String = {movieID}

        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("select genre from Genres as G
	                  inner join MovieGenres as MG on G.id=MG.genre_id where MG.movie_id=@0", args, results)

        Dim t = ""
        Try
            For Each r In results.Rows
                t += r("genre").ToString() & " "
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, ex.Message & " Show Genres Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return t

        'Dim numberOfGenres As New Integer

        'numberOfGenres = countGenres(movieID)

        'Dim allGenres(numberOfGenres - 1) As Genre  'numberOfActors : number of Actors (-1 size of the Array)
        'Try

        'For i = 0 To allGenres.Length - 1
        'allGenres(i) = New Genre With {
        '           .Name = results.Rows(i)("genre").ToString
        '      }
        'Next
        'Catch ex As Exception
        'MessageBox.Show(ex.ToString, ex.Message & " Show Genres Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


        'Return allGenres

    End Function

    Public Function countGenres(ByVal movieID)

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select count(*) as num from MovieGenres where movie_id = " & movieID, results)
        Return results.Rows(0)("num").ToString()
    End Function

End Module
