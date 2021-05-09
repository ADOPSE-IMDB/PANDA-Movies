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
    End Sub




    Private Sub RegisterLink_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Close()
    End Sub


    Public Shared u As User

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click


        If TextBox.Text = "" Or TextBoxPassword.Text = "" Then

        Else
            u = UserMod.LogIn(TextBox.Text, TextBoxPassword.Text)


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
    Private Sub CloseLogIn_click(sender As Object, e As EventArgs) Handles CloseLogIn.Click
        Application.Exit()
    End Sub
    Private Sub CloseLogIn_Enter(sender As Object, e As EventArgs) Handles CloseLogIn.MouseEnter
        CloseLogIn.Image = My.Resources.Close2
    End Sub
    Private Sub CloseLogIn_Leave(sender As Object, e As EventArgs) Handles CloseLogIn.MouseLeave
        CloseLogIn.Image = My.Resources.Close1
    End Sub


End Class
