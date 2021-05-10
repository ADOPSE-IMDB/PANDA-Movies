Public Class Profile

    Private Sub On_load(sender As Object, e As EventArgs) Handles Me.Load
        NameL.Text = LogInForm.u.First_name
        Surname.Text = LogInForm.u.Last_name
        Email.Text = LogInForm.u.Email
        NameTB.Text = ""
        SurnameTB.Text = ""
        EmailTB.Text = ""
        NewPasswordTB.Text = ""
        ConfirmTB.Text = ""
    End Sub

    Private Sub EditB_Click(sender As Object, e As EventArgs) Handles EditB.Click
        NameL.Visible = False
        Surname.Visible = False
        Email.Visible = False
        EditB.Visible = False

        UpdateB.Visible = True
        NameTB.Visible = True
        SurnameTB.Visible = True
        EmailTB.Visible = True
        Psw.Visible = True
        NewPasswordTB.Visible = True
        CnP.Visible = True
        ConfirmTB.Visible = True
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateB.Click

        Dim CheckE As Boolean = True
        Dim CheckP As Boolean = True

        If EmailTB.Text <> "" And EmailTB.Text <> LogInForm.u.Email Then
            If Email_exists(EmailTB.Text) Then
                Me.XError.SetError(EmailTB, "Email already exists.")
                CheckE = False
            Else
                CheckE = True
            End If
        End If

        If NewPasswordTB.Text <> "" Then
            CheckP = False
            If ConfirmTB.Text <> "" Then
                If NewPasswordTB.Text <> ConfirmTB.Text Then
                    Me.XError.SetError(ConfirmTB, "Passwords are not matching.")
                Else
                    CheckP = True
                End If
            Else
                Me.XError.SetError(ConfirmTB, "Please repeat your password.")
            End If
        End If

        If CheckE And CheckP Then
            If NameTB.Text = "" Then
                NameTB.Text = LogInForm.u.First_name
            Else
                LogInForm.u.First_name = NameTB.Text
            End If
            If SurnameTB.Text = "" Then
                SurnameTB.Text = LogInForm.u.Last_name
            Else
                LogInForm.u.Last_name = SurnameTB.Text
            End If
            If EmailTB.Text = "" Then
                EmailTB.Text = LogInForm.u.Email
            Else
                LogInForm.u.Email = EmailTB.Text
            End If

            If NewPasswordTB.Text <> "" Then
                UserMod.UpdatePassword(LogInForm.u.Id, NewPasswordTB.Text)
            End If

            UserMod.UpdateUser(LogInForm.u.Id, NameTB.Text, SurnameTB.Text, EmailTB.Text)
            NameL.Visible = True
            Surname.Visible = True
            Email.Visible = True
            EditB.Visible = True

            UpdateB.Visible = False
            NameTB.Visible = False
            SurnameTB.Visible = False
            EmailTB.Visible = False
            Psw.Visible = False
            NewPasswordTB.Visible = False
            CnP.Visible = False
            ConfirmTB.Visible = False
            MessageBox.Show("Your profile has been updated.", "Update successful.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            On_load(sender, e)
        End If
    End Sub

    Private Sub UploadB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadB.Click

        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.png;*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProfilePic.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub
End Class