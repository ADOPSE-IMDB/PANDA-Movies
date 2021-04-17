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

    Public Structure UserStruc
        Public Index As Integer
        Dim Fname As String
        Dim Lname As String
        Dim email As String
        Dim username As String
    End Structure


    Public user As New UserStruc
    Private Sub TestLogin_Click(sender As Object, e As EventArgs) Handles testLogin.Click
        user.username = TextBoxUsername.Text



        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("   Select * from Users WHERE username = @usnl and `password`=@pass", con.getConnection())

        command.Parameters.Add("@usnl", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text
        con.openConnection()
        Try
            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    user.Index = reader.GetInt16(0)
                    user.Fname = reader.GetString(1)
                    user.Lname = reader.GetString(2)
                    user.email = reader.GetString(3)
                End If

                If user.Index = 0 Then
                    MessageBox.Show("Please check your username or password and try again", "SAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    MessageBox.Show(user.Index & " " & user.Fname & " " & user.Lname & " " & user.email & " " & user.username, "Happ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBoxPassword.Text = ""
                    Main.Show()
                    Close()
                End If

                con.closeConnection()
            End Using
        Catch
            MessageBox.Show("Couldnt get data", "SAD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.closeConnection()
        End Try
    End Sub
End Class
