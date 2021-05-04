Module SearchClass
    Public Sub SearchLoad(Panel As Panel, array() As Movie)
        Dim PosY = 0
        Dim s As String
        Panel.Height = array.Length * 20
        For index As Integer = 0 To array.Length - 1
            If array(index).Title.Length > 33 Then
                s = array(index).Title.Substring(0, 33) & "..."
            Else
                s = array(index).Title
            End If
            Dim label As New LinkLabel With {
                    .Size = New Size(200, 20),
                    .Text = s,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .Location = New Point(0, PosY),
                    .Cursor = Cursors.Hand,
                    .BorderStyle = BorderStyle.FixedSingle
            }


            Dim mv As Movie = array(index)
            AddHandler label.Click, Sub() AllMoviesCLick(mv)

            Panel.Controls.Add(label)
            PosY += 20
        Next
    End Sub

End Module
