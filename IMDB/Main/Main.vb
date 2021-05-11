'Main Windows of the program 
Public Class Main
    ' Check if dropPanel is collapsed
    Public isCollapsed As Boolean = False

    'Load Main Page
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameBtn.Text = LogInForm.u.Username
        DropPanel.Height = 0
        MoviesMain.TopLevel = False
        MainPanel.Controls.Add(MoviesMain)
        MoviesMain.Show()
        HomeBtnInd.BackgroundImage = My.Resources.Indicator
    End Sub

#Region "Open Main page"

    Public Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        If Not Application.OpenForms().OfType(Of MoviesMain).Any Then
            ChnageWindow(MoviesMain, MainPanel, False)
            HomeBtnInd.BackgroundImage = My.Resources.Indicator
            FavoriteInd.BackgroundImage = My.Resources.GeneralBtn1
            NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
        End If
    End Sub

    Public Sub Home_Hover(sender As Object, e As EventArgs) Handles HomeBtn.MouseEnter
        If Not Application.OpenForms().OfType(Of MoviesMain).Any Then
            HomeBtnInd.BackgroundImage = My.Resources.GeneralBtn2
        End If
    End Sub
    Public Sub HomeButton_Leave(sender As Object, e As EventArgs) Handles HomeBtn.MouseLeave
        If Not Application.OpenForms().OfType(Of MoviesMain).Any Then
            HomeBtnInd.BackgroundImage = My.Resources.GeneralBtn1
        End If
    End Sub




    'Open MoviesMain in main form and close all other forms
    Private Sub AppNamee_Click(sender As Object, e As EventArgs) Handles AppName.Click
        HomeButton_Click(sender, e)
    End Sub

#End Region

#Region "Favorite"


    'Open Favorite Form
    Public Sub FavoriteBtn_Click(sender As Object, e As EventArgs) Handles FavoriteBtn.Click
        If Not Application.OpenForms().OfType(Of Favorite).Any Then
            ChnageWindow(Favorite, MainPanel, False)
            HomeBtnInd.BackgroundImage = My.Resources.GeneralBtn1
            FavoriteInd.BackgroundImage = My.Resources.Indicator
            NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
        End If
    End Sub

    Public Sub FavoriteBtn_Enter(sender As Object, e As EventArgs) Handles FavoriteBtn.MouseEnter
        If Not Application.OpenForms().OfType(Of Favorite).Any Then
            FavoriteInd.BackgroundImage = My.Resources.GeneralBtn2
        End If
    End Sub

    Public Sub FavoriteBtn_Leave(sender As Object, e As EventArgs) Handles FavoriteBtn.MouseLeave
        If Not Application.OpenForms().OfType(Of Favorite).Any Then
            FavoriteInd.BackgroundImage = My.Resources.GeneralBtn1
        End If
    End Sub
#End Region

#Region "Drop Menu"
    'Opens DropDown menu
    Private Sub NameBtn_Click(sender As Object, e As EventArgs) Handles NameBtn.Click
        Timer.Start()
    End Sub

    Public Sub NameBtn_Enter(sender As Object, e As EventArgs) Handles NameBtn.MouseEnter
        If isCollapsed And Not Application.OpenForms().OfType(Of Profile).Any Then
            NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn2
        End If
    End Sub

    Public Sub NameBtn_Leave(sender As Object, e As EventArgs) Handles NameBtn.MouseLeave
        If isCollapsed And Not Application.OpenForms().OfType(Of Profile).Any Then
            NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
        End If
    End Sub




    'Open Profile
    Private Sub OpenProfile_Click(sender As Object, e As EventArgs) Handles OpenProfile.Click
        If Not Application.OpenForms().OfType(Of Profile).Any Then
            ChnageWindow(Profile, Container, True)
        End If
        If Not isCollapsed Then
            Threading.Thread.Sleep(100)
            Timer.Start()
        End If
    End Sub




    'Log Out Button
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogInForm.Show()
        Close_forms(LogInForm)
    End Sub


    Private Sub OpenProfile_Enter(sender As Object, e As EventArgs) Handles OpenProfile.MouseEnter, LogOut.MouseEnter
        btnEnter(sender.Parent)
    End Sub

    Private Sub OpenProfile_Leave(sender As Object, e As EventArgs) Handles OpenProfile.MouseLeave, LogOut.MouseLeave
        btnLeave(sender.Parent)
    End Sub




    'check if mouse is over the buttons/DropPanel
    Private Sub DropPanel_MouseLeave(sender As Object, e As System.EventArgs) Handles DropPanel.MouseLeave, NameBtn.MouseLeave, OpenProfile.MouseLeave, LogOut.MouseLeave
        If Not MouseIsOverControl(OpenProfile) And Not MouseIsOverControl(LogOut) And Not MouseIsOverControl(DropPanel) And Not MouseIsOverControl(NameBtn) Then
            If Not isCollapsed Then
                Threading.Thread.Sleep(100)
                Timer.Start()
            End If
        End If
    End Sub

    'Check if mouse is over a control
    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function

#End Region

#Region "Search"

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        If SearchBox.Text.Trim.Length >= 3 Then
            If Application.OpenForms().OfType(Of SearchForm).Any Then
                SearchForm.Close()
            End If
            ChnageWindow(SearchForm, MainPanel, False)
            HomeBtnInd.BackgroundImage = My.Resources.GeneralBtn1
            FavoriteInd.BackgroundImage = My.Resources.GeneralBtn1
            NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
            SearchBox.Text = ""
        End If
    End Sub

    Public Shared resultMovies() As Movie
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text.Trim.Length >= 3 Then
            resultPanel.Visible = True
            For Each lL In resultPanel.Controls.OfType(Of LinkLabel)().ToArray()
                lL.Dispose()
            Next

            resultMovies = MvcLuceneSampleApp.Search.LuceneSearch.SearchMovieResults(SearchBox.Text)
            If resultMovies.Length = 0 Then
                resultPanel.Height = 20
                ResultInfo.Visible = True
                ResultInfo.Text = "No Result Found"
            Else
                ResultInfo.Visible = False
                SearchLoad(resultPanel, resultMovies)
            End If

        ElseIf SearchBox.Text.Trim.Length > 0 Then
            resultPanel.Visible = True
            resultPanel.Height = 20
            ResultInfo.Visible = True
            ResultInfo.Text = "Please type 3 or more letters"
        Else
            resultPanel.Visible = False
        End If
    End Sub
#End Region

#Region "Timer for drop menu"
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If isCollapsed Then
            DropPanel.Height += 10
            If DropPanel.Size = DropPanel.MaximumSize Then
                Timer.Stop()
                isCollapsed = False
                NamebtnPanel.BackgroundImage = My.Resources.Indicator
            End If
        Else
            DropPanel.Height -= 10
            If DropPanel.Size = DropPanel.MinimumSize Then
                Timer.Stop()
                isCollapsed = True
                NamebtnPanel.BackgroundImage = My.Resources.GeneralBtn1
            End If
            If Application.OpenForms().OfType(Of Profile).Any Then
                HomeBtnInd.BackgroundImage = My.Resources.GeneralBtn1
                FavoriteInd.BackgroundImage = My.Resources.GeneralBtn1
                NamebtnPanel.BackgroundImage = My.Resources.Indicator
            End If
        End If
    End Sub
#End Region

#Region "Change Form "

    Private Sub ChnageWindow(newform, panel, flag)
        Container.Visible = flag
        Close_forms(Me)
        newform.TopLevel = False
        panel.Controls.Add(newform)
        newform.Show()
    End Sub
#End Region

#Region "Close forms"
    'Close forms Function
    Public Shared Sub Close_forms(ex)

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({ex}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

    End Sub
#End Region

#Region " Move Main Form "
    Private Sub F_mouseDown(sender As Object, e As EventArgs) Handles AppLabel.MouseDown, MovePanel.MouseDown
        MoveForm_MouseDown(sender, e)
    End Sub

    Private Sub F_mouseMove(sender As Object, e As EventArgs) Handles AppLabel.MouseMove, MovePanel.MouseMove
        MoveForm_MouseMove(sender, e, Me)
    End Sub

    Private Sub F_mouseUp(sender As Object, e As EventArgs) Handles AppLabel.MouseUp, MovePanel.MouseUp
        MoveForm_MouseUp(sender, e)
    End Sub
#End Region


#Region "Exit App"
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Dim answer As Integer
        answer = MsgBox("Do you really want to Exit the PANDApp?", vbExclamation + vbYesNo, "We will miss you :/")
        If answer = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ExitBtn_Hover(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        ExitBtn.Image = My.Resources.Close2
    End Sub
    Private Sub ExitBtn_Leave(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        ExitBtn.Image = My.Resources.Close1
    End Sub

#End Region

End Class