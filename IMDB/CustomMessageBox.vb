Public Class CustomMessageBox
    Private Sub On_load() Handles Me.Load
        Main.Enabled = False
        My.Computer.Audio.PlaySystemSound(
        System.Media.SystemSounds.Asterisk)
    End Sub

    Private Sub CloseMessageBox_Click(sender As Object, e As EventArgs) Handles CloseMessageBox.Click
        Main.Enabled = True
        Close()
    End Sub

    Private Sub Exitbutton_click() Handles ExitAppBtn.Click
        Application.Exit()
    End Sub


    Private Sub LogOut_click() Handles LogOut.Click
        My.Settings.Check = False
        My.Settings.username = ""
        My.Settings.password = ""
        LogInForm.Show()
        Main.Close_forms(LogInForm)
    End Sub

#Region "Visual"


    Private Sub CloseMessageBox_Enter(sender As Object, e As EventArgs) Handles CloseMessageBox.MouseEnter
        CloseMessageBox.Image = My.Resources.Close2
    End Sub
    Private Sub CloseMessageBox_Leave(sender As Object, e As EventArgs) Handles CloseMessageBox.MouseLeave
        CloseMessageBox.Image = My.Resources.Close1
    End Sub

    Private Sub Btn_Enter(sender As Object, e As EventArgs) Handles ExitAppBtn.MouseEnter, LogOut.MouseEnter
        btnEnter(sender.parent)
    End Sub

    Private Sub Btn_Leave(sender As Object, e As EventArgs) Handles ExitAppBtn.MouseLeave, LogOut.MouseLeave
        btnLeave(sender.parent)
    End Sub
#End Region

#Region " Move Form "
    Private Sub F_mouseDown(sender As Object, e As EventArgs) Handles MovePanel.MouseDown
        MoveForm_MouseDown(sender, e)
    End Sub

    Private Sub F_mouseMove(sender As Object, e As EventArgs) Handles MovePanel.MouseMove
        MoveForm_MouseMove(sender, e, Me)
    End Sub

    Private Sub F_mouseUp(sender As Object, e As EventArgs) Handles MovePanel.MouseUp
        MoveForm_MouseUp(sender, e)
    End Sub
#End Region
End Class