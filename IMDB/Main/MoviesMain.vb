Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class MoviesMain

    Public Shared TopTen(10) As Movie
    Public t As New Movie
    Public Shared MovieArray(20) As LoadPictureBox.s
    Public Shared cMovie(20) As PictureBox

    Private Sub On_Load(sender As Object, e As EventArgs) Handles Me.Load


#Region "TEST1"
        'loads all movies to custom Array
        Dim c = 1
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

                    c += 1
                End While
                con.closeConnection()
            End Using
        Catch
            con.closeConnection()
        End Try

#End Region
        LoadPictureBox.Create(20, AllMoviesPanel, cMovie, 100)

#Region "TEST2"
        Dim results As DataTable
        results = t.GetMoviesFromTo(1, 2)
        c = 1
        For Each row As DataRow In results.Rows

            For Each col As DataColumn In results.Columns

                If col.ColumnName.Equals("id") Then
                    Dim i As Integer = row(col)
                    TopTen(1).Id = 1
                ElseIf col.ColumnName.Equals("title") Then
                    Dim i As String = row(col)
                    TopTen(1).Title = i
                ElseIf col.ColumnName.Equals("year") Then
                    TopTen(1).Year = 1
                ElseIf col.ColumnName.Equals("description") Then
                    TopTen(1).Description = "e"
                ElseIf col.ColumnName.Equals("rating") Then
                    TopTen(1).Rating = 1
                End If
                c += 1
            Next

        Next

#End Region
        Dim TopArray(10) As PictureBox
        TopArray = {Top1, Top2, Top3, Top4, Top5, Top6, Top7, Top8, Top9, Top10}

        For index As Integer = 0 To 9
            AddHandler TopArray(index).Click, AddressOf LoadPictureBox.AllMoviesCLick
            TopArray(index).TabIndex = index
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