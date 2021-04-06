'Main Windows of the program 
Public Class Main
    ' Check if dropPanel is collapsed
    Public isCollapsed As Boolean = False

    'Load Main Page
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        DropPanel.Height = 0
        MoviesMain.TopLevel = False
        MainPanel.Controls.Add(MoviesMain)
        MoviesMain.Show()
        For Each c As Control In Me.Controls
            AddHandler c.MouseDown, AddressOf c_MouseDown
        Next
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
    Private Sub FavoriteBtn_Click(sender As Object, e As EventArgs) Handles FavoriteBtn.Click
        If Not Application.OpenForms().OfType(Of Favorite).Any Then
            ChnageWindow(Favorite, MainPanel, False)
            HomeInticator.Visible = False
            FavoriteInticator.Visible = True
            UsernameInticator.Visible = False
        End If
    End Sub

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
        LogIn.Show()
        Close_forms(LogIn)
    End Sub

    Public Sub c_MouseDown(sender As Object, e As MouseEventArgs)
        If sender IsNot NameBtn And Not isCollapsed Then
            Timer.Start()
        End If
    End Sub
#End Region

#Region "Loads all movies"
    Public Shared Sub Load_Movies(h As Integer, panel As Panel, array() As PictureBox, PosY As Integer)

        'Check height of the Movies Panel
        If h Mod 5 = 0 Then
            panel.Height = (h / 5) * 275 + 100
        Else
            panel.Height = (h \ 5) * 275 + 375
        End If

        'Places Labels for each movie
        Dim PosX = 55

        For index As Integer = 1 To h
            Dim MovieBox As New PictureBox With {
                .Size = New Size(190, 250),
                .Location = New Point(PosX, PosY),
                .BackColor = Color.Red,
                .Text = index,
                .Cursor = Cursors.Hand
            }
            panel.Controls.Add(MovieBox)
            MovieBox.AccessibleName = index
            'Add Labels on array
            array(index) = MovieBox
            'Adds click even for every label
            AddHandler array(index).Click, AddressOf MoviesMain.AllMoviesCLick


            PosX += 245
            If index Mod 5 = 0 Then
                PosY += 275
                PosX = 55
            End If
        Next
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