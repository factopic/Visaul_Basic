Public Class WebBrowser

   
 

    Private Sub WebBrowser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SearchTextBox.Text = "Search here"
        WebBrowser1.Navigate("www.google.com")
    End Sub



    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        WebBrowser1.GoBack()
    End Sub



    Private Sub Forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshButton.Click
        WebBrowser1.Refresh()

    End Sub

  
    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        WebBrowser1.Navigate(SearchTextBox.Text)
    End Sub

  
End Class