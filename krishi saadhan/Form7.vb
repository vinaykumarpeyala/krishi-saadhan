Imports System.Data.SqlClient

Public Class CustomerManagementForm
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"
    Private currentCustomerID As Integer?

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub loaddetails()

    End Sub
    Private Sub CustomerManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial visibility
        dgvCustomerDetails.Visible = True
        dgvCustomerSales.Visible = True
    End Sub


    ' Search for customers by name
    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click
        Dim customerName As String = txtCustomerName.Text.Trim()
        If String.IsNullOrEmpty(customerName) Then
            MessageBox.Show("Please enter a customer name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT CustomerID, CustomerName, CustomerPhone, CustomerEmail, CustomerAddress FROM Customers WHERE CustomerName LIKE @CustomerName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerName", "%" & customerName & "%")
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            dgvCustomerDetails.DataSource = dt
                        Else
                            MessageBox.Show("No customers found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching for customer: " & ex.Message)
        End Try
    End Sub

    ' Add or update customer details
    Private Sub btnAddUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnAddUpdateCustomer.Click
        If Not ValidateCustomerDetails() Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                If currentCustomerID Is Nothing Then
                    ' Insert new customer
                    Dim insertQuery As String = "INSERT INTO Customers (CustomerName, CustomerPhone, CustomerEmail, CustomerAddress) OUTPUT INSERTED.CustomerID VALUES (@CustomerName, @CustomerPhone, @CustomerEmail, @CustomerAddress)"
                    Using cmd As New SqlCommand(insertQuery, conn)
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim())
                        cmd.Parameters.AddWithValue("@CustomerPhone", txtCustomerPhone.Text.Trim())
                        cmd.Parameters.AddWithValue("@CustomerEmail", If(String.IsNullOrEmpty(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text))
                        cmd.Parameters.AddWithValue("@CustomerAddress", If(String.IsNullOrEmpty(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text))
                        currentCustomerID = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                    MessageBox.Show("New customer added successfully.")
                Else
                    ' Update existing customer
                    Dim updateQuery As String = "UPDATE Customers SET CustomerName = @CustomerName, CustomerPhone = @CustomerPhone, CustomerEmail = @CustomerEmail, CustomerAddress = @CustomerAddress WHERE CustomerID = @CustomerID"
                    Using cmd As New SqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim())
                        cmd.Parameters.AddWithValue("@CustomerPhone", txtCustomerPhone.Text.Trim())
                        cmd.Parameters.AddWithValue("@CustomerEmail", If(String.IsNullOrEmpty(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text))
                        cmd.Parameters.AddWithValue("@CustomerAddress", If(String.IsNullOrEmpty(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text))
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Customer details updated successfully.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving customer details: " & ex.Message)
        End Try
    End Sub

    ' Fetch sales made by the selected customer
    Private Sub btnFetchCustomerSales_Click(sender As Object, e As EventArgs) Handles btnFetchCustomerSales.Click
        If currentCustomerID Is Nothing Then
            MessageBox.Show("Please select a customer to fetch sales details.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT SaleID, SaleDate, TotalAmount FROM Sales WHERE CustomerID = @CustomerID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvCustomerSales.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching customer sales: " & ex.Message)
        End Try
    End Sub

    ' DataGridView cell click handler for customer details
    Private Sub dgvCustomerDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerDetails.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvCustomerDetails.Rows(e.RowIndex)
                currentCustomerID = Convert.ToInt32(row.Cells("CustomerID").Value)
                txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
                txtCustomerPhone.Text = row.Cells("CustomerPhone").Value.ToString()
                txtCustomerEmail.Text = row.Cells("CustomerEmail").Value.ToString()
                txtCustomerAddress.Text = row.Cells("CustomerAddress").Value.ToString()
            Catch ex As Exception
                MessageBox.Show("Error selecting customer: " & ex.Message)
            End Try
        End If
    End Sub

    ' Validate customer details
    Private Function ValidateCustomerDetails() As Boolean
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) OrElse Not txtCustomerName.Text.All(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c)) Then
            MessageBox.Show("Please enter a valid customer name using only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCustomerPhone.Text) OrElse txtCustomerPhone.Text.Length <> 10 OrElse Not txtCustomerPhone.Text.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Please enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

End Class