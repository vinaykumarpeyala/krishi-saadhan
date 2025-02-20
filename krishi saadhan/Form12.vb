Imports System.Drawing
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
    Private companyGST As String = "XXXXXXXXXXXX"
    Private companyAddress As String = "Your Complete Address Here"
    Private companyPhone As String = "+91 XXXXXXXXXX"
    Private companyEmail As String = "contact@krishisaadhan.com"
    Public Event PrintCompleted()

    Public Sub New(billingTable As DataTable, customerId As String, customerName As String,
                  customerPhone As String, paymentMode As String, bankName As String,
                  cardNumber As String, expiryDate As String)
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
            MessageBox.Show("Error initializing print preview: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializePrinting()
        printDocument = New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        printPreviewDialog = New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            ' Define fonts and brushes
            Dim regularFont As New Font("Arial", 10)
            Dim boldFont As New Font("Arial", 10, FontStyle.Bold)
            Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
            Dim headerFont As New Font("Arial", 24, FontStyle.Bold)
            Dim italicFont As New Font("Arial", 10, FontStyle.Italic)

            ' Define colors
            Dim primaryColor As New SolidBrush(Color.FromArgb(46, 125, 50))  ' Dark Green
            Dim secondaryColor As New SolidBrush(Color.FromArgb(102, 102, 102))  ' Gray

            ' Define positions
            Dim startX As Integer = 50
            Dim startY As Integer = 50
            Dim offset As Integer = 25
            Dim pageWidth As Integer = e.PageBounds.Width - 100

            ' Draw header
            DrawCenteredString(e.Graphics, "KRISHI SAADHAN", headerFont, primaryColor,
                             startX, startY, pageWidth)
            startY += offset

            ' Company details
            DrawCenteredString(e.Graphics, companyAddress, italicFont, secondaryColor,
                             startX, startY, pageWidth)
            startY += offset
            DrawCenteredString(e.Graphics, "GST: " & companyGST, regularFont, secondaryColor,
                             startX, startY, pageWidth)
            startY += offset * 2

            ' Draw line separator
            e.Graphics.DrawLine(New Pen(primaryColor, 2), startX, startY,
                              startX + pageWidth - 100, startY)
            startY += offset

            ' Bill date and number
            e.Graphics.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy"),
                                regularFont, Brushes.Black, startX + pageWidth - 250, startY)
            startY += offset * 2

            ' Title
            DrawCenteredString(e.Graphics, "TAX INVOICE", titleFont, primaryColor,
                             startX, startY, pageWidth)
            startY += offset * 2

            ' Customer details in a box
            Dim customerBox As New Rectangle(startX, startY, pageWidth - 100, offset * 4)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(248, 248, 248)), customerBox)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray), customerBox)

            ' Customer information
            startY += 10
            e.Graphics.DrawString("Customer ID: " & customerId, boldFont, Brushes.Black,
                                startX + 10, startY)
            startY += offset
            e.Graphics.DrawString("Name: " & customerName, boldFont, Brushes.Black,
                                startX + 10, startY)
            startY += offset
            e.Graphics.DrawString("Phone: " & customerPhone, boldFont, Brushes.Black,
                                startX + 10, startY)
            startY += offset * 2

            ' Items table header
            Dim tableHeaders As New Rectangle(startX, startY, pageWidth - 100, offset)
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(46, 125, 50)), tableHeaders)

            ' Column headers
            e.Graphics.DrawString("Item", boldFont, Brushes.White, startX + 10, startY)
            e.Graphics.DrawString("Qty", boldFont, Brushes.White, startX + 300, startY)
            e.Graphics.DrawString("Price", boldFont, Brushes.White, startX + 400, startY)
            e.Graphics.DrawString("Total", boldFont, Brushes.White, startX + 500, startY)
            startY += offset

            ' Print items
            Dim total As Decimal = 0
            For Each row As DataRow In billingTable.Rows
                e.Graphics.DrawString(row("ProductName").ToString(), regularFont,
                                    Brushes.Black, startX + 10, startY)
                e.Graphics.DrawString(row("Quantity").ToString(), regularFont,
                                    Brushes.Black, startX + 300, startY)
                e.Graphics.DrawString("₹" & row("Price").ToString(), regularFont,
                                    Brushes.Black, startX + 400, startY)
                e.Graphics.DrawString("₹" & row("Total").ToString(), regularFont,
                                    Brushes.Black, startX + 500, startY)
                total += CDec(row("Total"))
                startY += offset
            Next

            ' Total amount
            startY += offset
            e.Graphics.DrawString("Total Amount: ₹" & total.ToString("N2"), boldFont,
                                primaryColor, startX + 400, startY)
            startY += offset * 2

            ' Payment details
            Dim paymentBox As New Rectangle(startX, startY, pageWidth - 100,
                                          If(paymentMode = "Cash", offset * 2, offset * 5))
            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(248, 248, 248)), paymentBox)
            e.Graphics.DrawRectangle(New Pen(Color.LightGray), paymentBox)

            startY += 10
            e.Graphics.DrawString("Payment Mode: " & paymentMode, boldFont,
                                Brushes.Black, startX + 10, startY)
            If paymentMode <> "Cash" Then
                startY += offset
                e.Graphics.DrawString("Bank: " & bankName, regularFont, Brushes.Black, startX + 10, startY)
                startY += offset
                e.Graphics.DrawString("Card Number: " & MaskCardNumber(cardNumber), regularFont, Brushes.Black, startX + 10, startY)
                startY += offset
                e.Graphics.DrawString("Expiry Date: " & expiryDate, regularFont, Brushes.Black, startX + 10, startY)
            End If

            startY += offset * 3

            ' Thank you message
            DrawCenteredString(e.Graphics, "Thank you for choosing Krishi Saadhan!",
                             italicFont, primaryColor, startX, startY, pageWidth)
            startY += offset
            DrawCenteredString(e.Graphics, "We value your trust in us.", italicFont,
                             primaryColor, startX, startY, pageWidth)
            startY += offset * 2

            ' Footer
            DrawCenteredString(e.Graphics, "For queries: " & companyPhone & " | " &
                             companyEmail, regularFont, secondaryColor, startX, startY, pageWidth)

            RaiseEvent PrintCompleted()

        Catch ex As Exception
            MessageBox.Show("Error during printing: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function MaskCardNumber(cardNumber As String) As String
        If String.IsNullOrEmpty(cardNumber) Then Return ""

        ' Keep only last 4 digits visible
        Dim lastFourDigits As String = cardNumber.Substring(Math.Max(0, cardNumber.Length - 4))
        Dim maskedPart As String = New String("X"c, Math.Max(0, cardNumber.Length - 4))

        ' Format with dashes for readability
        Dim maskedNumber As String = maskedPart & lastFourDigits
        If maskedNumber.Length >= 16 Then
            Return maskedNumber.Insert(12, "-").Insert(8, "-").Insert(4, "-")
        End If

        Return maskedNumber
    End Function
    Private Sub DrawCenteredString(graphics As Graphics, text As String, font As Font,
                                 brush As Brush, x As Integer, y As Integer, width As Integer)
        Dim stringSize As SizeF = graphics.MeasureString(text, font)
        Dim centeredX As Single = x + (width - stringSize.Width) / 2
        graphics.DrawString(text, font, brush, centeredX, y)
    End Sub
End Class