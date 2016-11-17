Imports System.Data.SqlClient
Public Class classDelete
    Function Delete(ByVal sqlDeleteCommand As String, ByVal Connection As SqlConnection) As String
        Dim cm As New SqlCommand(sqlDeleteCommand, Connection)
        cm.ExecuteNonQuery()
        Return 0
    End Function
End Class
