Imports System.Data.SqlClient

Public Class BillForm
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"
    Dim billingTable As DataTable
    Private userId As Integer
    Private currentSaleID As Integer

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

        ' Populate ComboBox with real bank names
        ComboBoxBankName.Items.AddRange(New String() {
            "Bank of Baroda", "Canara", "ICICI", "SBI", "HDFC",
            "Yes Bank", "Kotak Mahindra Bank", "TJSB"})

        ' Remove initial radio button selection
        rdoCash.Checked = False
        rdoCredit.Checked = False
        rdoDebit.Checked = False
    End Sub

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

    ' Add this helper method to check DataGridView setup
    Private Sub VerifyDataGridViewColumns()
        Debug.Print("DataGridView Columns:")
        For Each col As DataGridViewColumn In dgvCustomerDetails.Columns
            Debug.Print($"Column Name: {col.Name}, DataPropertyName: {col.DataPropertyName}")
        Next
    End Sub

    Private Sub dgvCustomerDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerDetails.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvCustomerDetails.Rows(e.RowIndex)
                ' Populate all textboxes from the selected row
                txtCustID.Text = row.Cells("CustomerID").Value.ToString()
                txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
                txtCustomerPhone.Text = row.Cells("CustomerPhone").Value.ToString()

                txtCustID.Visible = True
                lblCustID.Visible = True
                btnConfirmPayment.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error selecting customer: " & ex.Message)
            End Try
        End If
    End Sub

    ' Modified customer search method
    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        Dim customerName As String = txtCustomerName.Text.Trim()
        ResetFields()

        If String.IsNullOrEmpty(customerName) Then
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                ' Modified query to explicitly select required columns
                Dim query As String = "SELECT CustomerID, CustomerName, CustomerPhone FROM Customers WHERE CustomerName LIKE @CustomerName"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CustomerName", "%" & customerName & "%")
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            dgvCustomerDetails.AutoGenerateColumns = False
                            dgvCustomerDetails.Columns.Clear()

                            ' Set up columns with correct bindings
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

    Private Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim updateQuery As String = "UPDATE Customers SET CustomerEmail = @CustomerEmail, CustomerAddress = @CustomerAddress WHERE CustomerID = @CustomerID"
                Using cmd As New SqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustID.Text))
                    cmd.Parameters.AddWithValue("@CustomerEmail", If(String.IsNullOrEmpty(txtCustomerEmail.Text), DBNull.Value, txtCustomerEmail.Text.Trim()))
                    cmd.Parameters.AddWithValue("@CustomerAddress", If(String.IsNullOrEmpty(txtCustomerAddress.Text), DBNull.Value, txtCustomerAddress.Text.Trim()))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Customer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCustomerEmail.Visible = False
            txtCustomerAddress.Visible = False
            btnSaveDetails.Visible = False
            btnConfirmPayment.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error updating customer details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetFields()
        txtCustID.Clear()
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

    Private Function GetPaymentMode() As String
        If rdoCash.Checked Then
            Return "Cash"
        ElseIf rdoCredit.Checked Then
            Return "Credit Card"
        Else
            Return "Debit Card"
        End If
    End Function

    ' Update the btnConfirmPayment_Click to use the new payment mode method
    Private Sub btnConfirmPayment_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If Not (rdoCash.Checked Or rdoCredit.Checked Or rdoDebit.Checked) Then
            MessageBox.Show("Please select a payment mode.", "Payment Mode Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Insert the sale and get the SaleID
            currentSaleID = InsertSale()

            ' Insert the sale details
            InsertSaleDetails(currentSaleID)

            ' Process the payment
            ProcessPayment(currentSaleID)

            MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim printBillForm As New PrintBillForm(billingTable, txtCustID.Text, txtCustomerName.Text, txtCustomerPhone.Text, GetPaymentMode(), ComboBoxBankName.SelectedItem?.ToString(), txtCardNumber.Text, txtExpiryDate.Text)
            printBillForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function InsertSale() As Integer
        Dim saleID As Integer
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim insertSaleQuery As String = "INSERT INTO Sales (CustomerID, UserID, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @UserID, 0)"
                Using cmd As New SqlCommand(insertSaleQuery, conn)
                    cmd.CommandTimeout = 30 ' Set the command timeout
                    cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(txtCustID.Text))
                    cmd.Parameters.AddWithValue("@UserID", userId)
                    saleID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting sale: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
        Return saleID
    End Function

    Private Sub InsertSaleDetails(saleID As Integer)
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                For Each row As DataRow In billingTable.Rows
                    Dim insertSaleDetailsQuery As String = "INSERT INTO SalesDetails (SaleID, ProductID, Quantity, Price, Total, BatchID) VALUES (@SaleID, @ProductID, @Quantity, @Price, @Total, @BatchID)"
                    Using cmd As New SqlCommand(insertSaleDetailsQuery, conn)
                        cmd.CommandTimeout = 30 ' Set the command timeout
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
                    cmd.CommandTimeout = 30 ' Set the command timeout
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting sale details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    cmd.CommandTimeout = 30 ' Set the command timeout
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.Parameters.AddWithValue("@PaymentMode", paymentMode)
                    cmd.Parameters.AddWithValue("@BankName", If(String.IsNullOrEmpty(bankName), DBNull.Value, bankName))
                    cmd.Parameters.AddWithValue("@CardNumber", If(String.IsNullOrEmpty(cardNumber), DBNull.Value, cardNumber))
                    cmd.Parameters.AddWithValue("@ExpiryDate", If(String.IsNullOrEmpty(expiryDate), DBNull.Value, expiryDate))
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error processing payment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
End Class