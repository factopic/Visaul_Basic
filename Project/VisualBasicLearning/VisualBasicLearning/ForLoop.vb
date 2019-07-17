Public Class ForLoop

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim count As String
        count = 0

        Do Until count >= 10
            ListBox1.Items.Add(count)
            ' MsgBox(count)
            count = count + 1
        Loop





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern1Button.Click
        Dim st As String
        st = ""
        ListBox1.Items.Clear()

        For i = 0 To 5
            For j = 0 To 5
                st = st + "* "
            Next
            ListBox1.Items.Add(st)
            st = ""
        Next


    End Sub

    Private Sub Pattern2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern2Button.Click

        Dim st As String
        st = ""
        ListBox1.Items.Clear()

        For i = 0 To 5
            For j = 0 To 5
                If i <= j Then
                    st = st + "* "
                End If

            Next
            ListBox1.Items.Add(st)
            st = ""
        Next

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern3Button.Click
        Dim st As String
        st = ""
        ListBox1.Items.Clear()

        For i = 0 To 5
            For j = 0 To 5
                If i = j Then
                    st = st + "* "
                End If

            Next
            ListBox1.Items.Add(st)
            st = ""
        Next
    End Sub

    Private Sub Pattern4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pattern4Button.Click

        Dim st As String
        st = ""
        ListBox1.Items.Clear()

        For i = 0 To 5
            For j = 0 To 5
                If i >= j Then
                    st = st + "* "
                End If

            Next
            ListBox1.Items.Add(st)
            st = ""
        Next

    End Sub
End Class