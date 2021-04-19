Imports System
Imports System.Data

Module Examples
    Sub Main1(args As String())

        Dim loggedUser As New User              'make somehow Global
        loggedUser.LogIn("marley1", "222")
        Console.Write(loggedUser.Id)            'id will be 0 if login failed



        Dim u As New User
        Dim table As New DataTable
        u.GetAllUsers(table)

        'print all passwords
        For Each row As DataRow In table.Rows
            Console.WriteLine(row("password"))
        Next
        Console.WriteLine()


        'print 3rd user's password
        Console.WriteLine(table.Rows(2)("password").ToString)




        'Count movies
        Console.WriteLine()
        Console.WriteLine("Number of Movies: ")
        Dim m As New Movie
        Dim numb As New Integer
        numb = m.CountMovies
        Console.WriteLine(numb)



        'Get Movies with id from 2 to 4
        Dim movie As New Movie
        Console.WriteLine()
        Console.Write("Movies with id from 2 to 4:")
        Console.WriteLine()
        Dim specMovies As New DataTable
        'movie.GetMoviesFromTo(2, 4)
        'Print their IDs
        For Each row As DataRow In specMovies.Rows
            Console.WriteLine(row("id"))
        Next


    End Sub

    Sub oldExamples()
        'Get and Print Users table then show Column Types
        Console.Write("Users Table:")
        Console.WriteLine()
        Dim table As New DataTable

        Dim user As New User
        user.GetAllUsers(table)

        Dim msg As New Message
        msg.ShowTable(table)
        Console.Write("Users Table's Column Types:")
        Console.WriteLine()
        msg.ShowColTypes(table)
        Console.WriteLine()
        Console.WriteLine()

        'Print the 10 Top Movies
        Console.Write("Top Movies:")
        Console.WriteLine()
        Dim movie As New Movie
        Dim topMoviesTable As New DataTable
        movie.GetTopMovies(topMoviesTable)
        msg.ShowTable(topMoviesTable)
    End Sub

End Module
