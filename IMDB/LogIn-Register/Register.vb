Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub Return_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        LogInLink_Click(sender, e)
    End Sub

    Private Sub Return_Hover(sender As Object, e As EventArgs) Handles ReturnBtn.MouseEnter
        ReturnBtn.Image = My.Resources.Close2
    End Sub

    Private Sub Return_Leave(sender As Object, e As EventArgs) Handles ReturnBtn.MouseLeave
        ReturnBtn.Image = My.Resources.Close1
    End Sub

    Private Sub LogInLink_Click(sender As Object, e As EventArgs) Handles LogInLink.Click
        LogInForm.Show()
        Close()
    End Sub


#Region "Register TextBox"

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBoxFirstname.GotFocus, TextBoxLastname.GotFocus, TextBoxUsername.GotFocus, TextBoxEmail.GotFocus
        Dim s As TextBox = sender
        If s.ForeColor = Color.DarkGray Then
            s.ForeColor = Color.Black
            s.Text = ""
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBoxFirstname.Leave, TextBoxLastname.Leave, TextBoxUsername.Leave, TextBoxEmail.Leave
        Dim s As TextBox = sender
        If s.Text = "" Then
            s.ForeColor = Color.DarkGray
            s.Text = s.AccessibleName
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.GotFocus, TextBoxConfirmPassword.GotFocus
        Dim s As TextBox = sender
        If s.ForeColor = Color.DarkGray Then
            s.PasswordChar = "*"
            s.Text = ""
            s.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        Dim s As TextBox = sender
        If s.Text = "" Then
            s.PasswordChar = ""
            s.ForeColor = Color.DarkGray
            s.Text = s.AccessibleName

        End If
    End Sub

    Private Sub CPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxConfirmPassword.Leave
        Dim s As TextBox = sender
        If s.Text = "" Then
            s.PasswordChar = ""
            s.ForeColor = Color.DarkGray
            s.Text = s.AccessibleName
        Else
            If TextBoxPassword.Text <> TextBoxConfirmPassword.Text Then
                info.Text = "Passwords do not match"
            End If
        End If
    End Sub

#End Region



    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click

        If TextBoxFirstname.ForeColor = Color.Black And TextBoxLastname.ForeColor = Color.Black And TextBoxUsername.ForeColor = Color.Black And TextBoxEmail.ForeColor = Color.Black And TextBoxPassword.ForeColor = Color.Black And TextBoxConfirmPassword.ForeColor = Color.Black Then
            If TextBoxPassword.Text = TextBoxConfirmPassword.Text Then
                If UserMod.Username_exists(TextBoxUsername.Text) Then
                    info.Text = "Username already exists."
                Else
                    If UserMod.Email_exists(TextBoxEmail.Text) Then
                        info.Text = "Email already exists."
                    Else
                        UserMod.Register(TextBoxFirstname.Text, TextBoxLastname.Text, TextBoxUsername.Text, TextBoxEmail.Text, TextBoxPassword.Text)
                        MessageBox.Show("You have successfully signed up!", "Singed Up.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LogInLink_Click(sender, e)
                    End If
                End If
            Else
                info.Text = "Passwords do not match"
            End If
        Else
            info.Text = "Please fill all fields."
        End If
    End Sub

    Private Sub ButtonRegister_Hover(sender As Object, e As EventArgs) Handles BtnRegister.MouseEnter
        BtnRegister.Image = My.Resources.Register2
    End Sub
    Private Sub ButtonRegister_Leave(sender As Object, e As EventArgs) Handles BtnRegister.MouseLeave
        BtnRegister.Image = My.Resources.Register1
    End Sub


#Region "Move Register"

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
