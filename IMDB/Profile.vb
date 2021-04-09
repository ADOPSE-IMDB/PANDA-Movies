Public Class Profile
    Private Sub On_load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub EditB_Click(sender As Object, e As EventArgs) Handles EditB.Click
        NameL.Visible = False
        Surname.Visible = False
        Email.Visible = False
        Password.Visible = False
        EditB.Visible = False

        UpdateB.Visible = True
        NameTB.Visible = True
        SurnameTB.Visible = True
        EmailTB.Visible = True
        NewPasswordTB.Visible = True

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateB.Click
        NameL.Visible = True
        Surname.Visible = True
        Email.Visible = True
        Password.Visible = True
        EditB.Visible = True

        UpdateB.Visible = False
        NameTB.Visible = False
        SurnameTB.Visible = False
        EmailTB.Visible = False
        NewPasswordTB.Visible = False

    End Sub

End Class