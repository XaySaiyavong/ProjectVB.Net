Imports System.Data.SqlClient
Public Class classDatabaseConnection
    Function DatabaseConnection(ByVal connectionString As String) As SqlConnection
        Dim constr = connectionString
        Dim cn = New SqlConnection(constr)
        cn.Open()
        Return cn
    End Function
End Class