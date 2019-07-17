Public Class CaseConditon

  
    Private Sub Calcu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcu.Click
        Dim marks As Integer
        marks = AgeTextBox.Text

        Select Case marks
            Case 90 To 100
                ResultTextBox.Text = "High Distinction"
            Case 75 To 89
                ResultTextBox.Text = "Distinction"
            Case 60 To 74
                ResultTextBox.Text = "First Class"
            Case 35 To 59
                ResultTextBox.Text = "Second Clas"
            Case 0 To 34
                ResultTextBox.Text = "Fail"
            Case Else
                ResultTextBox.Text = "Invalid"
        End Select
    End Sub
End Class