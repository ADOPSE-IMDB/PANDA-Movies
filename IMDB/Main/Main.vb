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
    End Sub

#Region "Open Main page"

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        If Not Application.OpenForms().OfType(Of MoviesMain).Any Then
            ChnageWindow(MoviesMain, MainPanel, False)
            HomeInticator.Visible = True
            FavoriteInticator.Visible = False
            UsernameInticator.Visible = False
        End If
    End Sub

    'Open MoviesMain in main form and close all other forms
    Private Sub AppName_Click(sender As Object, e As EventArgs) Handles AppName.Click
        HomeButton_Click(sender, e)
    End Sub

#End Region

    'Open Favorite Form
    Public Sub FavoriteBtn_Click(sender As Object, e As EventArgs) Handles FavoriteBtn.Click
        If Not Application.OpenForms().OfType(Of Favorite).Any Then
            ChnageWindow(Favorite, MainPanel, False)
            HomeInticator.Visible = False
            FavoriteInticator.Visible = True
            UsernameInticator.Visible = False
        End If
    End Sub
#Region "Search"

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        If SearchBox.Text.Trim.Length >= 3 Then
            If Application.OpenForms().OfType(Of SearchForm).Any Then
                SearchForm.Close()
            End If
            ChnageWindow(SearchForm, MainPanel, False)
            HomeInticator.Visible = False
            FavoriteInticator.Visible = False
            UsernameInticator.Visible = False
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

#Region "Drop Menu"

    'Opens DropDown menu
    Private Sub NameBtn_Click(sender As Object, e As EventArgs) Handles NameBtn.Click
        Timer.Start()
    End Sub

    'Open Profile
    Private Sub OpenProfile_Click(sender As Object, e As EventArgs) Handles OpenProfile.Click
        If Not Application.OpenForms().OfType(Of Profile).Any Then
            ChnageWindow(Profile, Container, True)
            HomeInticator.Visible = False
            FavoriteInticator.Visible = False
            UsernameInticator.Visible = True
        End If
    End Sub

    'Log Out Button
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogInForm.Show()
        Close_forms(LogInForm)
    End Sub


#End Region



#Region "Timer for drop menu"
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If isCollapsed Then
            DropPanel.Height += 10
            If DropPanel.Size = DropPanel.MaximumSize Then
                Timer.Stop()
                isCollapsed = False
                UsernameInticator.Visible = True
            End If
        Else
            DropPanel.Height -= 10
            If DropPanel.Size = DropPanel.MinimumSize Then
                Timer.Stop()
                isCollapsed = True
                UsernameInticator.Visible = False
            End If
            If Application.OpenForms().OfType(Of Profile).Any Then
                UsernameInticator.Visible = True
                HomeInticator.Visible = False
                FavoriteInticator.Visible = False
            End If
        End If
    End Sub
#End Region

#Region "Change Form "

    Private Sub ChnageWindow(newform, panel, flag)
        Close_forms(Me)
        newform.TopLevel = False
        panel.Controls.Add(newform)
        newform.Show()
        Container.Visible = flag
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

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MovePanel.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MovePanel.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MovePanel.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If

    End Sub


#End Region

    'Close Program 
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub


End Class