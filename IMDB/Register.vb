Public Class Register

    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Application.Exit()
    End Sub

    Private Sub SignUpB_Click(sender As Object, e As EventArgs)

        If FirstNameTB.Text = "" Then

            Me.XError.SetError(Me.FirstNameTB, "Please enter your First Name.")

        Else

            Me.XError.SetError(Me.FirstNameTB, "")

        End If

        If LastNameTB.Text = "" Then

            Me.XError.SetError(Me.LastNameTB, "Please enter your Last Name.")

        Else

            Me.XError.SetError(Me.LastNameTB, "")

        End If

        If UsernameTB.Text = "" Then

            Me.XError.SetError(Me.UsernameTB, "Please enter a Username.")

        Else

            Me.XError.SetError(Me.UsernameTB, "")

        End If

        If EmailTB.Text = "" Then

            Me.XError.SetError(Me.EmailTB, "Please enter an Email.")

        Else

            Me.XError.SetError(Me.EmailTB, "")

        End If

        If PasswordTB.Text = "" Then

            Me.XError.SetError(Me.PasswordTB, "Please enter a Password.")

        Else

            Me.XError.SetError(Me.PasswordTB, "")

        End If

        If ConfirmPasswordTB.Text = "" Then

            Me.XError.SetError(Me.ConfirmPasswordTB, "Please confirm your Password.")

        ElseIf ConfirmPasswordTB.Text <> PasswordTB.Text Then

            Me.XError.SetError(Me.ConfirmPasswordTB, "Passwords do not match.")

        Else

            Me.XError.SetError(Me.ConfirmPasswordTB, "")

        End If


    End Sub

    Private Sub LogInLink_Click(sender As Object, e As EventArgs) Handles LogInLink.Click
        LogIn.Show()
        Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

    End Sub
End Class
