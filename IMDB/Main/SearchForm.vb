Public Class SearchForm
    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load
        SLabel.Text += " " & Main.SearchBox.Text
    End Sub
End Class