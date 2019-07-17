Public Class StringFunction

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1 As String
        s1 = "Visual Basic"
        OutputLabel.Text = Microsoft.VisualBasic.LCase(s1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s1 As String
        s1 = "   MS Dhoni   "

        OutputLabel.Text = Microsoft.VisualBasic.LTrim(s1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        OutputLabel.Text = Math.Round(23.258, 2)

    End Sub
End Class