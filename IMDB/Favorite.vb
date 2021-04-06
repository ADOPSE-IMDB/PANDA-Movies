Public Class Favorite
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        'Movies in our data base
        Dim h = 10
        'Create Array for every PictureBox

        Dim Favorite(h) As PictureBox
        Main.Load_Movies(h, FavoritePanel, Favorite, 50)

    End Sub
End Class