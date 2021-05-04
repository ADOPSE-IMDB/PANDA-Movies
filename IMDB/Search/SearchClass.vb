Module SearchClass
    Public Sub SearchLoad(Panel As Panel, array() As Movie)
        Dim PosY = 0
        Dim s As String
        Panel.Height = array.Length * 20
        For index As Integer = 0 To array.Length - 1
            If array(index).Title.Length > 33 Then
                s = array(index).Title.Substring(0, 33) & "..."
            Else
                s = array(index).Title
            End If
            Dim label As New LinkLabel With {
                    .Size = New Size(200, 20),
                    .Text = s,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .Location = New Point(0, PosY),
                    .Cursor = Cursors.Hand,
                    .BorderStyle = BorderStyle.FixedSingle
            }


            Dim mv As Movie = array(index)
            AddHandler label.Click, Sub() SearchShow(mv)

            Panel.Controls.Add(label)
            PosY += 20
        Next
    End Sub
    Private Sub SearchShow(movie As Movie)
        Main.SearchBox.Text = ""


        CurrentMovie.mID = movie.Id
        CurrentMovie.MovieName.Text = movie.Title
        CurrentMovie.Rate.Text = movie.Rating & "/10"
        CurrentMovie.MovieDate.Text = movie.Year
        CurrentMovie.Description.Text = movie.Description
        CurrentMovie.MoPic.ImageLocation = movie.Url

        Main.Container.Visible = True
        CurrentMovie.TopLevel = False
        Main.Container.Controls.Add(CurrentMovie)
        CurrentMovie.Show()

        If checkIfFavExists(movie.Id, LogInForm.u.Id) Then
            CurrentMovie.AddRem.Text = "Remove from Favorites"
            CurrentMovie.ARflag = True
        Else
            CurrentMovie.AddRem.Text = "Add to Favorites"
            CurrentMovie.ARflag = False
        End If

        Dim actor() As Actor = ShowActors(movie.Id)

        For Each act In actor
            CurrentMovie.actors.Text += act.Name & " " & vbCrLf
        Next
    End Sub
End Module
