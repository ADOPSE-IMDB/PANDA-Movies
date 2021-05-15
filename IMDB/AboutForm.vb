Public Class AboutForm
    Private Sub On_load() Handles Me.Load
        Main.Enabled = False
    End Sub




    Private Sub CloseAboutForm_Click(sender As Object, e As EventArgs) Handles CloseAboutForm.Click
        Main.Enabled = True
        Close()
    End Sub
    Private Sub CloseAboutForm_Enter(sender As Object, e As EventArgs) Handles CloseAboutForm.MouseEnter
        CloseAboutForm.Image = My.Resources.Close2
    End Sub
    Private Sub CloseAboutForm_Leave(sender As Object, e As EventArgs) Handles CloseAboutForm.MouseLeave
        CloseAboutForm.Image = My.Resources.Close1
    End Sub


#Region " Move Form "
    Private Sub F_mouseDown(sender As Object, e As EventArgs) Handles AboutName.MouseDown
        MoveForm_MouseDown(sender, e)
    End Sub

    Private Sub F_mouseMove(sender As Object, e As EventArgs) Handles AboutName.MouseMove
        MoveForm_MouseMove(sender, e, Me)
    End Sub

    Private Sub F_mouseUp(sender As Object, e As EventArgs) Handles AboutName.MouseUp
        MoveForm_MouseUp(sender, e)
    End Sub
#End Region
End Class