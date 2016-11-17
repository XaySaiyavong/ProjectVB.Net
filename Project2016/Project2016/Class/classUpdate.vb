Imports System.Data.SqlClient
Public Class classUpdate
    Function Update(ByVal sqlUpdateCommand As String, ByVal connection As SqlConnection)
        Dim cm As New SqlCommand(sqlUpdateCommand, connection)
        cm.ExecuteNonQuery()
        Return 0
    End Function
End Class
