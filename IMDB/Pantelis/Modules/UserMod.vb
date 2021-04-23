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

    Public Function Register(ByVal first_name, ByVal last_name, ByVal username, ByVal email, ByVal password)
        Dim args() As String = {first_name, last_name, username, email, password}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("INSERT INTO `it185223`.`Users` (`first_name`, `last_name`,`email`,`username`,`password`) VALUES (@0, @1, @3, @2, @4);", args, results)


    End Function


    Public Function Username_exists(ByVal username)
        Dim args() As String = {username}
        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("Select * from Users where username=@0", args, results)
        If (results.Rows.Count.Equals(0)) Then
            Return False
        Else
            Return True
        End If



    End Function
    Public Function Email_exists(ByVal email)
        Dim args() As String = {email}
        Dim con As New Connection
        Dim results As New DataTable
        con.RunQuery("Select * from Users where email=@0", args, results)
        If (results.Rows.Count.Equals(0)) Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function UpdateUser(ByVal id, ByVal first_name, ByVal last_name, ByVal email)
        Dim args() As String = {id, first_name, last_name, email}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("update Users set first_name=@1, last_name=@2, email=@3 where id=@0", args, results)
    End Function

    Public Function UpdatePassword(ByVal id, ByVal password)
        Dim args() As String = {id, password}

        Dim con As New Connection
        Dim results As New DataTable

        con.RunQuery("update Users set password=@1 where id=@0", args, results)
    End Function
End Module
