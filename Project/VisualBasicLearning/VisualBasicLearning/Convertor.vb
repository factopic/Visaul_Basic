Public Class Convertor

    Private Sub ConvertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertButton.Click
        Dim foot, cm As Decimal
        Dim multiple As Decimal
        multiple = 30.48
        foot = FootTextBox.Text
        cm = foot * multiple
        CmTextBox.Text = cm

    End Sub
End Class
