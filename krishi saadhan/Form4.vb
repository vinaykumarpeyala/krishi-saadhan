Imports System.Data.SqlClient
Imports System.IO

Public Class SellerDashboard
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"
    Dim billingTable As New DataTable()
    Private userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        Me.userId = userId
    End Sub

    Private Sub SellerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeBillingTable()
        Timer1.Enabled = True
        LoadProducts()
    End Sub

    Private Sub UpdateStockDisplay()
        LoadProducts()  ' Refresh product grid after changes
    End Sub

    Private Function ValidateStock(productId As Integer, requestedQuantity As Integer) As Boolean
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT StockQuantity FROM Products WHERE ProductID = @ProductID"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductID", productId)
                Dim currentStock As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return currentStock >= requestedQuantity
            End Using
        End Using
    End Function

    Private Sub InitializeBillingTable()
        billingTable.Columns.Add("ProductID", GetType(Integer))
        billingTable.Columns.Add("ProductName", GetType(String))
        billingTable.Columns.Add("Category", GetType(String))
        billingTable.Columns.Add("Price", GetType(Decimal))
        billingTable.Columns.Add("Quantity", GetType(Integer))
        billingTable.Columns.Add("Total", GetType(Decimal))
        billingTable.Columns.Add("BatchID", GetType(String))
        dgvBilling.DataSource = billingTable
    End Sub

    Private Sub LoadProducts()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductID, P.ProductName, C.CategoryName, P.Price, P.StockQuantity AS AvailableStock, P.ProductPhoto, S.BatchID 
                                     FROM Products P 
                                     INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                     LEFT JOIN Stock S ON P.ProductID = S.ProductID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.CommandTimeout = 120
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim table As New DataTable()
                        table.Load(reader)
                        dgvProducts.DataSource = table
                        FormatProductsGrid()
                    Else
                        MessageBox.Show("No products found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatProductsGrid()
        With dgvProducts
            .Columns("ProductID").Width = 80
            .Columns("ProductName").Width = 150
            .Columns("CategoryName").Width = 100
            .Columns("Price").Width = 80
            .Columns("Price").DefaultCellStyle.Format = "C2"
            .Columns("AvailableStock").Width = 80
            .Columns("BatchID").Width = 100
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductID, P.ProductName, C.CategoryName, P.Price, P.StockQuantity AS AvailableStock, P.ProductPhoto, S.BatchID 
                                     FROM Products P 
                                     INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                     LEFT JOIN Stock S ON P.ProductID = S.ProductID
                                     WHERE P.ProductName LIKE @SearchText OR C.CategoryName LIKE @SearchText"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim table As New DataTable()
                        table.Load(reader)
                        dgvProducts.DataSource = table
                        FormatProductsGrid()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = row.Cells("CategoryName").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtAvailableStock.Text = row.Cells("AvailableStock").Value.ToString()
            txtBatchID.Text = row.Cells("BatchID").Value.ToString()

            ' Load product image if available
            Dim productPhoto As Byte() = If(row.Cells("ProductPhoto").Value IsNot DBNull.Value,
                                          CType(row.Cells("ProductPhoto").Value, Byte()), Nothing)
            If productPhoto IsNot Nothing AndAlso productPhoto.Length > 0 Then
                Using ms As New MemoryStream(productPhoto)
                    PictureBoxProduct.Image = Image.FromStream(ms)
                End Using
            Else
                PictureBoxProduct.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim productId As Integer = Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("ProductID").Value)
        Dim productName As String = txtProductName.Text
        Dim category As String = txtCategory.Text
        Dim price As Decimal
        Dim quantity As Integer = Convert.ToInt32(numericQuantity.Value)
        Dim availableStock As Integer = Convert.ToInt32(txtAvailableStock.Text)
        Dim batchID As String = txtBatchID.Text

        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Invalid price format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If quantity > availableStock Then
            MessageBox.Show($"Not enough stock available. Available: {availableStock}, Requested: {quantity}",
                          "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim total As Decimal = price * quantity

        ' Check if product already exists in billing table
        Dim existingRow As DataRow = billingTable.AsEnumerable().
            FirstOrDefault(Function(row) row.Field(Of Integer)("ProductID") = productId)

        If existingRow IsNot Nothing Then
            Dim newQuantity As Integer = existingRow.Field(Of Integer)("Quantity") + quantity
            If newQuantity > availableStock Then
                MessageBox.Show($"Total quantity ({newQuantity}) exceeds available stock ({availableStock})",
                              "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            existingRow("Quantity") = newQuantity
            existingRow("Total") = price * newQuantity
        Else
            billingTable.Rows.Add(productId, productName, category, price, quantity, total, batchID)
        End If

        ' Reset quantity
        numericQuantity.Value = 1

        ' Refresh the billing grid
        dgvBilling.DataSource = Nothing
        dgvBilling.DataSource = billingTable
        FormatBillingGrid()

        ' Calculate and display subtotal
        UpdateSubtotal()
    End Sub

    Private Sub FormatBillingGrid()
        With dgvBilling
            .Columns("ProductID").Visible = False
            .Columns("BatchID").Visible = False
            .Columns("ProductName").Width = 150
            .Columns("Category").Width = 100
            .Columns("Price").Width = 80
            .Columns("Price").DefaultCellStyle.Format = "C2"
            .Columns("Quantity").Width = 80
            .Columns("Total").Width = 100
            .Columns("Total").DefaultCellStyle.Format = "C2"
        End With
    End Sub

    Private Sub UpdateSubtotal()
        Dim subtotal As Decimal = billingTable.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("Total"))
        lblSubtotal.Text = $"Subtotal: {subtotal:C2}"
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If dgvBilling.SelectedRows.Count > 0 Then
            dgvBilling.Rows.RemoveAt(dgvBilling.SelectedRows(0).Index)
            UpdateSubtotal()
        End If
    End Sub

    Private Sub btnClearBill_Click(sender As Object, e As EventArgs) Handles btnClearBill.Click
        If billingTable.Rows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to clear the entire bill?", "Confirm Clear",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                billingTable.Rows.Clear()
                UpdateSubtotal()
            End If
        End If
    End Sub

    Private Sub btnProceedToBill_Click(sender As Object, e As EventArgs) Handles btnProceedToBill.Click
        If billingTable.Rows.Count = 0 Then
            MessageBox.Show("Please add items to the bill first.", "Empty Bill",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' First show BillForm
        Dim billForm As New BillForm(billingTable, userId)
        If billForm.ShowDialog() = DialogResult.OK Then
            ' Clear billing table only if payment was successful
            billingTable.Clear()
            UpdateSubtotal()
        End If
    End Sub

    Private Sub SellerDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If billingTable.Rows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show(
                "There are items in the current bill. Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Labeldate.Text = DateTime.Now.ToString("dd/MM/yyyy ")
        Labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class