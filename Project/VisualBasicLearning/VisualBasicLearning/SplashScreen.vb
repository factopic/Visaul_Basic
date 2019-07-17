Public Class SplashScreen
    Dim I As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If I > 5 Then
            Timer1.Enabled = False
            Me.Hide()
            LoginTab.Show()
        End If
        I = I + 1

    End Sub
End Class