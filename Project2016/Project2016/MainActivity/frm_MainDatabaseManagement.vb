Public Class frm_MainDatabaseManagement
    Private Sub btFoodCategory_Click(sender As Object, e As EventArgs) Handles btFoodCategory.Click
        frm_FoodType.Show()
    End Sub

    Private Sub btFoodGroup_Click(sender As Object, e As EventArgs) Handles btFoodGroup.Click
        frm_FoodGroup.Show()
    End Sub

    Private Sub btFood_Click(sender As Object, e As EventArgs) Handles btFood.Click
        frm_Food.Show()
    End Sub

    Private Sub btBoattype_Click(sender As Object, e As EventArgs) Handles btBoattype.Click
        frm_BoatType.Show()
    End Sub

    Private Sub btBoat_Click(sender As Object, e As EventArgs) Handles btBoat.Click
        frm_Boat.Show()
    End Sub

    Private Sub btEmployee_Click(sender As Object, e As EventArgs) Handles btEmployee.Click
        frm_Employee.Show()
    End Sub

    Private Sub btUnit_Click(sender As Object, e As EventArgs) Handles btUnit.Click
        frm_Unit.Show()
    End Sub

    Private Sub btUser_Click(sender As Object, e As EventArgs) Handles btUser.Click
        frm_User.Show()
    End Sub

    Private Sub btRateExchange_Click(sender As Object, e As EventArgs) Handles btRateExchange.Click
        frm_RateExchange.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim confirm As String = MessageBox.Show("ຕ້ອງການທີ່ຈະອອກແທ້ບໍ?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (confirm = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class