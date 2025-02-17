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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillForm))
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCvv = New System.Windows.Forms.TextBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.ComboBoxBankName = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelCardDetails.SuspendLayout()
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
        Me.dgvBillDetails.Location = New System.Drawing.Point(12, 319)
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
        Me.btnConfirmPayment.Location = New System.Drawing.Point(928, 135)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmPayment.TabIndex = 6
        Me.btnConfirmPayment.Text = "Button1"
        Me.btnConfirmPayment.UseVisualStyleBackColor = True
        '
        'btnSaveDetails
        '
        Me.btnSaveDetails.Location = New System.Drawing.Point(112, 287)
        Me.btnSaveDetails.Name = "btnSaveDetails"
        Me.btnSaveDetails.Size = New System.Drawing.Size(75, 23)
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
        Me.lblCustID.Location = New System.Drawing.Point(55, 49)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(42, 16)
        Me.lblCustID.TabIndex = 9
        Me.lblCustID.Text = "custid"
        Me.lblCustID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Label5"
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Location = New System.Drawing.Point(748, 132)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintBill.TabIndex = 14
        Me.btnPrintBill.Text = "Button3"
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
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rdoDebit
        '
        Me.rdoDebit.AutoSize = True
        Me.rdoDebit.Location = New System.Drawing.Point(46, 185)
        Me.rdoDebit.Name = "rdoDebit"
        Me.rdoDebit.Size = New System.Drawing.Size(109, 20)
        Me.rdoDebit.TabIndex = 3
        Me.rdoDebit.TabStop = True
        Me.rdoDebit.Text = "RadioButton3"
        Me.rdoDebit.UseVisualStyleBackColor = True
        '
        'rdoCredit
        '
        Me.rdoCredit.AutoSize = True
        Me.rdoCredit.Location = New System.Drawing.Point(46, 128)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(109, 20)
        Me.rdoCredit.TabIndex = 2
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "RadioButton2"
        Me.rdoCredit.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(32, 52)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(109, 20)
        Me.rdoCash.TabIndex = 1
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "RadioButton1"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'PanelCardDetails
        '
        Me.PanelCardDetails.Controls.Add(Me.Label9)
        Me.PanelCardDetails.Controls.Add(Me.txtExpiryDate)
        Me.PanelCardDetails.Controls.Add(Me.Label8)
        Me.PanelCardDetails.Controls.Add(Me.Label7)
        Me.PanelCardDetails.Controls.Add(Me.Label6)
        Me.PanelCardDetails.Controls.Add(Me.txtCvv)
        Me.PanelCardDetails.Controls.Add(Me.txtCardNumber)
        Me.PanelCardDetails.Controls.Add(Me.ComboBoxBankName)
        Me.PanelCardDetails.Location = New System.Drawing.Point(166, 34)
        Me.PanelCardDetails.Name = "PanelCardDetails"
        Me.PanelCardDetails.Size = New System.Drawing.Size(353, 234)
        Me.PanelCardDetails.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Location = New System.Drawing.Point(176, 188)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(100, 22)
        Me.txtExpiryDate.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Label6"
        '
        'txtCvv
        '
        Me.txtCvv.Location = New System.Drawing.Point(176, 145)
        Me.txtCvv.Name = "txtCvv"
        Me.txtCvv.Size = New System.Drawing.Size(100, 22)
        Me.txtCvv.TabIndex = 2
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(176, 94)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(104, 22)
        Me.txtCardNumber.TabIndex = 1
        '
        'ComboBoxBankName
        '
        Me.ComboBoxBankName.FormattingEnabled = True
        Me.ComboBoxBankName.Location = New System.Drawing.Point(176, 42)
        Me.ComboBoxBankName.Name = "ComboBoxBankName"
        Me.ComboBoxBankName.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxBankName.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1022, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 16
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 542)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.dgvCustomerDetails)
        Me.Controls.Add(Me.btnSaveDetails)
        Me.Controls.Add(Me.btnConfirmPayment)
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
    Friend WithEvents txtCvv As TextBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents ComboBoxBankName As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents rdoDebit As RadioButton
    Friend WithEvents rdoCredit As RadioButton
    Friend WithEvents rdoCash As RadioButton
End Class
