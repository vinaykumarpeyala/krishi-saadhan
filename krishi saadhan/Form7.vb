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

    ' Delete selected customer
    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) Then
            MessageBox.Show("Please select a customer to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm before deleting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Check if customer has sales
                Dim checkQuery As String = "SELECT COUNT(*) FROM Sales WHERE CustomerID=@ID"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@ID", txtCustomerID.Text)
                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Cannot delete customer with existing sales. Please delete the sales first.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Delete customer
                Dim query As String = "DELETE FROM Customers WHERE CustomerID=@ID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAllCustomers()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    ' Validate customer input fields
    Private Function ValidateCustomerInputs() As Boolean
        ' Validate Customer Name
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Customer Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return False
        End If

        ' Validate Phone Number (allow only digits and proper length)
        If String.IsNullOrWhiteSpace(txtCustomerPhone.Text) Then
            MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Return False
        ElseIf Not Regex.IsMatch(txtCustomerPhone.Text.Trim(), "^[0-9]{10}$") Then
            MessageBox.Show("Phone Number must be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerPhone.Focus()
            Return False
        End If

        ' Validate Email if provided
        If Not String.IsNullOrWhiteSpace(txtCustomerEmail.Text) AndAlso
           Not Regex.IsMatch(txtCustomerEmail.Text.Trim(), "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Invalid Email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerEmail.Focus()
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