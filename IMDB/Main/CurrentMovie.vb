Public Class CurrentMovie
    Public mID
    'Check if movie exists in favorite
    Public ARflag
    'Check if User have already rated this movie
    Dim URflag
#Region "Add/Remove to favorite"

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
            CloseMovie_Click(sender, e)
            Main.FavoriteBtn_Click(sender, e)
        End If
    End Sub
    Private Sub AddRem_Enter(sender As Object, e As EventArgs) Handles AddRem.MouseEnter
        AddRemPanel.BackgroundImage = My.Resources.BgBtnStretch2
    End Sub
    Private Sub AddRem_Leave(sender As Object, e As EventArgs) Handles AddRem.MouseLeave
        AddRemPanel.BackgroundImage = My.Resources.BgBtnStretch
    End Sub

#End Region

#Region "Rate Movie"
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
        RatebtnPanel.Visible = True
        Rate.Text = Math.Round(returnRatedMovie(mID), 1) & "/10"
    End Sub



    Private Sub Ratebutton_Click(sender As Object, e As EventArgs) Handles RateBtn.Click
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
        RatebtnPanel.Visible = False
    End Sub

    Private Sub Ratebutton_Enter(sender As Object, e As EventArgs) Handles RateBtn.MouseEnter
        RatebtnPanel.BackgroundImage = My.Resources.GeneralBtn2
    End Sub

    Private Sub Ratebutton_Leavee(sender As Object, e As EventArgs) Handles RateBtn.MouseLeave
        RatebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
    End Sub

#End Region

#Region "close CurrentMovie"

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

#End Region

End Class