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
    Private Sub Closing_Main(sender As Object, e As EventArgs) Handles Me.Closing
        MoviesMain.Close()
    End Sub

    'Open MoviesMain in main form and close all other forms
    Private Sub AppName_Click(sender As Object, e As EventArgs) Handles AppName.Click
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        MoviesMain.TopLevel = False
        MainPanel.Controls.Add(MoviesMain)
        MoviesMain.Show()
        Timer.Start()
    End Sub

    'Open list in main form and close all other forms
    Private Sub ListBtn_Click(sender As Object, e As EventArgs) Handles ListBtn.Click
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
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
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Sub

    'Close all forms and open Log In form
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        LogIn.Show()
        Me.Close()
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
End Class