Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Profile

    Private Sub On_load(sender As Object, e As EventArgs) Handles Me.Load
        If Not LogInForm.u.Profile_Pic = "" Then
            ProfilePic.ImageLocation = LogInForm.u.Profile_Pic
        Else
            ProfilePic.Image = My.Resources.NoImage
        End If
        NameL.Text = LogInForm.u.First_name
        Surname.Text = LogInForm.u.Last_name
        Email.Text = LogInForm.u.Email
        NameTB.Text = ""
        SurnameTB.Text = ""
        EmailTB.Text = ""
        NewPasswordTB.Text = ""
        ConfirmTB.Text = ""
    End Sub

    Private Sub EditB_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        NameL.Visible = False
        Surname.Visible = False
        Email.Visible = False
        Editbtn.Visible = False

        PbN.Visible = True
        PbS.Visible = True
        PbE.Visible = True
        PbP.Visible = True
        PbCP.Visible = True
        Savebtn.Visible = True
        NameTB.Visible = True
        SurnameTB.Visible = True
        EmailTB.Visible = True
        Psw.Visible = True
        NewPasswordTB.Visible = True
        CnP.Visible = True
        ConfirmTB.Visible = True
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Savebtn.Click

        Dim CheckE As Boolean = True
        Dim CheckP As Boolean = True

        If EmailTB.Text <> "" And EmailTB.Text <> LogInForm.u.Email Then
            If Email_exists(EmailTB.Text) Then
                EmailInfo.Text = "Email already exists."
                CheckE = False
            Else
                CheckE = True
            End If
        End If

        If NewPasswordTB.Text <> "" Then
            CheckP = False
            If ConfirmTB.Text <> "" Then
                If NewPasswordTB.Text <> ConfirmTB.Text Then
                    PassInfo.Text = "Passwords are Not matching."
                Else
                    CheckP = True
                End If
            Else
                PassInfo.Text = "Please repeat your password."
            End If
        End If

        If CheckE And CheckP Then

            If NewPasswordTB.Text <> "" Then
                UserMod.UpdatePassword(LogInForm.u.Id, NewPasswordTB.Text)
                If My.Settings.Check Then
                    My.Settings.password = NewPasswordTB.Text
                End If
                NewPasswordTB.Text = ""
            End If

            If NameTB.Text = "" And SurnameTB.Text = "" And EmailTB.Text = "" And NewPasswordTB.Text = "" And ConfirmTB.Text = "" Then
                NameL.Visible = True
                Surname.Visible = True
                Email.Visible = True
                Editbtn.Visible = True
                PbN.Visible = False
                PbS.Visible = False
                PbE.Visible = False
                PbP.Visible = False
                PbCP.Visible = False
                Savebtn.Visible = False
                NameTB.Visible = False
                SurnameTB.Visible = False
                EmailTB.Visible = False
                Psw.Visible = False
                NewPasswordTB.Visible = False
                CnP.Visible = False
                ConfirmTB.Visible = False
                SaveInfo.Text = ""
                PassInfo.Text = ""
            Else
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

                UserMod.UpdateUser(LogInForm.u.Id, NameTB.Text, SurnameTB.Text, EmailTB.Text)
                NameL.Visible = True
                Surname.Visible = True
                Email.Visible = True
                Editbtn.Visible = True
                PbN.Visible = False
                PbS.Visible = False
                PbE.Visible = False
                PbP.Visible = False
                PbCP.Visible = False
                Savebtn.Visible = False
                NameTB.Visible = False
                SurnameTB.Visible = False
                EmailTB.Visible = False
                Psw.Visible = False
                NewPasswordTB.Visible = False
                CnP.Visible = False
                ConfirmTB.Visible = False
                SaveInfo.Text = "Your profile has been updated."
                PassInfo.Text = ""
                On_load(sender, e)
            End If
        End If
    End Sub

    Dim avatars() As String = {"https://i.ibb.co/GxtstcB/1.png", "https://i.ibb.co/5jsTXM7/2.png", "https://i.ibb.co/jwVDVTT/3.png", "https://i.ibb.co/dWZtdZn/4.png", "https://i.ibb.co/crDHbgy/5.png", "https://i.ibb.co/wrV9dcP/6.png", "https://i.ibb.co/mC6SpFY/7.png", "https://i.ibb.co/bX0MT2y/8.png"}


    Private Sub UploadB_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click
        If ChangeAvatarPanel.Visible Then
            ChangeAvatarPanel.Visible = False
            For Each pb In ChangeAvatarPanel.Controls.OfType(Of PictureBox)().ToArray()
                pb.Dispose()
            Next
        Else
            Dim posx = 30
            Dim posy = 2
            ChangeAvatarPanel.Visible = True
            For index = 0 To avatars.Length - 1
                Dim avatarPicBox As New PictureBox With {
                        .SizeMode = PictureBoxSizeMode.StretchImage,
                        .BackColor = Color.Transparent,
                        .Size = New Size(120, 120),
                        .Location = New Point(posx, posy),
                        .Cursor = Cursors.Hand,
                        .ImageLocation = avatars(index),
                        .BorderStyle = BorderStyle.Fixed3D
                }

                ChangeAvatarPanel.Controls.Add(avatarPicBox)
                AddHandler avatarPicBox.Click, AddressOf ChangeAvatarSub
                posx += 160
                If (index + 1) Mod 2 = 0 Then
                    posx = 30
                    posy += 140
                End If
            Next
            ChangeAvatarPanel.Height = posy + 160
        End If
    End Sub

    Public Sub ChangeAvatarSub(sender As PictureBox, e As EventArgs)
        ProfilePic.ImageLocation = sender.ImageLocation
        ChangeAvatarPanel.Visible = False
        LogInForm.u.Profile_Pic = sender.ImageLocation
        SetProfilePic(LogInForm.u.Id, sender.ImageLocation)

        For Each pb In ChangeAvatarPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next
    End Sub

    Public Sub Btn_Enter(sender As Object, e As EventArgs) Handles ChangeBtn.MouseEnter, Editbtn.MouseEnter, Savebtn.MouseEnter
        btnEnter(sender.parent)
    End Sub
    Public Sub Btn_Leave(sender As Object, e As EventArgs) Handles ChangeBtn.MouseLeave, Editbtn.MouseLeave, Savebtn.MouseLeave
        btnLeave(sender.parent)
    End Sub

End Class