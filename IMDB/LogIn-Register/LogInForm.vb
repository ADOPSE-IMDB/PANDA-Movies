Imports MySql.Data.MySqlClient
Public Class LogInForm
    Private ReadOnly e As EventArgs



    Private Sub on_Load() Handles MyBase.Load
        MvcLuceneSampleApp.Search.LuceneSearch.Initialize()
    End Sub

    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Application.Exit()
    End Sub

    'Check Username and Password to log in


    'Close Log in and open Register form 
    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles LabelGoToSignup.Click
        Register.Show()
        Me.Close()
    End Sub


    Public Shared u As User

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click


        If TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then

        Else
            u = UserMod.LogIn(TextBoxUsername.Text, TextBoxPassword.Text)


            If u.Id = 0 Then
                MessageBox.Show("Please check your username or password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf u.Id = -1 Then
                MessageBox.Show("Cant Connect to the Data Base", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Main.Show()
                Close()
            End If
        End If
    End Sub
End Class
