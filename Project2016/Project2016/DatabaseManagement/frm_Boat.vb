Public Class frm_Boat
    Dim constr As String = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True"
    Dim connect As classDatabaseConnection = New classDatabaseConnection
    Dim sql As String
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        sql = "INSERT INTO tb_boat(boatID, boatTypeID, Boatname, boatStatus) values('" & txtBoatID.Text & "','" & txtBoatType.Text & "','" & txtBoatName.Text & "','" & txtBoatStatus.Text & "')"
        Dim save As ClassInsert = New ClassInsert
        save.Insert(sql, connect.DatabaseConnection(constr))
    End Sub

    Private Sub frm_Boat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM tb_boat"
        Dim selectData As classShowData = New classShowData
        selectData.ShowData(sql, connect.DatabaseConnection(constr), dgvBoat)
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        sql = "UPDATE tb_boat SET boatType = '" & txtBoatType.Text & "', boatName = '" & txtBoatName.Text & "', boatStatus = '" & txtBoatStatus.Text & "' Where boatID = '" & txtBoatID.Text & "'"
        Dim EditData As classUpdate = New classUpdate
        EditData.Update(sql, connect.DatabaseConnection(constr))
    End Sub
End Class