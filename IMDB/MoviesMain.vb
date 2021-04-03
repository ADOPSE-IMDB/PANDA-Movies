Public Class MoviesMain
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Movies in our data base
        Dim h = 10
        'Create Array for every PictureBox
        Dim MoviesArray(h) As PictureBox

        'Check height of the Movies Panel
        If h Mod 5 = 0 Then
            AllMoviesPanel.Height = (h / 5) * 275 + 100
        Else
            AllMoviesPanel.Height = (h \ 5) * 275 + 375
        End If

        'Places Labels for each movie
        Dim PosX = 55
        Dim PosY = 100
            For index As Integer = 1 To h
            Dim MovieBox As New PictureBox With {
                .Size = New Size(190, 250),
                .Location = New Point(PosX, PosY),
                .BackColor = Color.Red,
                .Text = index,
                .Cursor = Cursors.Hand
            }
            AllMoviesPanel.Controls.Add(MovieBox)

            'Add Labels on array
            MoviesArray(index) = MovieBox
            'Adds click even for every label
            AddHandler MoviesArray(index).Click, AddressOf LabelClick


            PosX += 245
            If index Mod 5 = 0 Then
                PosY += 275
                PosX = 55
            End If
        Next

    End Sub

    Private ReadOnly Movie = Main.Panel1
    Private Sub LabelClick(sender As Object, ByVal e As EventArgs)
        Dim MovieBox As PictureBox = TryCast(sender, PictureBox)
        If MovieBox IsNot Nothing Then

            Movie.Visible = True

        End If
    End Sub
End Class