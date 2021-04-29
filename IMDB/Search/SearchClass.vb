Public Class SearchClass
    Public Shared Sub Create(panel As Panel, array() As Movie)
        Dim PosY = 0
        Dim s As String
        panel.Height = array.Length * 32
        For index As Integer = 0 To array.Length - 1
            If array(index).Title.Length > 33 Then
                s = array(index).Title.Substring(0, 33) & "..."
            Else
                s = array(index).Title
            End If
            Dim label As New LinkLabel With {
                    .BackColor = Color.Transparent,
                    .Size = New Size(200, 30),
                    .Text = s,
                    .TabIndex = index,
                    .Location = New Point(0, PosY),
                    .Cursor = Cursors.Hand
            }

            AddHandler label.Click, AddressOf clickRuslt

            panel.Controls.Add(label)
            PosY += 32
        Next
    End Sub

    Public Shared Sub clickRuslt(sender As Object, e As EventArgs)
        Main.SearchBox.Text = ""

        Dim lb As LinkLabel = TryCast(sender, LinkLabel)
        If lb IsNot Nothing Then

            Dim c = lb.TabIndex
            Dim a = Main.resultMovies
            Main.Container.Visible = True
            CurrentMovie.TopLevel = False
            Main.Container.Controls.Add(CurrentMovie)


            If checkIfFavExists(a(c).Id, LogInForm.u.Id) Then
                CurrentMovie.AddRem.Text = "Remove from Favorites"
                CurrentMovie.flag = True
            Else
                CurrentMovie.AddRem.Text = "Add to Favorites"
                CurrentMovie.flag = False
            End If

            Dim actor() As Actor
            actor = ShowActors(a(c).Id)
            For Each act In actor
                CurrentMovie.actors.Text += act.Name & " " & act.Surname & vbCrLf
            Next


            CurrentMovie.mID = a(c).Id
            CurrentMovie.MovieName.Text = a(c).Title
            CurrentMovie.Rate.Text = a(c).Rating & "/10"
            CurrentMovie.MovieDate.Text = a(c).Year
            CurrentMovie.Description.Text = a(c).Description
            CurrentMovie.MoPic.ImageLocation = a(c).Url

            CurrentMovie.Show()


        End If
    End Sub
End Class
