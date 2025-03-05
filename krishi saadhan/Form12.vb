Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D

Public Class PrintBillForm
    Private billingTable As DataTable
    Private customerId As String
    Private customerName As String
    Private customerPhone As String
    Private paymentMode As String
    Private bankName As String
    Private cardNumber As String
    Private expiryDate As String
    Private invoiceNumber As String
    Private printDocument As PrintDocument
    Private printPreviewDialog As PrintPreviewDialog
    Private companyLogo As Image
    Private companyNametext As String = "KRISHI SAADHAN"
    Private companyGST As String = "29AMWXZ234RXt"
    Private companyAddress As String = "#20, 5th Main, 6th Cross, Bagalur Main Road, Bangalore-560039"
    Private companyPhone As String = "+91 8978729151"
    Private companyEmail As String = "info@krishisaadhan.com"
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
        Me.invoiceNumber = GenerateInvoiceNumber()
        LoadCompanyLogo()
    End Sub

    Private Function GenerateInvoiceNumber() As String
        Return "INV-" & DateTime.Now.ToString("yyMMdd") & "-" & New Random().Next(1000, 9999).ToString()
    End Function

    Private Sub LoadCompanyLogo()
        Try
            companyLogo = Image.FromFile("C:\Users\VINAY KUMAR\Downloads\Krishi Saadhan.jpg")
        Catch ex As Exception
            MessageBox.Show("Error loading logo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            companyLogo = CreateLogoPlaceholder()
        End Try
    End Sub

    Private Function CreateLogoPlaceholder() As Image
        Dim logoImage As New Bitmap(200, 100)
        Using g As Graphics = Graphics.FromImage(logoImage)
            g.FillRectangle(New SolidBrush(Color.FromArgb(240, 248, 240)), 0, 0, 200, 100)
            Using path As New GraphicsPath()
                path.AddString("KS", New FontFamily("Arial"), FontStyle.Bold, 48,
                              New Point(20, 25), StringFormat.GenericDefault)
                g.FillPath(New SolidBrush(Color.FromArgb(46, 125, 50)), path)
                g.DrawPath(New Pen(Color.FromArgb(30, 80, 30), 2), path)
            End Using
            g.DrawString("Farming Solutions", New Font("Arial", 10, FontStyle.Italic),
                        New SolidBrush(Color.FromArgb(50, 120, 50)), 20, 75)
        End Using
        Return logoImage
    End Function

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
        AddHandler printDocument.PrintPage, AddressOf PrintBillForm_PrintPage
        printPreviewDialog = New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PrintBillForm_PrintPage(sender As Object, e As PrintPageEventArgs)
        Try
            ' Define fonts with increased boldness
            Dim regularFont As New Font("Segoe UI", 10, FontStyle.Bold)
            Dim smallFont As New Font("Segoe UI", 9, FontStyle.Bold)
            Dim boldFont As New Font("Segoe UI", 11, FontStyle.Bold)
            Dim titleFont As New Font("Segoe UI", 18, FontStyle.Bold)
            Dim headerFont As New Font("Segoe UI", 24, FontStyle.Bold)
            Dim italicFont As New Font("Segoe UI", 10, FontStyle.Bold Or FontStyle.Italic)

            ' Define colors
            Dim primaryColor As New SolidBrush(Color.FromArgb(46, 125, 50))  ' Dark Green
            Dim secondaryColor As New SolidBrush(Color.FromArgb(60, 60, 60))  ' Darker Gray
            Dim lightGrayBrush As New SolidBrush(Color.FromArgb(245, 245, 245))
            Dim borderPen As New Pen(Color.FromArgb(200, 200, 200), 2)
            Dim primaryPen As New Pen(Color.FromArgb(46, 125, 50), 3)

            ' Define positions and dimensions for full-page usage
            Dim startX As Integer = 40
            Dim startY As Integer = 40
            Dim offset As Integer = 30   ' Increased spacing
            Dim smallOffset As Integer = 20
            Dim pageWidth As Integer = e.PageBounds.Width - 80
            Dim pageHeight As Integer = e.PageBounds.Height - 80

            ' Draw page border with rounded corners
            Dim pageBorder As New Rectangle(30, 30, e.PageBounds.Width - 60, e.PageBounds.Height - 60)
            Using path As New GraphicsPath()
                Dim radius As Integer = 20
                path.AddArc(pageBorder.X, pageBorder.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(pageBorder.Right - radius * 2, pageBorder.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(pageBorder.Right - radius * 2, pageBorder.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(pageBorder.X, pageBorder.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.DrawPath(primaryPen, path)
            End Using

            ' Draw header background
            Dim headerRect As New Rectangle(startX, startY, pageWidth, 140)
            Using path As New GraphicsPath()
                Dim radius As Integer = 15
                path.AddArc(headerRect.X, headerRect.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(headerRect.Right - radius * 2, headerRect.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(headerRect.Right - radius * 2, headerRect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(headerRect.X, headerRect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(lightGrayBrush, path)
                e.Graphics.DrawPath(borderPen, path)
            End Using

            ' Draw logo
            Dim logoWidth As Integer = 180
            Dim logoHeight As Integer = 90
            Dim logoX As Integer = startX + 15
            Dim logoY As Integer = startY + 25
            If companyLogo IsNot Nothing Then
                e.Graphics.DrawImage(companyLogo, logoX, logoY, logoWidth, logoHeight)
            End If

            ' Company details
            Dim companyDetailsX As Integer = startX + 400
            Dim companyDetailsY As Integer = startY + 20
            e.Graphics.DrawString("KRISHI SAADHAN", headerFont, primaryColor, companyDetailsX, companyDetailsY)
            companyDetailsY += 40
            e.Graphics.DrawString(companyAddress, smallFont, secondaryColor, companyDetailsX, companyDetailsY)
            companyDetailsY += smallOffset + 5
            e.Graphics.DrawString("GSTIN: " & companyGST, smallFont, secondaryColor, companyDetailsX, companyDetailsY)
            companyDetailsY += smallOffset + 5
            e.Graphics.DrawString("Phone: " & companyPhone, smallFont, secondaryColor, companyDetailsX, companyDetailsY)
            companyDetailsY += smallOffset + 7
            e.Graphics.DrawString("Email: " & companyEmail, smallFont, secondaryColor, companyDetailsX, companyDetailsY)

            startY += 150

            ' Invoice info section
            Dim invoiceInfoRect As New Rectangle(startX, startY, pageWidth, 100)
            Using path As New GraphicsPath()
                Dim radius As Integer = 15
                path.AddArc(invoiceInfoRect.X, invoiceInfoRect.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(invoiceInfoRect.Right - radius * 2, invoiceInfoRect.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(invoiceInfoRect.Right - radius * 2, invoiceInfoRect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(invoiceInfoRect.X, invoiceInfoRect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(New SolidBrush(Color.FromArgb(245, 255, 245)), path)
                e.Graphics.DrawPath(borderPen, path)
            End Using

            e.Graphics.DrawString("TAX INVOICE", titleFont, primaryColor, startX + 15, startY + 10)
            Dim invoiceDetailsX As Integer = startX + 400
            Dim invoiceDetailsY As Integer = startY + 20
            e.Graphics.DrawString("Invoice No: " & invoiceNumber, boldFont, Brushes.Black, invoiceDetailsX, invoiceDetailsY)
            invoiceDetailsY += offset
            e.Graphics.DrawString("Date: " & DateTime.Now.ToString("dd/MM/yyyy"), regularFont, Brushes.Black, invoiceDetailsX, invoiceDetailsY)
            invoiceDetailsY += offset
            e.Graphics.DrawString("Time: " & DateTime.Now.ToString("hh:mm tt"), regularFont, Brushes.Black, invoiceDetailsX, invoiceDetailsY)

            startY += 110

            ' Customer details section
            Dim customerBox As New Rectangle(startX, startY, pageWidth, offset * 5)
            Using path As New GraphicsPath()
                Dim radius As Integer = 15
                path.AddArc(customerBox.X, customerBox.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(customerBox.Right - radius * 2, customerBox.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(customerBox.Right - radius * 2, customerBox.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(customerBox.X, customerBox.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(New SolidBrush(Color.FromArgb(252, 252, 252)), path)
                e.Graphics.DrawPath(borderPen, path)
            End Using

            Dim customerTitleRect As New Rectangle(startX + 15, startY - 15, 150, 25)
            e.Graphics.FillRectangle(New SolidBrush(Color.White), customerTitleRect)
            e.Graphics.DrawString("CUSTOMER DETAILS", smallFont, primaryColor, customerTitleRect)

            startY += 20
            e.Graphics.DrawString("Customer ID: " & customerId, boldFont, Brushes.Black, startX + 40, startY)
            e.Graphics.DrawString("Name: " & customerName, boldFont, Brushes.Black, startX + 350, startY)
            startY += offset + 10
            e.Graphics.DrawString("Phone: " & customerPhone, regularFont, Brushes.Black, startX + 40, startY)

            startY += offset * 2

            ' Items table
            Dim tableWidth As Integer = pageWidth
            Dim tableStartY As Integer = startY
            Dim tableHeaders As New Rectangle(startX, startY, tableWidth, offset + 10)
            Using path As New GraphicsPath()
                Dim radius As Integer = 10
                path.AddArc(tableHeaders.X, tableHeaders.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(tableHeaders.Right - radius * 2, tableHeaders.Y, radius * 2, radius * 2, 270, 90)
                path.AddLine(tableHeaders.Right, tableHeaders.Y + radius, tableHeaders.Right, tableHeaders.Bottom)
                path.AddLine(tableHeaders.Right, tableHeaders.Bottom, tableHeaders.X, tableHeaders.Bottom)
                path.AddLine(tableHeaders.X, tableHeaders.Bottom, tableHeaders.X, tableHeaders.Y + radius)
                path.CloseFigure()
                e.Graphics.FillPath(primaryColor, path)
            End Using

            Dim colPadding As Integer = 15
            Dim col1Width As Integer = 300    ' Item name
            Dim col2Width As Integer = 100    ' Quantity
            Dim col3Width As Integer = 120    ' Price
            Dim col4Width As Integer = 140    ' Total

            e.Graphics.DrawString("Item Description", boldFont, Brushes.White, startX + colPadding, startY + 10)
            e.Graphics.DrawString("Quantity", boldFont, Brushes.White, startX + col1Width + colPadding, startY + 10)
            e.Graphics.DrawString("Price (₹)", boldFont, Brushes.White, startX + col1Width + col2Width + colPadding, startY + 10)
            e.Graphics.DrawString("Total (₹)", boldFont, Brushes.White, startX + col1Width + col2Width + col3Width + colPadding, startY + 10)
            startY += offset + 10

            ' Print items with GST calculation
            Dim subTotal As Decimal = 0
            Dim cgstRate As Decimal = 0.09  ' 9% CGST
            Dim sgstRate As Decimal = 0.09  ' 9% SGST
            Dim alternateRow As Boolean = False

            For Each row As DataRow In billingTable.Rows
                Dim rowRect As New Rectangle(startX, startY, tableWidth, offset)
                If alternateRow Then
                    e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(250, 250, 250)), rowRect)
                End If
                alternateRow = Not alternateRow

                e.Graphics.DrawString(row("ProductName").ToString(), regularFont, Brushes.Black, startX + colPadding, startY + 5)
                e.Graphics.DrawString(row("Quantity").ToString(), regularFont, Brushes.Black, startX + col1Width + colPadding, startY + 5)
                e.Graphics.DrawString(FormatCurrency(row("Price")), regularFont, Brushes.Black, startX + col1Width + col2Width + colPadding, startY + 5)
                e.Graphics.DrawString(FormatCurrency(row("Total")), boldFont, Brushes.Black, startX + col1Width + col2Width + col3Width + colPadding, startY + 5)

                e.Graphics.DrawLine(borderPen, startX, startY + offset, startX + tableWidth, startY + offset)
                subTotal += CDec(row("Total"))
                startY += offset
            Next

            ' Draw vertical lines
            e.Graphics.DrawLine(borderPen, startX, tableStartY + offset + 10, startX, startY)
            e.Graphics.DrawLine(borderPen, startX + col1Width, tableStartY + offset + 10, startX + col1Width, startY)
            e.Graphics.DrawLine(borderPen, startX + col1Width + col2Width, tableStartY + offset + 10, startX + col1Width + col2Width, startY)
            e.Graphics.DrawLine(borderPen, startX + col1Width + col2Width + col3Width, tableStartY + offset + 10, startX + col1Width + col2Width + col3Width, startY)
            e.Graphics.DrawLine(borderPen, startX + tableWidth, tableStartY, startX + tableWidth, startY)

            startY += 20

            ' Total section with GST
            Dim totalBoxWidth As Integer = 300
            Dim totalBoxStartX As Integer = startX + tableWidth - totalBoxWidth
            Dim totalBoxRect As New Rectangle(totalBoxStartX, startY, totalBoxWidth, offset * 5)
            Using path As New GraphicsPath()
                Dim radius As Integer = 10
                path.AddArc(totalBoxRect.X, totalBoxRect.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(totalBoxRect.Right - radius * 2, totalBoxRect.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(totalBoxRect.Right - radius * 2, totalBoxRect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(totalBoxRect.X, totalBoxRect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(New SolidBrush(Color.FromArgb(245, 255, 245)), path)
                e.Graphics.DrawPath(primaryPen, path)
            End Using

            Dim cgstAmount As Decimal = subTotal * cgstRate
            Dim sgstAmount As Decimal = subTotal * sgstRate
            Dim grandTotal As Decimal = subTotal + cgstAmount + sgstAmount

            e.Graphics.DrawString("Sub Total:", boldFont, secondaryColor, totalBoxStartX + 20, startY + 10)
            e.Graphics.DrawString(FormatCurrency(subTotal), boldFont, secondaryColor, totalBoxStartX + 180, startY + 10)
            startY += offset
            e.Graphics.DrawString("CGST (9%):", regularFont, secondaryColor, totalBoxStartX + 20, startY + 10)
            e.Graphics.DrawString(FormatCurrency(cgstAmount), regularFont, secondaryColor, totalBoxStartX + 180, startY + 10)
            startY += offset
            e.Graphics.DrawString("SGST (9%):", regularFont, secondaryColor, totalBoxStartX + 20, startY + 10)
            e.Graphics.DrawString(FormatCurrency(sgstAmount), regularFont, secondaryColor, totalBoxStartX + 180, startY + 10)
            startY += offset
            e.Graphics.DrawLine(primaryPen, totalBoxStartX + 10, startY + 15, totalBoxStartX + totalBoxWidth - 10, startY + 15)
            e.Graphics.DrawString("GRAND TOTAL:", boldFont, primaryColor, totalBoxStartX + 20, startY + 25)
            e.Graphics.DrawString(FormatCurrency(grandTotal), boldFont, primaryColor, totalBoxStartX + 180, startY + 25)

            startY += offset * 2

            ' Payment details
            Dim paymentBoxHeight As Integer = If(paymentMode = "Cash", offset * 3, offset * 5)
            Dim paymentBox As New Rectangle(startX, startY, pageWidth, paymentBoxHeight)
            Using path As New GraphicsPath()
                Dim radius As Integer = 15
                path.AddArc(paymentBox.X, paymentBox.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(paymentBox.Right - radius * 2, paymentBox.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(paymentBox.Right - radius * 2, paymentBox.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(paymentBox.X, paymentBox.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(New SolidBrush(Color.FromArgb(252, 252, 252)), path)
                e.Graphics.DrawPath(borderPen, path)
            End Using

            Dim paymentTitleRect As New Rectangle(startX + 15, startY - 15, 180, 25)
            e.Graphics.FillRectangle(New SolidBrush(Color.White), paymentTitleRect)
            e.Graphics.DrawString("PAYMENT INFORMATION", smallFont, primaryColor, paymentTitleRect)

            startY += 20
            e.Graphics.DrawString("Payment Mode: " & paymentMode, boldFont, Brushes.Black, startX + 40, startY)
            If paymentMode <> "Cash" Then
                startY += offset + 10
                e.Graphics.DrawString("Bank: " & bankName, regularFont, Brushes.Black, startX + 40, startY)
                startY += offset
                e.Graphics.DrawString("Card Number: " & MaskCardNumber(cardNumber), regularFont, Brushes.Black, startX + 40, startY)
                startY += offset
                e.Graphics.DrawString("Expiry Date: " & expiryDate, regularFont, Brushes.Black, startX + 40, startY)
            End If

            startY += paymentBoxHeight + 20

            ' Thank you message
            Dim thankYouRect As New Rectangle(startX, startY, pageWidth, offset * 3)
            Using path As New GraphicsPath()
                Dim radius As Integer = 15
                path.AddArc(thankYouRect.X, thankYouRect.Y, radius * 2, radius * 2, 180, 90)
                path.AddArc(thankYouRect.Right - radius * 2, thankYouRect.Y, radius * 2, radius * 2, 270, 90)
                path.AddArc(thankYouRect.Right - radius * 2, thankYouRect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
                path.AddArc(thankYouRect.X, thankYouRect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
                path.CloseFigure()
                e.Graphics.FillPath(New SolidBrush(Color.FromArgb(245, 255, 245)), path)
                e.Graphics.DrawPath(borderPen, path)
            End Using
            DrawCenteredString(e.Graphics, "Thank You for Choosing Krishi Saadhan!", italicFont, primaryColor, startX, startY + offset, pageWidth)

            startY += offset * 4

            ' Authorized Signatory
            Dim signatoryRect As New Rectangle(startX + pageWidth - 250, startY, 250, offset * 3)
            e.Graphics.DrawRectangle(borderPen, signatoryRect)
            e.Graphics.DrawString("Authorized Signatory", boldFont, primaryColor, signatoryRect.X + 20, signatoryRect.Y + 10)
            e.Graphics.DrawLine(borderPen, signatoryRect.X + 20, signatoryRect.Y + offset * 2, signatoryRect.X + 230, signatoryRect.Y + offset * 2)

            ' Footer
            Dim footerY As Integer = e.PageBounds.Height - 60
            DrawCenteredString(e.Graphics, "For queries: " & companyPhone & " | " & companyEmail, smallFont, secondaryColor, startX, footerY, pageWidth)
            DrawCenteredString(e.Graphics, "This is a computer-generated invoice.", smallFont, secondaryColor, startX, footerY + 20, pageWidth)

            RaiseEvent PrintCompleted()

        Catch ex As Exception
            MessageBox.Show("Error during printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function FormatCurrency(value As Object) As String
        Try
            Dim amount As Decimal = CDec(value)
            Return Format(amount, "##,##0.00")
        Catch
            Return "0.00"
        End Try
    End Function

    Private Function MaskCardNumber(cardNumber As String) As String
        If String.IsNullOrEmpty(cardNumber) Then Return ""
        Dim lastFourDigits As String = cardNumber.Substring(Math.Max(0, cardNumber.Length - 4))
        Dim maskedPart As String = New String("X"c, Math.Max(0, cardNumber.Length - 4))
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