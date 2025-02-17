Imports System.Data.SqlClient
Imports System.Drawing.Imaging
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
        LoadProducts()
    End Sub

    ' Initialize Billing Table
    Private Sub InitializeBillingTable()
        billingTable.Columns.Add("ProductID", GetType(Integer))
        billingTable.Columns.Add("ProductName", GetType(String))
        billingTable.Columns.Add("Category", GetType(String))
        billingTable.Columns.Add("Price", GetType(Decimal))
        billingTable.Columns.Add("Quantity", GetType(Integer))
        billingTable.Columns.Add("Total", GetType(Decimal))
        billingTable.Columns.Add("BatchID", GetType(String)) ' Add BatchID column
        dgvBilling.DataSource = billingTable
    End Sub

    ' Load Products
    Private Sub LoadProducts()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductID, P.ProductName, C.CategoryName, P.Price, P.StockQuantity AS AvailableStock, P.ProductPhoto, S.BatchID 
                                       FROM Products P 
                                       INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                       LEFT JOIN Stock S ON P.ProductID = S.ProductID" ' Join with Stock to get BatchID
                Dim cmd As New SqlCommand(query, conn)
                cmd.CommandTimeout = 120

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim table As New DataTable()
                    table.Load(reader)
                    dgvProducts.DataSource = table
                Else
                    dgvProducts.DataSource = Nothing
                    MessageBox.Show("No products found.")
                End If
            End Using
        Catch ex As SqlException When ex.Number = -2 ' SQL Server timeout error number
            MessageBox.Show("Error loading products: Execution Timeout Expired. The timeout period elapsed prior to completion of the operation or the server is not responding", "Timeout Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Search Product
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT P.ProductID, P.ProductName, C.CategoryName, P.Price, P.StockQuantity AS AvailableStock, P.ProductPhoto, S.BatchID 
                                       FROM Products P 
                                       INNER JOIN Categories C ON P.CategoryId = C.CategoryId
                                       LEFT JOIN Stock S ON P.ProductID = S.ProductID
                                       WHERE P.ProductName LIKE @SearchText"
                Dim cmd As New SqlCommand(query, conn)
                cmd.CommandTimeout = 120

                cmd.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim table As New DataTable()
                    table.Load(reader)
                    dgvProducts.DataSource = table
                Else
                    dgvProducts.DataSource = Nothing
                    MessageBox.Show("No products found.")
                End If
            End Using
        Catch ex As SqlException When ex.Number = -2 ' SQL Server timeout error number
            MessageBox.Show("Error searching products: Execution Timeout Expired. The timeout period elapsed prior to completion of the operation or the server is not responding", "Timeout Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error searching products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Product selection
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = row.Cells("CategoryName").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtAvailableStock.Text = row.Cells("AvailableStock").Value.ToString()

            Dim productPhoto As Byte() = If(row.Cells("ProductPhoto").Value IsNot DBNull.Value, CType(row.Cells("ProductPhoto").Value, Byte()), Nothing)
            If productPhoto IsNot Nothing AndAlso productPhoto.Length > 0 Then
                Using ms As New MemoryStream(productPhoto)
                    PictureBoxProduct.Image = Image.FromStream(ms)
                End Using
            Else
                PictureBoxProduct.Image = Nothing
            End If

            ' Store the BatchID in a hidden field
            txtBatchID.Text = row.Cells("BatchID").Value.ToString()
        End If
    End Sub

    ' Add to bill
    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to add to the bill.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim productId As Integer = Integer.Parse(dgvProducts.SelectedRows(0).Cells("ProductID").Value.ToString())
        Dim productName As String = txtProductName.Text
        Dim category As String = txtCategory.Text
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        Dim availableStock As Integer = Integer.Parse(txtAvailableStock.Text)
        Dim quantity As Integer = Integer.Parse(numericQuantity.Value.ToString())
        Dim total As Decimal = price * quantity
        Dim batchID As String = txtBatchID.Text ' Get BatchID from hidden field

        If quantity > availableStock Then
            MessageBox.Show($"Not enough stock available. Available: {availableStock}, Requested: {quantity}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the product is already in the billing table
        Dim existingRow As DataRow = billingTable.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Integer)("ProductID") = productId)
        If existingRow IsNot Nothing Then
            existingRow("Quantity") += quantity
            existingRow("Total") = existingRow.Field(Of Decimal)("Quantity") * existingRow.Field(Of Decimal)("Price")
        Else
            billingTable.Rows.Add(productId, productName, category, price, quantity, total, batchID)
        End If

        ' Refresh the DataGridView
        dgvBilling.DataSource = Nothing
        dgvBilling.DataSource = billingTable
    End Sub

    ' Generate total
    Private Sub btnGenerateTotal_Click(sender As Object, e As EventArgs) Handles btnGenerateTotal.Click
        Dim totalAmount As Decimal = billingTable.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("Total"))
        MessageBox.Show("Total Amount: " & totalAmount.ToString("C2"))
    End Sub

    ' Proceed to bill
    Private Sub btnProceedToBill_Click(sender As Object, e As EventArgs) Handles btnProceedToBill.Click
        Dim billForm As New BillForm(billingTable, userId)
        billForm.Show()
        Me.Close()
    End Sub
End Class