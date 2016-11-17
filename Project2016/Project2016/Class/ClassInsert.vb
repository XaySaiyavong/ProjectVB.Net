Imports System.Data.SqlClient
Public Class ClassInsert
    Function Insert(ByVal sqlInsertCommand As String, ByVal Connection As SqlConnection) As String
        Dim cm As New SqlCommand(sqlInsertCommand, Connection)
        cm.ExecuteNonQuery()
        Return 0
    End Function
End Class
