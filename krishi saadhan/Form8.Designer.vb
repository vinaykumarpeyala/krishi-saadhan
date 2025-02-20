<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.dgvBillDetails = New System.Windows.Forms.DataGridView()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.btnSaveDetails = New System.Windows.Forms.Button()
        Me.dgvCustomerDetails = New System.Windows.Forms.DataGridView()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoDebit = New System.Windows.Forms.RadioButton()
        Me.rdoCredit = New System.Windows.Forms.RadioButton()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.PanelCardDetails = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.ComboBoxBankName = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelCardDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(130, 83)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(130, 229)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerAddress.TabIndex = 1
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(130, 181)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerEmail.TabIndex = 2
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(130, 129)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPhone.TabIndex = 3
        '
        'dgvBillDetails
        '
        Me.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillDetails.Location = New System.Drawing.Point(27, 306)
        Me.dgvBillDetails.Name = "dgvBillDetails"
        Me.dgvBillDetails.RowHeadersWidth = 51
        Me.dgvBillDetails.RowTemplate.Height = 24
        Me.dgvBillDetails.Size = New System.Drawing.Size(603, 217)
        Me.dgvBillDetails.TabIndex = 4
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(130, 43)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(100, 22)
        Me.txtCustID.TabIndex = 5
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.Location = New System.Drawing.Point(24, 74)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(109, 52)
        Me.btnConfirmPayment.TabIndex = 6
        Me.btnConfirmPayment.Text = "Confirm Payment"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'btnSaveDetails
        '
        Me.btnSaveDetails.Location = New System.Drawing.Point(152, 21)
        Me.btnSaveDetails.Name = "btnSaveDetails"
        Me.btnSaveDetails.Size = New System.Drawing.Size(109, 48)
        Me.btnSaveDetails.TabIndex = 7
        Me.btnSaveDetails.Text = "Save"
        Me.btnSaveDetails.UseVisualStyleBackColor = True
        Me.btnSaveDetails.Visible = False
        '
        'dgvCustomerDetails
        '
        Me.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerDetails.Location = New System.Drawing.Point(249, 49)
        Me.dgvCustomerDetails.Name = "dgvCustomerDetails"
        Me.dgvCustomerDetails.RowHeadersWidth = 51
        Me.dgvCustomerDetails.RowTemplate.Height = 24
        Me.dgvCustomerDetails.Size = New System.Drawing.Size(366, 176)
        Me.dgvCustomerDetails.TabIndex = 8
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(36, 43)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(83, 16)
        Me.lblCustID.TabIndex = 9
        Me.lblCustID.Text = "Customer ID:"
        Me.lblCustID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "E-Mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address:"
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Location = New System.Drawing.Point(150, 75)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(111, 51)
        Me.btnPrintBill.TabIndex = 14
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoDebit)
        Me.GroupBox1.Controls.Add(Me.rdoCredit)
        Me.GroupBox1.Controls.Add(Me.rdoCash)
        Me.GroupBox1.Controls.Add(Me.PanelCardDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(665, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 288)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'rdoDebit
        '
        Me.rdoDebit.AutoSize = True
        Me.rdoDebit.Location = New System.Drawing.Point(46, 185)
        Me.rdoDebit.Name = "rdoDebit"
        Me.rdoDebit.Size = New System.Drawing.Size(109, 20)
        Me.rdoDebit.TabIndex = 3
        Me.rdoDebit.TabStop = True
        Me.rdoDebit.Text = "DEBIT CARD"
        Me.rdoDebit.UseVisualStyleBackColor = True
        '
        'rdoCredit
        '
        Me.rdoCredit.AutoSize = True
        Me.rdoCredit.Location = New System.Drawing.Point(46, 124)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(119, 20)
        Me.rdoCredit.TabIndex = 2
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "CREDIT CARD"
        Me.rdoCredit.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(46, 51)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(65, 20)
        Me.rdoCash.TabIndex = 1
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "CASH"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'PanelCardDetails
        '
        Me.PanelCardDetails.Controls.Add(Me.Label1)
        Me.PanelCardDetails.Controls.Add(Me.Label9)
        Me.PanelCardDetails.Controls.Add(Me.txtExpiryDate)
        Me.PanelCardDetails.Controls.Add(Me.Label8)
        Me.PanelCardDetails.Controls.Add(Me.Label7)
        Me.PanelCardDetails.Controls.Add(Me.Label6)
        Me.PanelCardDetails.Controls.Add(Me.txtCVV)
        Me.PanelCardDetails.Controls.Add(Me.txtCardNumber)
        Me.PanelCardDetails.Controls.Add(Me.ComboBoxBankName)
        Me.PanelCardDetails.Location = New System.Drawing.Point(193, 34)
        Me.PanelCardDetails.Name = "PanelCardDetails"
        Me.PanelCardDetails.Size = New System.Drawing.Size(326, 234)
        Me.PanelCardDetails.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CARD PAYMENT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Expiry Date:"
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Location = New System.Drawing.Point(155, 194)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(100, 22)
        Me.txtExpiryDate.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CVV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Card No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Select Bank:"
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(155, 145)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(100, 22)
        Me.txtCVV.TabIndex = 2
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(155, 91)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(104, 22)
        Me.txtCardNumber.TabIndex = 1
        '
        'ComboBoxBankName
        '
        Me.ComboBoxBankName.FormattingEnabled = True
        Me.ComboBoxBankName.Location = New System.Drawing.Point(155, 47)
        Me.ComboBoxBankName.Name = "ComboBoxBankName"
        Me.ComboBoxBankName.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxBankName.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1053, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(22, 23)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(111, 45)
        Me.btnProceed.TabIndex = 17
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnProceed)
        Me.Panel1.Controls.Add(Me.btnSaveDetails)
        Me.Panel1.Controls.Add(Me.btnPrintBill)
        Me.Panel1.Controls.Add(Me.btnConfirmPayment)
        Me.Panel1.Location = New System.Drawing.Point(694, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 154)
        Me.Panel1.TabIndex = 18
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1229, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.dgvCustomerDetails)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.dgvBillDetails)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Name = "BillForm"
        Me.Text = "Form8"
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelCardDetails.ResumeLayout(False)
        Me.PanelCardDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents dgvBillDetails As DataGridView
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents btnSaveDetails As Button
    Friend WithEvents dgvCustomerDetails As DataGridView
    Friend WithEvents lblCustID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPrintBill As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelCardDetails As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtExpiryDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents ComboBoxBankName As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rdoDebit As RadioButton
    Friend WithEvents rdoCredit As RadioButton
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents btnProceed As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
