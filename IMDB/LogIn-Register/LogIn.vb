Imports MySql.Data.MySqlClient
Public Class LogIn
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

        If TextBoxUsername.Text.Trim() = "" Or TextBoxUsername.Text.Trim().ToLower() = "username" Then
            MessageBox.Show("Enter your Username To Log In", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)


        ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then
            MessageBox.Show("Enter your Password To Log In", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)


        Else
            adapter.SelectCommand = command
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                MessageBox.Show("LOGGED", "LOGGED", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub


End Class
