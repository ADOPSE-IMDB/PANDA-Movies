Public Class CurrentMovie
    Public cm
    Public check
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub



    Private Sub CloseMovie_Click(sender As Object, e As EventArgs) Handles CloseMovie.Click
        Me.Close()
        Main.Container.Visible = False
    End Sub

    Private Sub AddRem_Click(sender As Object, e As EventArgs) Handles AddRem.Click

    End Sub
End Class