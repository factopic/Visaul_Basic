Public Class LoginTab

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim userName, pwd As String

        userName = UserNameTextBox.Text
        pwd = pwdTextBox.Text

        If userName = "Rahul JayKar" And pwd = "123" Then
            Me.Hide()
            Home.Show()
        Else
            MsgBox("Invalid user or pwd")
        End If



    End Sub

    Private Sub RegisterLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterLabel.Click

    End Sub
End Class