Imports System.Drawing.Printing

Public Class PrintBillForm
    Private billingTable As DataTable
    Private customerId As String
    Private customerName As String
    Private customerPhone As String
    Private paymentMode As String
    Private bankName As String
    Private cardNumber As String
    Private expiryDate As String
    Private printDocument As PrintDocument
    Private printPreviewDialog As PrintPreviewDialog

    Public Sub New(billingTable As DataTable, customerId As String, customerName As String, customerPhone As String, paymentMode As String, bankName As String, cardNumber As String, expiryDate As String)
        InitializeComponent()
        Me.billingTable = billingTable
        Me.customerId = customerId
        Me.customerName = customerName
        Me.customerPhone = customerPhone
        Me.paymentMode = paymentMode
        Me.bankName = bankName
        Me.cardNumber = cardNumber
        Me.expiryDate = expiryDate
    End Sub

    Private Sub PrintBillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitializePrinting()
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error initializing print preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializePrinting()
        printDocument = New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        printPreviewDialog = New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim offset As Integer = 20
        Dim font As New Font("Arial", 10)
        Dim boldFont As New Font("Arial", 10, FontStyle.Bold)

        ' Print header
        e.Graphics.DrawString("KRISHI SAADHAN", boldFont, Brushes.Black, startX, startY)
        startY += offset * 2

        ' Print customer details
        e.Graphics.DrawString($"Customer ID: {customerId}", font, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Customer Name: {customerName}", font, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString($"Phone: {customerPhone}", font, Brushes.Black, startX, startY)
        startY += offset * 2

        ' Print bill details header
        e.Graphics.DrawString("Item", boldFont, Brushes.Black, startX, startY)
        e.Graphics.DrawString("Qty", boldFont, Brushes.Black, startX + 200, startY)
        e.Graphics.DrawString("Price", boldFont, Brushes.Black, startX + 300, startY)
        e.Graphics.DrawString("Total", boldFont, Brushes.Black, startX + 400, startY)
        startY += offset

        ' Print items from billing table
        For Each row As DataRow In billingTable.Rows
            e.Graphics.DrawString(row("ProductName").ToString(), font, Brushes.Black, startX, startY)
            e.Graphics.DrawString(row("Quantity").ToString(), font, Brushes.Black, startX + 200, startY)
            e.Graphics.DrawString(row("Price").ToString(), font, Brushes.Black, startX + 300, startY)
            e.Graphics.DrawString(row("Total").ToString(), font, Brushes.Black, startX + 400, startY)
            startY += offset
        Next

        ' Print total
        startY += offset
        Dim total As Decimal = billingTable.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("Total"))
        e.Graphics.DrawString($"Total Amount: ₹{total:N2}", boldFont, Brushes.Black, startX + 300, startY)

        ' Print payment details
        startY += offset * 2
        e.Graphics.DrawString($"Payment Mode: {paymentMode}", font, Brushes.Black, startX, startY)
        If paymentMode <> "Cash" Then
            startY += offset
            e.Graphics.DrawString($"Bank: {bankName}", font, Brushes.Black, startX, startY)
            startY += offset
            e.Graphics.DrawString($"Card Number: {cardNumber}", font, Brushes.Black, startX, startY)
            startY += offset
            e.Graphics.DrawString($"Expiry Date: {expiryDate}", font, Brushes.Black, startX, startY)
        End If

        ' Print footer
        startY += offset * 2
        e.Graphics.DrawString("Thank you for shopping with us!", font, Brushes.Black, startX, startY)
        startY += offset
        e.Graphics.DrawString(DateTime.Now.ToString(), font, Brushes.Black, startX, startY)
    End Sub
End Class