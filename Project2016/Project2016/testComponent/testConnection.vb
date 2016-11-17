Imports System.Data.SqlClient
Public Class testConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionRoute As classDatabaseConnection = New classDatabaseConnection
        Dim constr As String = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True"
        If (connectionRoute.DatabaseConnection(constr).State = ConnectionState.Open) Then
            MessageBox.Show("Successful")
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub testConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class