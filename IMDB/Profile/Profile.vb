Public Class Profile

    Public Function CountCharacter(ByVal value As String) As String
        Dim cnt = " "
        For Each c As Char In value
            cnt.Insert(0, "*")
        Next
        Return cnt
    End Function

    Private Sub On_load(sender As Object, e As EventArgs) Handles Me.Load

        NameL.Text = LogInForm.u.First_name
        Surname.Text = LogInForm.u.Last_name
        Email.Text = LogInForm.u.Email

        PasswordL.Text = CountCharacter(LogInForm.u.First_name)

    End Sub
    Private Sub EditB_Click(sender As Object, e As EventArgs) Handles EditB.Click
        NameL.Visible = False
        Surname.Visible = False
        Email.Visible = False
        PasswordL.Visible = False
        EditB.Visible = False
        Psw.Text = "New Password"

        UpdateB.Visible = True
        NameTB.Visible = True
        SurnameTB.Visible = True
        EmailTB.Visible = True
        NewPasswordTB.Visible = True
        CnP.Visible = True
        ConfirmTB.Visible = True

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateB.Click
        NameL.Visible = True
        Surname.Visible = True
        Email.Visible = True
        PasswordL.Visible = True
        EditB.Visible = True
        Psw.Text = "Password"

        UpdateB.Visible = False
        NameTB.Visible = False
        SurnameTB.Visible = False
        EmailTB.Visible = False
        NewPasswordTB.Visible = False
        CnP.Visible = False
        ConfirmTB.Visible = False

    End Sub



End Class