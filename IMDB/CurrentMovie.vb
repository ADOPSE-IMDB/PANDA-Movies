Public Class CurrentMovie
    Private Sub CloseMovie_Click(sender As Object, e As EventArgs) Handles CloseMovie.Click
        Me.Close()
        Main.Panel1.Visible = False
    End Sub
End Class