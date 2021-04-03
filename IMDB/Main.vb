'Main Windows of the program 
Public Class Main
    ' Check if dropPanel is collapsed
    Dim isCollapsed As Boolean = False

    'Opens Main Movies form in main form
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        DropPanel.BackColor = Color.FromArgb(50, 0, 0, 0)
        MoviesMain.TopLevel = False
        MainPanel.Controls.Add(MoviesMain)
        MoviesMain.Show()
    End Sub

    'Closes all forms on exiting main form 
    Private Sub Closing_Main(sender As Object, e As EventArgs) Handles Me.Closed
        If Not Application.OpenForms().OfType(Of LogIn).Any Then
            Application.Exit()
        End If
    End Sub

    'Open MoviesMain in main form and close all other forms
    Private Sub AppName_Click(sender As Object, e As EventArgs) Handles AppName.Click
        Close_forms(Me)
        MoviesMain.TopLevel = False
        MainPanel.Controls.Add(MoviesMain)
        MoviesMain.Show()

    End Sub

    'Open list in main form and close all other forms
    Private Sub ListBtn_Click(sender As Object, e As EventArgs) Handles ListBtn.Click

    End Sub




    'Opens DropDown menu
    Private Sub NameBtn_Click(sender As Object, e As EventArgs) Handles NameBtn.Click
        Timer.Start()
    End Sub

    'Close DropDown Menu
    Private Sub NameBtn_LostFocus(sender As Object, e As EventArgs) Handles NameBtn.LostFocus
        If Not isCollapsed Then
            Threading.Thread.Sleep(100)
            Timer.Start()
        End If
    End Sub

    'Open profile on main form and close all other forms
    Private Sub OpenProfile_Click(sender As Object, e As EventArgs) Handles OpenProfile.Click
        Close_forms(Me)
        Panel1.Visible = True
        Profile.TopLevel = False
        Panel1.Controls.Add(Profile)
        Profile.Show()
    End Sub

    'Close all forms and open Log In form
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LogIn.Show()
        Close_forms(LogIn)
    End Sub



    'Timer for the drop down menu animation 
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If isCollapsed Then
            DropPanel.Height += 10
            If DropPanel.Size = DropPanel.MaximumSize Then
                Timer.Stop()
                isCollapsed = False
            End If
        Else
            DropPanel.Height -= 10
            If DropPanel.Size = DropPanel.MinimumSize Then
                Timer.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Public Shared Sub Close_forms(ex)
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({ex}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Sub
End Class