Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CustomerManagementForm
    Private connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"

    ' Load all customers and their sales when the form loads
    Private Sub CustomerManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        LoadAllCustomers()
        LoadRecentSales()
    End Sub

    ' Load all customers into DataGridView
    Private Sub LoadAllCustomers()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT CustomerID, CustomerName, CustomerPhone, CustomerEmail, CustomerAddress FROM Customers"
                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvCustomerDetails.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    ' Load recent sales into DataGridView with proper table references
    Private Sub LoadRecentSales()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT s.SaleID, s.CustomerID, c.CustomerName, s.SaleDate, s.TotalAmount, " &
                                   "s.PaymentStatus, p.PaymentDate, p.PaymentMode, " &
                                   "STUFF((SELECT ', ' + pr.ProductName " &
                                   "       FROM SalesDetails sd " &
                                   "       JOIN Products pr ON sd.ProductID = pr.ProductID " &
                                   "       WHERE sd.SaleID = s.SaleID " &
                                   "       FOR XML PATH('')), 1, 2, '') AS Products " &
                                   "FROM Sales s " &
                                   "INNER JOIN Customers c ON s.CustomerID = c.CustomerID " &
                                   "LEFT JOIN Payments p ON s.SaleID = p.SaleID " &
                                   "ORDER BY s.SaleDate DESC"
                Using adapter As New SqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvCustomerSales.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message)
        End Try
    End Sub

    ' Add a new customer with validations
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If Not ValidateCustomerInputs() Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if phone number already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Customers WHERE CustomerPhone = @Phone"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text.Trim())
                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("A customer with this phone number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtCustomerPhone.Focus()
                        Return
                    End If
                End Using

                Dim query As String = "INSERT INTO Customers (CustomerName, CustomerPhone, CustomerEmail, CustomerAddress) VALUES (@Name, @Phone, @Email, @Address)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error adding customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Update selected customer with validations
    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) Then
            MessageBox.Show("Please select a customer to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not ValidateCustomerInputs() Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if phone number already exists for other customers
                Dim checkQuery As String = "SELECT COUNT(*) FROM Customers WHERE CustomerPhone = @Phone AND CustomerID <> @ID"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text.Trim())
                    checkCmd.Parameters.AddWithValue("@ID", txtCustomerID.Text)
                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Another customer with this phone number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtCustomerPhone.Focus()
                        Return
                    End If
                End Using

                Dim query As String = "UPDATE Customers SET CustomerName=@Name, CustomerPhone=@Phone, CustomerEmail=@Email, CustomerAddress=@Address WHERE CustomerID=@ID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text)
                    cmd.Parameters.AddWithValue("@Name", txtCustomerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' View detailed sales history (replacing the delete button functionality)
    Private Sub btnDetailedSales_Click(sender As Object, e As EventArgs) Handles btnDetailedSales.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) Then
            MessageBox.Show("Please select a customer to view detailed sales history.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Load detailed sales for the selected customer
            LoadDetailedCustomerSales(txtCustomerID.Text)

            ' Show summary information
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim summaryQuery As String = "SELECT COUNT(SaleID) AS TotalSales, " &
                                           "SUM(TotalAmount) AS TotalSpent, " &
                                           "MAX(SaleDate) AS LastPurchase " &
                                           "FROM Sales WHERE CustomerID=@ID"
                Using cmd As New SqlCommand(summaryQuery, conn)
                    cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim totalSales As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            Dim totalSpent As Decimal = If(reader.IsDBNull(1), 0, reader.GetDecimal(1))
                            Dim lastPurchase As String = If(reader.IsDBNull(2), "No purchases yet", reader.GetDateTime(2).ToString("dd/MM/yyyy"))

                            MessageBox.Show($"Customer Summary:{Environment.NewLine}" &
                                          $"Total Sales: {totalSales}{Environment.NewLine}" &
                                          $"Total Amount Spent: ₹{totalSpent:N2}{Environment.NewLine}" &
                                          $"Last Purchase Date: {lastPurchase}",
                                          "Customer Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading detailed sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Clear button click event
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Populate textboxes when a customer is clicked
    Private Sub dgvCustomerDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerDetails.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvCustomerDetails.Rows(e.RowIndex)

                txtCustomerID.Text = row.Cells("CustomerID").Value.ToString()
                txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
                txtCustomerPhone.Text = If(row.Cells("CustomerPhone").Value IsNot DBNull.Value, row.Cells("CustomerPhone").Value.ToString(), "")
                txtCustomerEmail.Text = If(row.Cells("CustomerEmail").Value IsNot DBNull.Value, row.Cells("CustomerEmail").Value.ToString(), "")
                txtCustomerAddress.Text = If(row.Cells("CustomerAddress").Value IsNot DBNull.Value, row.Cells("CustomerAddress").Value.ToString(), "")

                ' Load Sales for selected customer
                LoadCustomerSales(txtCustomerID.Text)

            Catch ex As Exception
                MessageBox.Show("Error selecting customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Load sales for selected customer with detailed information using correct table names
    Private Sub LoadCustomerSales(customerID As String)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT s.SaleID, s.SaleDate, s.TotalAmount, s.PaymentStatus, " &
                                   "p.PaymentDate, p.PaymentMode, p.BankName, " &
                                   "STUFF((SELECT ', ' + pr.ProductName " &
                                   "       FROM SalesDetails sd " &
                                   "       JOIN Products pr ON sd.ProductID = pr.ProductID " &
                                   "       WHERE sd.SaleID = s.SaleID " &
                                   "       FOR XML PATH('')), 1, 2, '') AS Products " &
                                   "FROM Sales s " &
                                   "LEFT JOIN Payments p ON s.SaleID = p.SaleID " &
                                   "WHERE s.CustomerID=@ID " &
                                   "ORDER BY s.SaleDate DESC"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", customerID)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvCustomerSales.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customer sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load detailed sales with product details and quantities
    Private Sub LoadDetailedCustomerSales(customerID As String)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT s.SaleID, s.SaleDate, s.TotalAmount, s.PaymentStatus, " &
                                   "p.PaymentDate, p.PaymentMode, " &
                                   "pr.ProductName, sd.Quantity, sd.Price, (sd.Quantity * sd.Price) AS ItemTotal " &
                                   "FROM Sales s " &
                                   "LEFT JOIN Payments p ON s.SaleID = p.SaleID " &
                                   "JOIN SalesDetails sd ON s.SaleID = sd.SaleID " &
                                   "JOIN Products pr ON sd.ProductID = pr.ProductID " &
                                   "WHERE s.CustomerID=@ID " &
                                   "ORDER BY s.SaleDate DESC, s.SaleID, pr.ProductName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", customerID)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvCustomerSales.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading detailed sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Export customer data to CSV
    Private Sub btnExportCustomer_Click(sender As Object, e As EventArgs) Handles btnExportCustomer.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) Then
            MessageBox.Show("Please select a customer to export their data.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
            saveFileDialog.Title = "Export Customer Data"
            saveFileDialog.FileName = "Customer_" & txtCustomerID.Text & "_" & DateTime.Now.ToString("yyyyMMdd")

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(saveFileDialog.FileName)
                    ' Write customer details
                    writer.WriteLine("Customer Details")
                    writer.WriteLine("ID,Name,Phone,Email,Address")
                    writer.WriteLine($"{txtCustomerID.Text},""{txtCustomerName.Text}"",""{txtCustomerPhone.Text}"",""{txtCustomerEmail.Text}"",""{txtCustomerAddress.Text}""")
                    writer.WriteLine()

                    ' Write sales details
                    writer.WriteLine("Sales History")
                    writer.WriteLine("SaleID,SaleDate,TotalAmount,PaymentStatus,PaymentDate,PaymentMode,Products")

                    ' Get the data from the DataGridView
                    Dim dt As DataTable = DirectCast(dgvCustomerSales.DataSource, DataTable)
                    For Each row As DataRow In dt.Rows
                        Dim saleID = row("SaleID").ToString()
                        Dim saleDate = If(row("SaleDate") IsNot DBNull.Value, Convert.ToDateTime(row("SaleDate")).ToString("yyyy-MM-dd"), "")
                        Dim totalAmount = row("TotalAmount").ToString()
                        Dim paymentStatus = row("PaymentStatus").ToString()
                        Dim paymentDate = If(row("PaymentDate") IsNot DBNull.Value, Convert.ToDateTime(row("PaymentDate")).ToString("yyyy-MM-dd"), "")
                        Dim paymentMode = If(row("PaymentMode") IsNot DBNull.Value, row("PaymentMode").ToString(), "")
                        Dim products = If(row("Products") IsNot DBNull.Value, row("Products").ToString(), "")

                        writer.WriteLine($"{saleID},{saleDate},{totalAmount},""{paymentStatus}"",{paymentDate},""{paymentMode}"",""{products}""")
                    Next
                End Using

                MessageBox.Show("Customer data exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting customer data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Validate customer input fields
    Private Function ValidateCustomerInputs() As Boolean
        ' Validate Customer Name
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Customer Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return False
        ElseIf txtCustomerName.Text.Trim().Length < 3 Then
            MessageBox.Show("Customer Name must be at least 3 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return False
        ElseIf txtCustomerName.Text.Trim().Length > 50 Then
            MessageBox.Show("Customer Name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return False
        End If

        ' Validate Phone Number (allow only digits and proper length)
        If String.IsNullOrWhiteSpace(txtCustomerPhone.Text) Then
            MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Return False
        ElseIf Not Regex.IsMatch(txtCustomerPhone.Text.Trim(), "^[0-9]{10}$") Then
            MessageBox.Show("Phone Number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Return False
        End If

        ' Validate Email if provided
        If Not String.IsNullOrWhiteSpace(txtCustomerEmail.Text) Then
            If Not Regex.IsMatch(txtCustomerEmail.Text.Trim(), "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
                MessageBox.Show("Invalid Email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCustomerEmail.Focus()

                Return False
            ElseIf txtCustomerEmail.Text.Trim().Length > 100 Then
                MessageBox.Show("Email cannot exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCustomerEmail.Focus()
                Return False
            End If
        End If

        ' Validate Address if provided
        If Not String.IsNullOrWhiteSpace(txtCustomerAddress.Text) AndAlso txtCustomerAddress.Text.Trim().Length > 200 Then
            MessageBox.Show("Address cannot exceed 200 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerAddress.Focus()
            Return False
        End If

        Return True
    End Function

    ' Clear input fields
    Private Sub ClearFields()
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtCustomerPhone.Clear()
        txtCustomerEmail.Clear()
        txtCustomerAddress.Clear()
        txtCustomerName.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logout As New AdminDashboard()
        logout.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Labeldate.Text = DateTime.Now.ToString("dd/MM/yyyy ")
        Labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class