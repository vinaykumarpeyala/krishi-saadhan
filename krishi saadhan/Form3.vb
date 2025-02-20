Public Class AdminDashboard
    Private Sub ManageProducts_Click(sender As Object, e As EventArgs) Handles ManageProducts.Click
        Dim productForm As New ProductManagementForm()
        productForm.Show()  ' Open Product Management Form
    End Sub

    Private Sub ManageUsers_Click(sender As Object, e As EventArgs) Handles ManageUsers.Click
        Dim usermanagementform As New frmUserManagement()
        usermanagementform.Show()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ManageStock_Click(sender As Object, e As EventArgs) Handles ManageStock.Click
        Dim stockmanagement As New StockManagementForm()
        stockmanagement.Show()
    End Sub

    Private Sub btnManageCustomers_Click(sender As Object, e As EventArgs) Handles btnManageCustomers.Click
        Dim customermanagement As New CustomerManagementForm()
        customermanagement.Show()
    End Sub
End Class