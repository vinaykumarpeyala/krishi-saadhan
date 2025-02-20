Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class BillForm
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"
    Dim billingTable As DataTable
    Private userId As Integer
    Private currentSaleID As Integer
    Private currentCustomerID As Integer?
    Private formdialogResult As DialogResult = DialogResult.Cancel
    Public Event StockUpdated()
    Public Sub New(billingTable As DataTable, userId As Integer)
        InitializeComponent()
        Me.billingTable = billingTable
        Me.userId = userId
    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial visibility
        PanelCardDetails.Visible = False
        dgvCustomerDetails.Visible = False
        txtCustID.Visible = False
        lblCustID.Visible = False
        txtCustomerPhone.Visible = True
        txtCustomerEmail.Visible = False
        txtCustomerAddress.Visible = False
        btnSaveDetails.Visible = False
        btnConfirmPayment.Visible = False
        dgvBillDetails.DataSource = billingTable

        ' Populate ComboBox with bank names
        ComboBoxBankName.Items.AddRange(New String() {
            "Bank of Baroda", "Canara", "ICICI", "SBI", "HDFC",
            "Yes Bank", "Kotak Mahindra Bank", "TJSB"})

        ' Remove initial radio button selection
        rdoCash.Checked = False
        rdoCredit.Checked = False
        rdoDebit.Checked = False
    End Sub

    ' Validation functions
    Private Function IsValidName(name As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(name) AndAlso name.All(Function(c) Char.IsLetter(c) OrElse Char.IsWhiteSpace(c))
    End Function

    Private Function IsValidPhoneNumber(phone As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(phone) AndAlso phone.Length = 10 AndAlso phone.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsValidCardNumber(cardNumber As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(cardNumber) AndAlso cardNumber.Length = 16 AndAlso cardNumber.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsValidCCV(ccv As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(ccv) AndAlso ccv.Length = 3 AndAlso ccv.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsValidExpiryDate(expiryDate As String) As Boolean
        If String.IsNullOrWhiteSpace(expiryDate) Then Return False
        Dim pattern As String = "^(0[1-9]|1[0-2])\/?([0-9]{2})$"
        Return Regex.IsMatch(expiryDate, pattern)
    End Function

    ' TextBox validation events
    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        If Not IsValidName(txtCustomerName.Text.Trim()) Then
            txtCustomerName.BackColor = Color.LightPink
            Return
        Else
            txtCustomerName.BackColor = Color.White
        End If

        Dim customerName As String = txtCustomerName.Text.Trim()
        ResetFields()

        If String.IsNullOrEmpty(customerName) Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT CustomerID, CustomerName, CustomerPhone FROM Customers WHERE CustomerName LIKE @CustomerName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerName", "%" & customerName & "%")
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            dgvCustomerDetails.AutoGenerateColumns = False
                            dgvCustomerDetails.Columns.Clear()

                            With dgvCustomerDetails
                                .Columns.Add(New DataGridViewTextBoxColumn With {
                                    .Name = "CustomerID",
                                    .HeaderText = "Customer ID",
                                    .DataPropertyName = "CustomerID"
                                })
                                .Columns.Add(New DataGridViewTextBoxColumn With {
                                    .Name = "CustomerName",
                                    .HeaderText = "Name",
                                    .DataPropertyName = "CustomerName"
                                })
                                .Columns.Add(New DataGridViewTextBoxColumn With {
                                    .Name = "CustomerPhone",
                                    .HeaderText = "Phone",
                                    .DataPropertyName = "CustomerPhone"
                                })
                                .DataSource = dt
                                .Visible = True
                            End With
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching customer details: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCustomerPhone_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerPhone.TextChanged
        If Not String.IsNullOrEmpty(txtCustomerPhone.Text) AndAlso Not txtCustomerPhone.Text.All(Function(c) Char.IsDigit(c)) Then
            txtCustomerPhone.Text = String.Join("", txtCustomerPhone.Text.Where(Function(c) Char.IsDigit(c)))
            txtCustomerPhone.SelectionStart = txtCustomerPhone.Text.Length
        End If

        If txtCustomerPhone.Text.Length > 10 Then
            txtCustomerPhone.Text = txtCustomerPhone.Text.Substring(0, 10)
            txtCustomerPhone.SelectionStart = txtCustomerPhone.Text.Length
        End If

        If Not String.IsNullOrEmpty(txtCustomerPhone.Text) And txtCustomerPhone.Text.Length < 10 Then
            txtCustomerPhone.BackColor = Color.LightPink
        Else
            txtCustomerPhone.BackColor = Color.White
        End If
    End Sub

    ' DataGridView cell click handler
    Private Sub dgvCustomerDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerDetails.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvCustomerDetails.Rows(e.RowIndex)
                currentCustomerID = Convert.ToInt32(row.Cells("CustomerID").Value)
                txtCustID.Text = currentCustomerID.ToString()
                txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
                txtCustomerPhone.Text = row.Cells("CustomerPhone").Value.ToString()

                ' Load additional customer details
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Dim query As String = "SELECT CustomerEmail, CustomerAddress FROM Customers WHERE CustomerID = @CustomerID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                txtCustomerEmail.Text = If(reader.IsDBNull(0), "", reader.GetString(0))
                                txtCustomerAddress.Text = If(reader.IsDBNull(1), "", reader.GetString(1))
                            End If
                        End Using
                    End Using
                End Using

                txtCustID.Visible = True
                lblCustID.Visible = True
                txtCustomerEmail.Visible = True
                txtCustomerAddress.Visible = True
                btnSaveDetails.Visible = True
                btnConfirmPayment.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error selecting customer: " & ex.Message)
            End Try
        End If
    End Sub

    ' Updated Proceed button functionality
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim customerName As String = txtCustomerName.Text.Trim()
        Dim customerPhone As String = txtCustomerPhone.Text.Trim()

        ' Validate inputs
        If Not IsValidName(customerName) Then
            MessageBox.Show("Please enter a valid customer name using only letters and spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidPhoneNumber(customerPhone) Then
            MessageBox.Show("Please enter a valid 10-digit phone number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Check if customer exists by phone number
                Dim checkQuery As String = "SELECT CustomerID FROM Customers WHERE CustomerPhone = @CustomerPhone"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@CustomerPhone", customerPhone)
                    Dim existingCustomerId = checkCmd.ExecuteScalar()

                    If existingCustomerId IsNot Nothing Then
                        ' Customer exists - load their details
                        currentCustomerID = Convert.ToInt32(existingCustomerId)
                        LoadCustomerDetails(currentCustomerID)
                        btnConfirmPayment.Visible = True
                    Else
                        ' Show additional fields for new customer
                        txtCustomerEmail.Visible = True
                        txtCustomerAddress.Visible = True
                        btnSaveDetails.Visible = True
                        btnConfirmPayment.Visible = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error processing customer details: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCustomerDetails(customerId As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM Customers WHERE CustomerID = @CustomerID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtCustID.Text = reader("CustomerID").ToString()
                            txtCustomerName.Text = reader("CustomerName").ToString()
                            txtCustomerPhone.Text = reader("CustomerPhone").ToString()
                            txtCustomerEmail.Text = If(reader("CustomerEmail") Is DBNull.Value, "", reader("CustomerEmail").ToString())
                            txtCustomerAddress.Text = If(reader("CustomerAddress") Is DBNull.Value, "", reader("CustomerAddress").ToString())

                            txtCustID.Visible = True
                            lblCustID.Visible = True
                            txtCustomerEmail.Visible = True
                            txtCustomerAddress.Visible = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customer details: " & ex.Message)
        End Try
    End Sub

    ' Payment mode radio button handlers
    Private Sub rdoCash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCash.CheckedChanged
        If rdoCash.Checked Then
            PanelCardDetails.Visible = False
        End If
    End Sub

    Private Sub rdoCredit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCredit.CheckedChanged
        If rdoCredit.Checked Then
            PanelCardDetails.Visible = True
        End If
    End Sub

    Private Sub rdoDebit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDebit.CheckedChanged
        If rdoDebit.Checked Then
            PanelCardDetails.Visible = True
        End If
    End Sub

    Private Function GetPaymentMode() As String
        If rdoCash.Checked Then
            Return "Cash"
        ElseIf rdoCredit.Checked Then
            Return "Credit Card"
        Else
            Return "Debit Card"
        End If
    End Function

    Private Sub ResetFields()
        txtCustomerEmail.Clear()
        txtCustomerAddress.Clear()
        txtCustID.Visible = False
        lblCustID.Visible = False
        dgvCustomerDetails.Visible = False
        txtCustomerEmail.Visible = False
        txtCustomerAddress.Visible = False
        btnSaveDetails.Visible = False
        btnConfirmPayment.Visible = False
    End Sub

    ' Save Details button handler
    Private Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click
        If Not IsValidName(txtCustomerName.Text.Trim()) OrElse Not IsValidPhoneNumber(txtCustomerPhone.Text.Trim()) Then
            MessageBox.Show("Please ensure name and phone number are valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                        txtCustID.Text = currentCustomerID.ToString()
                    End Using
                    MessageBox.Show("New customer added successfully.")
                Else
                    ' Update existing customer
                    Dim updateQuery As String = "UPDATE Customers SET CustomerEmail = @CustomerEmail, CustomerAddress = @CustomerAddress WHERE CustomerID = @CustomerID"
                    Using cmd As New SqlCommand(updateQuery, conn)
                        cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                        cmd.Parameters.AddWithValue("@CustomerEmail", If(String.IsNullOrEmpty(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text))
                        cmd.Parameters.AddWithValue("@CustomerAddress", If(String.IsNullOrEmpty(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text))
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Customer details updated successfully.")
                End If
            End Using

            btnSaveDetails.Visible = False
            txtCustomerEmail.Visible = False
            txtCustomerAddress.Visible = False

            Dim result As DialogResult = MessageBox.Show("Do you want to update additional customer details?", "Update Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                txtCustomerEmail.Visible = True
                txtCustomerAddress.Visible = True
                btnSaveDetails.Visible = True
                btnConfirmPayment.Visible = False
            Else
                btnConfirmPayment.Visible = True
            End If

            txtCustID.Visible = True
            lblCustID.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error saving customer details: " & ex.Message)
        End Try
    End Sub

    ' Payment confirmation handler
    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If currentCustomerID Is Nothing Then
            MessageBox.Show("Please save customer details first.")
            Return
        End If

        If Not (rdoCash.Checked Or rdoCredit.Checked Or rdoDebit.Checked) Then
            MessageBox.Show("Please select a payment mode.")
            Return
        End If

        If rdoCredit.Checked Or rdoDebit.Checked Then
            If Not IsValidCardNumber(txtCardNumber.Text.Trim()) Then
                MessageBox.Show("Please enter a valid 16-digit card number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not IsValidCCV(txtCVV.Text.Trim()) Then
                MessageBox.Show("Please enter a valid 3-digit CCV number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not IsValidExpiryDate(txtExpiryDate.Text.Trim()) Then
                MessageBox.Show("Please enter a valid expiry date in MM/YY format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        Try
            ' Insert the sale and get the SaleID
            currentSaleID = InsertSale()

            ' Insert the sale details
            InsertSaleDetails(currentSaleID)

            ' Process the payment
            ProcessPayment(currentSaleID)

            MessageBox.Show("Payment processed successfully!")

            ' Show print bill form
            Dim printBillForm As New PrintBillForm(billingTable, txtCustID.Text, txtCustomerName.Text, txtCustomerPhone.Text, GetPaymentMode(), ComboBoxBankName.SelectedItem?.ToString(), txtCardNumber.Text, txtExpiryDate.Text)
            printBillForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("An error occurred while processing the payment: " & ex.Message)
        End Try
    End Sub

    Private Function InsertSale() As Integer
        Dim saleID As Integer
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim insertSaleQuery As String = "INSERT INTO Sales (CustomerID, UserID, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @UserID, 0)"
                Using cmd As New SqlCommand(insertSaleQuery, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", currentCustomerID)
                    cmd.Parameters.AddWithValue("@UserID", userId)
                    saleID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting sale: " & ex.Message)
            Throw
        End Try
        Return saleID
    End Function

    Private Sub InsertSaleDetails(saleID As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if BatchID exists in Stock table before inserting
                For Each row As DataRow In billingTable.Rows
                    Dim checkBatchIDQuery As String = "SELECT COUNT(*) FROM Stock WHERE BatchID = @BatchID"
                    Using checkCmd As New SqlCommand(checkBatchIDQuery, conn)
                        checkCmd.Parameters.AddWithValue("@BatchID", row("BatchID"))
                        Dim batchIDExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If batchIDExists = 0 Then
                            Throw New Exception($"BatchID {row("BatchID")} does not exist in the Stock table.")
                        End If
                    End Using
                Next

                ' Insert sale details
                For Each row As DataRow In billingTable.Rows
                    Dim insertSaleDetailsQuery As String = "INSERT INTO SalesDetails (SaleID, ProductID, Quantity, Price, Total, BatchID) VALUES (@SaleID, @ProductID, @Quantity, @Price, @Total, @BatchID)"
                    Using cmd As New SqlCommand(insertSaleDetailsQuery, conn)
                        cmd.Parameters.AddWithValue("@SaleID", saleID)
                        cmd.Parameters.AddWithValue("@ProductID", row("ProductID"))
                        cmd.Parameters.AddWithValue("@Quantity", row("Quantity"))
                        cmd.Parameters.AddWithValue("@Price", row("Price"))
                        cmd.Parameters.AddWithValue("@Total", row("Total"))
                        cmd.Parameters.AddWithValue("@BatchID", row("BatchID"))
                        cmd.ExecuteNonQuery()
                    End Using
                Next

                ' Update the total amount in the Sales table
                Dim totalAmount As Decimal = billingTable.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("Total"))
                Dim updateTotalAmountQuery As String = "UPDATE Sales SET TotalAmount = @TotalAmount WHERE SaleID = @SaleID"
                Using cmd As New SqlCommand(updateTotalAmountQuery, conn)
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting sale details: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Sub ProcessPayment(saleID As Integer)
        Try
            Dim totalAmount As Decimal = billingTable.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("Total"))
            Dim paymentMode As String = GetPaymentMode()
            Dim bankName As String = If(paymentMode <> "Cash", ComboBoxBankName.SelectedItem?.ToString(), "")
            Dim cardNumber As String = If(paymentMode <> "Cash", txtCardNumber.Text, "")
            Dim expiryDate As String = If(paymentMode <> "Cash", txtExpiryDate.Text, "")

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim insertPaymentQuery As String = "INSERT INTO Payments (SaleID, PaymentMode, BankName, CardNumber, ExpiryDate, TotalAmount) " &
                                      "VALUES (@SaleID, @PaymentMode, @BankName, @CardNumber, @ExpiryDate, @TotalAmount)"
                Using cmd As New SqlCommand(insertPaymentQuery, conn)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.Parameters.AddWithValue("@PaymentMode", paymentMode)
                    cmd.Parameters.AddWithValue("@BankName", If(String.IsNullOrEmpty(bankName), DBNull.Value, bankName))
                    cmd.Parameters.AddWithValue("@CardNumber", If(String.IsNullOrEmpty(cardNumber), DBNull.Value, cardNumber))
                    cmd.Parameters.AddWithValue("@ExpiryDate", If(String.IsNullOrEmpty(expiryDate), DBNull.Value, expiryDate))
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.ExecuteNonQuery()
                End Using

                ' Update stock quantities
                For Each row As DataRow In billingTable.Rows
                    Dim updateStockQuery As String = "UPDATE Stock SET BatchQuantity = BatchQuantity - @SoldQuantity WHERE BatchID = @BatchID"
                    Using cmd As New SqlCommand(updateStockQuery, conn)
                        cmd.Parameters.AddWithValue("@SoldQuantity", row("Quantity"))
                        cmd.Parameters.AddWithValue("@BatchID", row("BatchID"))
                        cmd.ExecuteNonQuery()
                        formdialogResult = DialogResult.OK
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                        RaiseEvent StockUpdated()
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Sub ClearForm()
        txtCustomerName.Clear()
        txtCustomerPhone.Clear()
        txtCustomerEmail.Clear()
        txtCustomerAddress.Clear()
        txtCustID.Clear()
        txtCardNumber.Clear()
        txtExpiryDate.Clear()
        ComboBoxBankName.SelectedIndex = -1
        rdoCash.Checked = False
        rdoCredit.Checked = False
        rdoDebit.Checked = False
        PanelCardDetails.Visible = False
        currentCustomerID = Nothing
        currentSaleID = 0
        billingTable.Clear()
        ResetFields()
    End Sub

    Private Sub BillForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If formdialogResult = DialogResult.Cancel Then
            ' Ask for confirmation only if payment wasn't successful
            If billingTable.Rows.Count > 0 Then
                Dim result = MessageBox.Show("Are you sure you want to cancel the billing process?",
                                       "Confirm Cancel",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class
