Public Class LogIn

    Public Connected As Boolean
    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Me.Close()
    End Sub

    Private Sub LogInB_Click(sender As Object, e As EventArgs) Handles LogInB.Click

        Connected = False

        If UsernameTB.Text = "" Then
            Me.XError.SetError(Me.UsernameTB, "Please enter a Username.")
        Else
            Me.XError.SetError(Me.UsernameTB, "")
        End If

        If PasswordTB.Text = "" Then
            Me.XError.SetError(Me.PasswordTB, "Please enter Password.")
        Else
            Me.XError.SetError(Me.PasswordTB, "")
        End If

        If UsernameTB.Text <> "" Or PasswordTB.Text <> "" Then
            If UsernameTB.Text <> "Admin" Then
                ErrorLabel.Text = "Username not found."
            Else
                If PasswordTB.Text = "Admin" Then
                    Connected = True
                    Me.Close()
                    ErrorLabel.Text = ""
                Else
                    ErrorLabel.Text = "Wrong Password."
                End If
            End If
        End If
    End Sub

    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles RegisterLink.Click
        Me.Close()
        Register.Show()
    End Sub

End Class
