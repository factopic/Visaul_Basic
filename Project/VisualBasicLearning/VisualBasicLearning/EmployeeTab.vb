Imports System.Data.SqlClient

Public Class EmployeeTab

  

    Sub SaveRecord()


        If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()

            Dim Cmd0 As New SqlCommand("select * from emp where empid ='" & EmpIDTextBox.Text & "'", Conn)
            Dim D1 As SqlDataReader = Cmd0.ExecuteReader()

            If D1.HasRows Then
                MsgBox("This record is already present in DB")
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Exit Sub
            End If



        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Open()




            q1Var = "insert into emp ( Name , empId ,dept)"
            q2Var = "values('" & NameTextBox.Text & "', '" & EmpIDTextBox.Text & "','" & DeptTextBox.Text & "')"

            Dim Cmd1 As New SqlCommand(q1Var & q2Var, Conn)
            Cmd1.ExecuteNonQuery()

            If Conn.State = ConnectionState.Open Then Conn.Close()


    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        SaveRecord()

    End Sub
End Class