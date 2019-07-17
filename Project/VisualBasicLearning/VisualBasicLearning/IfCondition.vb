Public Class IfCondition

    Private Sub CheckButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckButton.Click

        Dim user As String

        user = UserNameTextBox.Text
        If user = "admin" Then
            MsgBox("Welcome Admin!")
        ElseIf UserNameTextBox.Text = "" Then
            MsgBox("Please Enter User Name")
        Else
            MsgBox(" Invalid User ")
        End If

    End Sub
End Class