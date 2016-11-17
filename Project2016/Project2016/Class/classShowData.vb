Imports System.Data.SqlClient
Public Class classShowData
    Function ShowData(ByVal sqlSelectCommand As String, ByVal connection As SqlConnection, ByVal dataGridViewName As DataGridView)
        Dim ds As New DataSet
        Dim cm As New SqlCommand(sqlSelectCommand, connection)
        Dim da As New SqlDataAdapter(cm)
        ds.Clear()
        da.Fill(ds)
        With dataGridViewName
            .DataSource = ds.Tables(0)
        End With
        Return 0
    End Function
End Class
