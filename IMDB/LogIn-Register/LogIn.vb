Imports MySql.Data.MySqlClient
Public Class LogIn

    Inherits Form
    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)
        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()
    End Sub

    Private Sub paintMe(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawFormGradient(Color.Black, Color.White)
    End Sub

    Dim MySqlConn As New MySqlConnection("Server=dblabs.it.teithe.gr;Port=3306;Database=it185223;Uid=it185223;Pwd=chilli123;")
    Dim COMMAND As MySqlCommand


    Public Connected As Boolean
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CheckConnection.Click
        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Succesfull")
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Dim createSql As String
        Try
            MySqlConn = MySqlConn
            MySqlConn.Open()
            Dim tblname = "test"
            createSql = "CREATE TABLE " & tblname & " (id INT(6) NOT NULL AUTO_INCREMENT,otherField TEXT NOT NULL,PRIMARY KEY (id));"
            Dim cmd As New MySqlCommand(createSql, MySqlConn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySqlConn.Close()
        End Try

    End Sub



    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim conn As New MY_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()

        Dim command As New MySqlCommand("SELECT 
    `Users`.`username`,
    `Users`.`password`
FROM `it185223`.`Users` where `username`=@usn and `password`=@pass", conn.getConnection())


        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        If TextBoxUsername.Text.Trim() = "" Then
            Me.XError.SetError(Me.TextBoxUsername, "Please enter a Username.")
        Else
            Me.XError.SetError(Me.TextBoxUsername, "")
        End If


        If TextBoxPassword.Text.Trim() = "" Then
            Me.XError.SetError(Me.TextBoxPassword, "Please enter a Password.")
        Else
            Me.XError.SetError(Me.TextBoxPassword, "")
        End If

        If TextBoxUsername.Text <> "" And TextBoxPassword.Text <> "" Then
            Try
                adapter.SelectCommand = command
                adapter.Fill(table)
                If table.Rows.Count > 0 Then

                    Main.Show()
                    Close()

                Else
                    MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Catch
                MessageBox.Show("Not connected to the database." & vbCrLf & "Please use OpenVPN and try again.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


End Class
