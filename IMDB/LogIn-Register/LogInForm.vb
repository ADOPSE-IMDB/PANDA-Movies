Imports Microsoft.Azure.Amqp.Framing
Imports MySql.Data.MySqlClient
Public Class LogInForm
    Private ReadOnly e As EventArgs



    Private Sub on_Load() Handles MyBase.Load
        Try
            MvcLuceneSampleApp.Search.Initialize()
        Catch
            MessageBox.Show("Connect to teithe First")
        End Try

        If My.Settings.Check Then
            RememberMe.Checked = True
            UserName.ForeColor = Color.Black
            Password.ForeColor = Color.Black
            Password.PasswordChar = "*"
            UserName.Text = My.Settings.username
            Password.Text = My.Settings.password
            Login_Click()
        End If
    End Sub

#Region "Username/Password Textbox"
    Private Sub Username_GotFocus(sender As TextBox, e As EventArgs) Handles UserName.GotFocus
        If sender.ForeColor = Color.DarkGray Then
            sender.ForeColor = Color.Black
            sender.Text = ""
        End If
    End Sub

    Private Sub Username_LostFocus(sender As Object, e As EventArgs) Handles UserName.Leave
        If UserName.Text = "" Then
            UserName.ForeColor = Color.DarkGray
            UserName.Text = "Username"
        End If
    End Sub

    Private Sub Pass_GotFocus(sender As TextBox, e As EventArgs) Handles Password.GotFocus
        If sender.ForeColor = Color.DarkGray Then
            sender.PasswordChar = "*"
            sender.ForeColor = Color.Black
            sender.Text = ""
        End If
    End Sub
    Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles Password.Leave
        If Password.Text = "" Then
            Password.PasswordChar = ""
            Password.ForeColor = Color.DarkGray
            Password.Text = "Password"
        End If
    End Sub
#End Region


    Private Sub Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterBtn.LinkClicked
        Register.Show()
        Me.Close()
    End Sub



#Region "LogIn"
    Public Shared u As User
    Private Sub Login_Click() Handles LogInButton.Click

        If UserName.ForeColor = Color.DarkGray Then
            info.Text = "Please enter your username"
        ElseIf Password.ForeColor = Color.DarkGray Then
            info.Text = "Please enter your password"
        Else
            u = UserMod.LogIn(UserName.Text, Password.Text)


            If u.Id = 0 Then
                info.Text = "Please check your username or password and try again"
            ElseIf u.Id = -1 Then
                MessageBox.Show("Cant Connect to the Data Base", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If RememberMe.Checked Then
                    My.Settings.Check = True
                    My.Settings.username = UserName.Text
                    My.Settings.password = Password.Text
                Else
                    My.Settings.Check = False
                    My.Settings.username = ""
                    My.Settings.password = ""
                End If
                info.Text = ""
                Main.Show()
                Close()
            End If
        End If
    End Sub

    Private Sub Login_Enter(sender As Object, e As EventArgs) Handles LogInButton.MouseEnter
        LogInButton.Image = My.Resources.btn1
    End Sub
    Private Sub Login_Leave(sender As Object, e As EventArgs) Handles LogInButton.MouseLeave
        LogInButton.Image = My.Resources.btn2
    End Sub

#End Region

#Region "Close Button"
    Private Sub CloseLogIn_click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub
    Private Sub CloseLogIn_Enter(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        ExitBtn.Image = My.Resources.Close2
    End Sub
    Private Sub CloseLogIn_Leave(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        ExitBtn.Image = My.Resources.Close1
    End Sub
#End Region

#Region "Move Log In"
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
