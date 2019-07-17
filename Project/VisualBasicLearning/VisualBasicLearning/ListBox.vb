Public Class ListBox

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim items As String
        items = ItemTextBox.Text
        ListBox1.Items.Add(items)
        ItemTextBox.Text = ""
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ListBox1.Items.Clear()

    End Sub
End Class