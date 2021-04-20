Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class MoviesMain

    Public Shared TopTen() As Movie
    Public Shared MovieArray(20) As LoadPictureBox.s
    Public Shared cMovie(20) As PictureBox

    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load





#Region "TEST1"
        TopTen = GetMoviesFromTo(1, 5)

        TopTen(0).Url = "https://i.ibb.co/8B9qK6L/inception.jpg"
        TopTen(1).Url = "https://i.ibb.co/wBy2fbL/Interstellar.jpg"
        TopTen(2).Url = "https://i.ibb.co/R0RTKdk/Parasite.jpg"
        TopTen(3).Url = "https://i.ibb.co/sFJGP4J/Joker.jpg"
        TopTen(4).Url = "https://i.ibb.co/8g2FP1L/A-Beautiful-Mind.jpg"
#End Region


        LoadPictureBox.Create(20, AllMoviesPanel, cMovie, 100)


        Dim TopArray(10) As PictureBox
        TopArray = {Top1, Top2, Top3, Top4, Top5, Top6, Top7, Top8, Top9, Top10}
        For index As Integer = 0 To TopTen.Length - 1
            TopArray(index).Image = My.Resources._200
            TopArray(index).TabIndex = index
            TopArray(index).ImageLocation = TopTen(index).Url
            AddHandler TopArray(index).Click, AddressOf LoadPictureBox.AllMoviesCLick





        Next

    End Sub


    Dim n = 20
    ReadOnly tainies = 89

    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        n -= 20
        Main.SearchBox.Text = n
        If Not ne.Enabled Then
            ne.Enabled = True
        End If

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next

        If n = 20 Then
            ne.Text = curr.Text
            curr.Text = Pre.Text
            Pre.Text = "Start"
            Pre.Enabled = False
        Else
            ne.Text = curr.Text
            curr.Text = Pre.Text
            Pre.Text = n - 39 & " -> " & n - 20

        End If


        Dim cMovie(20) As PictureBox
        LoadPictureBox.Create(20, AllMoviesPanel, cMovie, 100)
    End Sub

    Private Sub Ne_Click(sender As Object, e As EventArgs) Handles ne.Click
        n += 20
        Main.SearchBox.Text = n
        If Not Pre.Enabled Then
            Pre.Enabled = True
        End If

        For Each pb In AllMoviesPanel.Controls.OfType(Of PictureBox)().ToArray()
            pb.Dispose()
        Next

#Region "TEST1"
        'loads all movies to custom Array
        Dim c = 5
        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("   Select * from Movies", con.getConnection())
        con.openConnection()
        Try
            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    MovieArray(c).Index = reader.GetInt16("id")
                    MovieArray(c).Name = reader.GetString(1)
                    MovieArray(c).reDate = reader.GetDateTime(2)
                    MovieArray(c).Des = reader.GetString(3)
                    MovieArray(c).rate = reader.GetInt16(4)

                    c -= 1
                End While
                con.closeConnection()
            End Using
        Catch
            con.closeConnection()
        End Try

#End Region
        If n > tainies Then
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = "End"

            Dim t = tainies Mod 20
            Dim cMovie(t) As PictureBox
            LoadPictureBox.Create(t, AllMoviesPanel, cMovie, 100)
            ne.Enabled = False

        ElseIf n > tainies - 20 Then

            Pre.Text = curr.Text
            curr.Text = ne.Text
            Dim t = tainies Mod 20
            ne.Text = n + 1 & " -> " & tainies

            Dim cMovie(20) As PictureBox
            LoadPictureBox.Create(20, AllMoviesPanel, cMovie, 100)
        Else
            Pre.Text = curr.Text
            curr.Text = ne.Text
            ne.Text = n + 1 & " -> " & n + 20

            Dim cMovie(20) As PictureBox
            LoadPictureBox.Create(20, AllMoviesPanel, cMovie, 100)



        End If

    End Sub

End Class