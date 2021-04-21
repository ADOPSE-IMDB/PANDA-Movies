Imports MySql.Data.MySqlClient
Public Class LogInForm
    Private ReadOnly e As EventArgs


    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Application.Exit()
    End Sub

    'Check Username and Password to log in


    'Close Log in and open Register form 
    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles LabelGoToSignup.Click
        Register.Show()
        Me.Close()
    End Sub




    Private Sub TestLogin_Click(sender As Object, e As EventArgs) Handles Login.Click


        If TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then

        Else
            Dim u As User
            u = UserMod.LogIn(TextBoxUsername.Text, TextBoxPassword.Text)


            If u.Id = 0 Then
                MessageBox.Show("Please check your username or password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf u.Id = -1 Then
                MessageBox.Show("Cant Connect to the Data Base", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(u.Id & " " & u.First_name & " " & u.Last_name & " " & u.Email & " " & u.Username, "Happ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxPassword.Text = ""
                Main.Show()
                Close()
            End If
        End If
    End Sub
End Class
