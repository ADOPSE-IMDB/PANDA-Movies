﻿Public Class CurrentMovie
    Public mID
    Public flag
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


    Private Sub AddRem_Click(sender As Object, e As EventArgs) Handles AddRem.Click

        If flag Then
            removeFav(mID, LogInForm.u.Id)
            AddRem.Text = "Add to Favorites"
            flag = Not flag
        Else
            addToFav(mID, LogInForm.u.Id)
            AddRem.Text = "Remove from Favorites"
            flag = Not flag
            If Favorite.Visible = True Then
                Favorite.Close()
                Main.FavoriteBtn_Click(e, e)
            End If
        End If

    End Sub

    Private Sub CloseMovie_Click(sender As Object, e As EventArgs) Handles CloseMovie.Click
        Me.Close()
        Main.Container.Visible = False
    End Sub

End Class