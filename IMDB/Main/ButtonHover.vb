Module ButtonHover
    Public Sub btnEnter(P As Panel)
        P.BackgroundImage = My.Resources.GeneralBtn2
    End Sub
    Public Sub btnLeave(P As Panel)
        P.BackgroundImage = My.Resources.GeneralBtn1
    End Sub
End Module
