Public Class MoviesMain
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.Transparent
        Dim TopArray(10) As PictureBox
        TopArray = {Top0, Top1, Top2, Top3, Top4, Top5, Top6, Top7, Top8, Top9}

        For ind As Integer = 0 To 9
            AddHandler TopArray(ind).Click, AddressOf AllMoviesCLick
        Next

        'Movies in our data base
        Dim h = 10
        'Create Array for every PictureBox
        Dim MoviesArray(h) As PictureBox

        Main.Load_Movies(h, AllMoviesPanel, MoviesArray, 100)
    End Sub


    Private ReadOnly Movie = Main.Container
    Public Sub AllMoviesCLick(sender As Object, ByVal e As EventArgs)
        Dim MovieBox As PictureBox = TryCast(sender, PictureBox)
        If MovieBox IsNot Nothing Then
            Movie.Visible = True
            CurrentMovie.TopLevel = False
            Movie.Controls.Add(CurrentMovie)
            CurrentMovie.Show()
            CurrentMovie.MovieName.Text = MovieBox.AccessibleName
            CurrentMovie.MoPic.BackColor = MovieBox.BackColor
        End If
    End Sub


End Class