Imports System.Data

Module UserMod
    Public Function TestUserMod()
        Console.WriteLine("**********Testing Methods of UserMod**********")

        Console.WriteLine("LogIn() Test:")
        Dim user As New User
        user = LogIn("marley1", "222")
        user.Print()
    End Function
    Public Function LogIn(ByVal username, ByVal password)  'return an User object with fields 0 and "" if the login was unsuccessfull else return it with all the logged user's info
        Dim args() As String = {username, password}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("select * from Users where username=@0 and password=@1", args, results)

        Dim loggedUser As New User

        If (results.Rows.Count.Equals(0)) Then
            Console.WriteLine("Wrong Creds")
            loggedUser.Id = 0
            loggedUser.First_name = ""
            loggedUser.Last_name = ""
            loggedUser.Email = ""
            loggedUser.Username = ""
        Else
            Console.WriteLine("Correct Creds")
            loggedUser.Id = results.Rows(0)("id").ToString
            loggedUser.First_name = results.Rows(0)("first_name").ToString
            loggedUser.Last_name = results.Rows(0)("last_name").ToString
            loggedUser.Email = results.Rows(0)("email").ToString
            loggedUser.Username = results.Rows(0)("username").ToString
        End If

        Return loggedUser
    End Function
End Module
