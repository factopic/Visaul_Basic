Public Class IfConditon2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcu.Click
        Dim marks As String
        Dim grade As String
        grade = ""


        marks = MarksTextBox.Text


        If MarksTextBox.Text = "" Then
            MsgBox(" Invaid Input ")
        ElseIf marks <= 100 And marks >= 90 Then
            grade = "A+"
        ElseIf marks <= 89 And marks >= 75 Then
            grade = "A"
        ElseIf marks <= 74 And marks >= 60 Then
            grade = "B"
        ElseIf marks <= 59 And marks >= 35 Then
            grade = "C"
        ElseIf marks < 35 Then
            grade = "D"
        Else
            MsgBox("The marks  Invalid Input")

        End If

        GradeTextBox.Text = grade



        Select Case grade
            Case "A+"
                ClassTextBox.Text = "High Distinction"
            Case "A"
                ClassTextBox.Text = "Distinction"
            Case "B"
                ClassTextBox.Text = "First Class"
            Case "C"
                ClassTextBox.Text = "Second Class"
            Case "D"
                ClassTextBox.Text = "Fail"
            Case Else
                MsgBox("Invalid Input")
        End Select







    End Sub


 
End Class