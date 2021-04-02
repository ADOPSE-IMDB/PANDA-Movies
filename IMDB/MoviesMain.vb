Public Class MoviesMain
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Movies in our data base
        Dim h = 11
        Dim MoviesArray(h) As Label

        If h Mod 5 = 0 Then
            AllMoviesPanel.Height = (h / 5) * 275 + 100
        Else
            AllMoviesPanel.Height = (h \ 5) * 275 + 375
        End If


        Dim PosX = 55
        Dim PosY = 100
            For index As Integer = 1 To h
            Dim lbl As New Label With {
                .Size = New System.Drawing.Size(190, 250),
                .Location = New System.Drawing.Point(PosX, PosY),
                .BackColor = Color.Red,
                .Text = index,
                .Cursor = Cursors.Hand
            }

            MoviesArray(index) = lbl
            AddHandler MoviesArray(index).Click, AddressOf LabelClick

            PosX += 245
                AllMoviesPanel.Controls.Add(lbl)
            If index Mod 5 = 0 Then
                PosY += 275
                PosX = 55
            End If
        Next

    End Sub

    Private Sub LabelClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim lbl As Label = TryCast(sender, Label)
        If lbl IsNot Nothing Then
            MessageBox.Show(lbl.Text + " Test On click Event")
        End If
    End Sub
End Class