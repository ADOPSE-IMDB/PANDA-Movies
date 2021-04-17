Imports System
Imports System.Data

Module Program
    Sub pro(args As String())
        'Get and Print Users table then show Column Types
        Dim table As New DataTable
        Dim user As New User
        user.GetAllUsers(table)

        Dim msg As New Message
        msg.ShowTable(table)
        msg.ShowColTypes(table)

        'Print the total number of Movies
        Dim c As New DataTable
        Dim movie As New Movie
        movie.CountMovies(c)
        msg.ShowTable(c)

        'Print Movies with id from 2 to 4
        Dim specMovies As New DataTable
        movie.GetMoviesFromTo(2, 4, specMovies)
        msg.ShowTable(specMovies)

        'Print the 10 Top Movies
        Dim topMoviesTable As New DataTable
        movie.GetTopMovies(topMoviesTable)
        msg.ShowTable(topMoviesTable)
    End Sub


End Module
