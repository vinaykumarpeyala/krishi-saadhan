Imports System.Data.SqlClient

Public Class StockManagementForm
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"

    Private Sub StockManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductsAndStock()
        txtStockId.Visible = False
        lblStockId.Visible = False
    End Sub

    ' Load products and stock details into DataGridView
    Private Sub LoadProductsAndStock()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductId, P.ProductName, C.CategoryName, P.StockQuantity, S.StockId, S.BatchId, S.BatchQuantity, S.UnitPrice 
                                       FROM Products P 
                                       INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                       LEFT JOIN Stock S ON P.ProductId = S.ProductId"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table

                ' Apply color coding based on stock quantity
                ApplyColorCoding()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products and stock: " & ex.Message)
        End Try
    End Sub

    ' Apply color coding based on stock quantity
    Private Sub ApplyColorCoding()
        For Each row As DataGridViewRow In dgvProducts.Rows
            Dim stockQuantity As Integer = Convert.ToInt32(row.Cells("StockQuantity").Value)
            Select Case stockQuantity
                Case Is < 5
                    row.DefaultCellStyle.BackColor = Color.Red
                Case 5 To 20
                    row.DefaultCellStyle.BackColor = Color.Orange
                Case Is > 20
                    row.DefaultCellStyle.BackColor = Color.Green
            End Select
        Next
    End Sub

    ' DataGridView row selection
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductId.Text = row.Cells("ProductId").Value.ToString()
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            If row.Cells("BatchId").Value IsNot Nothing Then
                txtBatchId.Text = row.Cells("BatchId").Value.ToString()
            End If
            If row.Cells("BatchQuantity").Value IsNot Nothing Then
                txtBatchQuantity.Text = row.Cells("BatchQuantity").Value.ToString()
            End If
            If row.Cells("UnitPrice").Value IsNot Nothing Then
                txtUnitPrice.Text = row.Cells("UnitPrice").Value.ToString()
            End If
            If row.Cells("StockId").Value IsNot Nothing Then
                txtStockId.Text = row.Cells("StockId").Value.ToString()
            End If
        End If
    End Sub

    ' Add stock to the Stock table and update Products table
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Try
            Dim productId As Integer = Integer.Parse(txtProductId.Text.Trim())
            Dim batchId As String = txtBatchId.Text.Trim()
            Dim batchQuantity As Integer = Integer.Parse(txtBatchQuantity.Text.Trim())
            Dim unitPrice As Decimal = Decimal.Parse(txtUnitPrice.Text.Trim())

            If batchId = "" OrElse batchQuantity <= 0 OrElse unitPrice <= 0 Then
                MessageBox.Show("Please enter valid batch details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Stock (ProductId, BatchId, BatchQuantity, UnitPrice) VALUES (@ProductId, @BatchId, @BatchQuantity, @UnitPrice);
                                       UPDATE Products SET StockQuantity = StockQuantity + @BatchQuantity WHERE ProductId = @ProductId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductId", productId)
                    cmd.Parameters.AddWithValue("@BatchId", batchId)
                    cmd.Parameters.AddWithValue("@BatchQuantity", batchQuantity)
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show($"Stock added successfully! Batch Quantity {batchQuantity} has been added to the product's stock quantity.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataGridView() ' Refresh the products and stock list
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid input format. Please check your entries.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update stock details
    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        Try
            Dim stockId As Integer = Integer.Parse(txtStockId.Text.Trim())
            Dim productId As Integer = Integer.Parse(txtProductId.Text.Trim())
            Dim batchId As String = txtBatchId.Text.Trim()
            Dim newBatchQuantity As Integer = Integer.Parse(txtBatchQuantity.Text.Trim())
            Dim unitPrice As Decimal = Decimal.Parse(txtUnitPrice.Text.Trim())

            If stockId <= 0 OrElse batchId = "" OrElse newBatchQuantity <= 0 OrElse unitPrice <= 0 Then
                MessageBox.Show("Please enter valid stock details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Get the old batch quantity
                Dim oldBatchQuantity As Integer
                Dim selectQuery As String = "SELECT BatchQuantity FROM Stock WHERE StockId = @StockId"
                Using selectCmd As New SqlCommand(selectQuery, conn)
                    selectCmd.Parameters.AddWithValue("@StockId", stockId)
                    oldBatchQuantity = Convert.ToInt32(selectCmd.ExecuteScalar())
                End Using

                ' Update the stock details and the product's stock quantity
                Dim updateQuery As String = "UPDATE Stock SET BatchId = @BatchId, BatchQuantity = @BatchQuantity, UnitPrice = @UnitPrice WHERE StockId = @StockId;
                                             UPDATE Products SET StockQuantity = StockQuantity + @NewBatchQuantity - @OldBatchQuantity WHERE ProductId = @ProductId"
                Using updateCmd As New SqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@StockId", stockId)
                    updateCmd.Parameters.AddWithValue("@ProductId", productId)
                    updateCmd.Parameters.AddWithValue("@BatchId", batchId)
                    updateCmd.Parameters.AddWithValue("@BatchQuantity", newBatchQuantity)
                    updateCmd.Parameters.AddWithValue("@UnitPrice", unitPrice)
                    updateCmd.Parameters.AddWithValue("@NewBatchQuantity", newBatchQuantity)
                    updateCmd.Parameters.AddWithValue("@OldBatchQuantity", oldBatchQuantity)
                    updateCmd.ExecuteNonQuery()
                End Using
                MessageBox.Show($"Stock updated successfully! Batch Quantity has been updated from {oldBatchQuantity} to {newBatchQuantity}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataGridView() ' Refresh the products and stock list
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid input format. Please check your entries.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error updating stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete batch quantity from stock and update Products table
    Private Sub btnDeleteBatchQuantity_Click(sender As Object, e As EventArgs) Handles btnDeleteBatchQuantity.Click
        Try
            Dim stockId As Integer = Integer.Parse(txtStockId.Text.Trim())
            Dim batchQuantity As Integer = Integer.Parse(txtBatchQuantity.Text.Trim())

            If stockId <= 0 Then
                MessageBox.Show("Please enter a valid stock ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Products SET StockQuantity = StockQuantity - @BatchQuantity WHERE ProductId = (SELECT ProductId FROM Stock WHERE StockId = @StockId)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StockId", stockId)
                    cmd.Parameters.AddWithValue("@BatchQuantity", batchQuantity)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show($"Batch Quantity {batchQuantity} has been removed from the product's stock quantity.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataGridView() ' Refresh the products and stock list
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid input format. Please check your entries.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error deleting batch quantity: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Delete entire stock details
    Private Sub btnDeleteStock_Click(sender As Object, e As EventArgs) Handles btnDeleteStock.Click
        Try
            Dim stockId As Integer = Integer.Parse(txtStockId.Text.Trim())

            If stockId <= 0 Then
                MessageBox.Show("Please enter a valid stock ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM Stock WHERE StockId = @StockId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StockId", stockId)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Stock details deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataGridView() ' Refresh the products and stock list
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid input format. Please check your entries.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error deleting stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Refresh DataGridView
    Private Sub RefreshDataGridView()
        LoadProductsAndStock()
    End Sub

    ' Search functionality to filter products
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductId, P.ProductName, C.CategoryName, P.StockQuantity, S.StockId, S.BatchId, S.BatchQuantity, S.UnitPrice 
                                       FROM Products P 
                                       INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                       LEFT JOIN Stock S ON P.ProductId = S.ProductId
                                       WHERE P.ProductName LIKE @SearchText"
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table

                ' Apply color coding based on stock quantity
                ApplyColorCoding()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching products: " & ex.Message)
        End Try
    End Sub

    ' Check for low stock
    Private Sub btnCheckLowStock_Click(sender As Object, e As EventArgs) Handles btnCheckLowStock.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductId, P.ProductName, C.CategoryName, P.StockQuantity, S.StockId, S.BatchId, S.BatchQuantity, S.UnitPrice 
                                       FROM Products P 
                                       INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                       LEFT JOIN Stock S ON P.ProductId = S.ProductId
                                       WHERE P.StockQuantity < 10 
                                       ORDER BY P.StockQuantity ASC"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvProducts.DataSource = table

                ' Apply color coding based on stock quantity
                ApplyColorCoding()
            End Using
        Catch ex As FormatException
            MessageBox.Show("Invalid data format encountered. Please check the data.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Error checking low stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Return to homepage
    Private Sub btnReturnToHomePage_Click(sender As Object, e As EventArgs) Handles btnReturnToHomePage.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    ' Show txtStockId when Update or Delete is clicked
    Private Sub btnUpdateStock_MouseClick(sender As Object, e As MouseEventArgs) Handles btnUpdateStock.MouseClick
        txtStockId.Visible = True
        lblStockId.Visible = True
    End Sub

    Private Sub btnDeleteStock_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDeleteStock.MouseClick
        txtStockId.Visible = True
        lblStockId.Visible = True
    End Sub

    ' Hide txtStockId when other buttons are clicked
    Private Sub btnAddStock_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAddStock.MouseClick
        txtStockId.Visible = False
        lblStockId.Visible = False
    End Sub

    Private Sub btnCheckLowStock_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCheckLowStock.MouseClick
        txtStockId.Visible = False
        lblStockId.Visible = False
    End Sub

    Private Sub btnReturnToHomePage_MouseClick(sender As Object, e As MouseEventArgs) Handles btnReturnToHomePage.MouseClick
        txtStockId.Visible = False
        lblStockId.Visible = False
    End Sub

    ' Refresh DataGridView button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDataGridView()
    End Sub
End Class