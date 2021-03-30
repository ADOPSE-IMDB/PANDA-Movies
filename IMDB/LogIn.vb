Public Class LogIn

    Public Connected As Boolean
    Private ReadOnly e As EventArgs


    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Me.Close()
    End Sub

    'Check Username and Password to log in
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
                UsernameTB.Text = ""
                PasswordTB.Text = ""
            Else
                If PasswordTB.Text = "Admin" Then
                    Connected = True
                    Main.Show()
                    Me.Close()
                    ErrorLabel.Text = ""
                Else
                    ErrorLabel.Text = "Wrong Password."
                    PasswordTB.Text = ""
                End If
            End If
        End If
    End Sub

    'Close Log in and open Register form 
    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles RegisterLink.Click
        Register.Show()
        Me.Close()

    End Sub

End Class
