Module SearchClass
    Public Sub SearchLoad(Panel As Panel, array() As Movie)
        Dim PosY = 0
        Panel.Height = array.Length * 20

        For Each movie In array
            Dim label As New LinkLabel With {
                    .Size = New Size(200, 20),
                    .Text = movie.Title,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .Location = New Point(0, PosY),
                    .Cursor = Cursors.Hand,
                    .BorderStyle = BorderStyle.FixedSingle,
                    .BackColor = Color.White,
                    .LinkColor = Color.Orange,
                    .Font = New Font("SimSun", "9.75"),
                    .AutoEllipsis = True
            }


            AddHandler label.Click, Sub() AllMoviesCLick(movie)

            Panel.Controls.Add(label)
            PosY += 20
        Next
    End Sub

End Module
