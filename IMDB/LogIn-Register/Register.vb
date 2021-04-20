Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub Return_Click(sender As Object, e As EventArgs) Handles ReturnB.Click
        LogInLink_Click(sender, e)
    End Sub

    Private Sub CheckTB(TB As TextBox, ErrorText As String)
        If TB.Text.Trim() = "" Then
            Me.XError.SetError(TB, ErrorText)
        Else
            Me.XError.SetError(TB, "")
        End If
    End Sub

    Private Sub LogInLink_Click(sender As Object, e As EventArgs) Handles LogInLink.Click
        LogInForm.Show()
        Close()
    End Sub

    Private Sub FirstNameTB_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxFirstname_Enter(sender As Object, e As EventArgs) Handles TextBoxFirstname.Enter
        LabelFN.ForeColor = Color.Red

    End Sub

    Private Sub TextBoxFirstname_Leave(sender As Object, e As EventArgs) Handles TextBoxFirstname.Leave
        LabelFN.ForeColor = Color.Black
        CheckTB(sender, "Please enter your First Name.")
    End Sub

    Private Sub TextBoxLastname_Enter(sender As Object, e As EventArgs) Handles TextBoxLastname.Enter
        LabelLN.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxLastname_Leave(sender As Object, e As EventArgs) Handles TextBoxLastname.Leave
        LabelLN.ForeColor = Color.Black
        CheckTB(sender, "Please enter your Last Name.")
    End Sub

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter
        LabelUN.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        LabelUN.ForeColor = Color.Black
        CheckTB(sender, "Please enter a Username.")
    End Sub

    Private Sub TextBoxEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxEmail.Enter
        LabelEM.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave
        LabelEM.ForeColor = Color.Black
        CheckTB(sender, "Please enter your Email.")
    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter
        LabelPASS1.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        LabelPASS1.ForeColor = Color.Black
        CheckTB(sender, "Please enter a Password.")
    End Sub

    Private Sub TextBoxConfirmPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Enter
        LabelPASS2.ForeColor = Color.Red
    End Sub

    Private Sub TextBoxConfirmPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Leave
        LabelPASS2.ForeColor = Color.Black
        If TextBoxPassword.Text.Trim() <> "" Then
            CheckTB(sender, "Please confirm your Password.")
        ElseIf TextBoxPassword.Text.Trim() <> TextBoxConfirmPassword.Text.Trim() Then
            CheckTB(sender, "Your Passwords are not matching.")
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        'check fields if empty
        'check if password = confirm password
        'check if username already exists
        'get textboxes values
        UserMod.Username_exists("NA")

    End Sub



End Class
