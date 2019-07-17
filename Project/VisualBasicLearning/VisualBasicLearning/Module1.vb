Imports System.Data.SqlClient

Module Module1

    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Employee.mdf;Integrated Security=True;User Instance=True")
    Public q1Var, q2Var As String
End Module
