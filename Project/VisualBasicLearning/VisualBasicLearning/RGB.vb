Public Class RGB

    Private Sub DisplayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayButton.Click
        Dim r, g, b As Integer

        r = RTextBox.Text
        g = GTextBox.Text
        b = BTextBox.Text
        Me.BackColor = Color.FromArgb(r, g, b)


    End Sub

 
End Class