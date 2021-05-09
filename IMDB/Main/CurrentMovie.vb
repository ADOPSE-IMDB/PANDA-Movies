Public Class CurrentMovie
    Public mID
    'add/remove flag
    Public ARflag
    'uratingFlag
    Dim URflag
    Private Sub AddRem_Click(sender As Object, e As EventArgs) Handles AddRem.Click

        If ARflag Then
            removeFav(mID, LogInForm.u.Id)
            AddRem.Text = "Add to Favorites"
            ARflag = Not ARflag
        Else
            addToFav(mID, LogInForm.u.Id)
            AddRem.Text = "Remove from Favorites"
            ARflag = Not ARflag
        End If

        If Favorite.Visible = True Then
            Favorite.Close()
            Main.FavoriteBtn_Click(sender, e)
        End If
    End Sub


    Private Sub Urating_DragEnter(sender As Object, e As EventArgs) Handles Urating.ValueChanged
        uR.Text = Urating.Value & "/10"
    End Sub

    Private Sub Urating_MouseUp(sender As Object, e As MouseEventArgs) Handles Urating.MouseUp
        If URflag Then
            UpdateRatedMovie(mID, LogInForm.u.Id, Urating.Value)
        Else
            RateMovie(mID, LogInForm.u.Id, Urating.Value)
        End If
        If MoviesMain.Visible = True Then
            MoviesMain.Close()
            MoviesMain.TopLevel = False
            Main.MainPanel.Controls.Add(MoviesMain)
            MoviesMain.Show()
        End If
        Urating.Visible = False
        uR.Visible = False
        rateInfo.Text = "You rated this movie with " & Urating.Value & "/10"
        Ratebutton.Visible = True
        Rate.Text = Math.Round(returnRatedMovie(mID), 1) & "/10"
    End Sub

    Private Sub Ratebutton_Click(sender As Object, e As EventArgs) Handles Ratebutton.Click
        Dim r = CheckIfRated(mID, LogInForm.u.Id)
        If r = -1 Then
            Urating.Value = 0
            rateInfo.Text = "You haven't rated this movie yet"
            uR.Text = "-/10"
            URflag = False
        Else
            Urating.Value = r
            rateInfo.Text = "You have rated this movie with"
            uR.Text = r & "/10"
            URflag = True
        End If
        Urating.Visible = True
        uR.Visible = True
        rateInfo.Visible = True
        Ratebutton.Visible = False
    End Sub

    Private Sub CloseMovie_Click(sender As Object, e As EventArgs) Handles CloseCuMovie.Click
        Me.Close()
        Main.Container.Visible = False
    End Sub

    Private Sub ExitBtn_Hover(sender As Object, e As EventArgs) Handles CloseCuMovie.MouseEnter
        CloseCuMovie.Image = My.Resources.Close2
    End Sub
    Private Sub ExitBtn_Leave(sender As Object, e As EventArgs) Handles CloseCuMovie.MouseLeave
        CloseCuMovie.Image = My.Resources.Close1
    End Sub
End Class