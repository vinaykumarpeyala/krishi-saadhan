﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
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
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelCardDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(130, 75)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(130, 202)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerAddress.TabIndex = 1
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(130, 163)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerEmail.TabIndex = 2
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(130, 120)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPhone.TabIndex = 3
        '
        'dgvBillDetails
        '
        Me.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillDetails.Location = New System.Drawing.Point(12, 394)
        Me.dgvBillDetails.Name = "dgvBillDetails"
        Me.dgvBillDetails.RowHeadersWidth = 51
        Me.dgvBillDetails.RowTemplate.Height = 24
        Me.dgvBillDetails.Size = New System.Drawing.Size(632, 209)
        Me.dgvBillDetails.TabIndex = 4
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(130, 29)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(100, 22)
        Me.txtCustID.TabIndex = 5
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmPayment.Location = New System.Drawing.Point(10, 74)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(119, 52)
        Me.btnConfirmPayment.TabIndex = 6
        Me.btnConfirmPayment.Text = "CONFIRM PAYMENT"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'btnSaveDetails
        '
        Me.btnSaveDetails.BackColor = System.Drawing.Color.FloralWhite
        Me.btnSaveDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveDetails.Location = New System.Drawing.Point(163, 16)
        Me.btnSaveDetails.Name = "btnSaveDetails"
        Me.btnSaveDetails.Size = New System.Drawing.Size(109, 48)
        Me.btnSaveDetails.TabIndex = 7
        Me.btnSaveDetails.Text = "SAVE"
        Me.btnSaveDetails.UseVisualStyleBackColor = False
        Me.btnSaveDetails.Visible = False
        '
        'dgvCustomerDetails
        '
        Me.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerDetails.Location = New System.Drawing.Point(275, 118)
        Me.dgvCustomerDetails.Name = "dgvCustomerDetails"
        Me.dgvCustomerDetails.RowHeadersWidth = 51
        Me.dgvCustomerDetails.RowTemplate.Height = 24
        Me.dgvCustomerDetails.Size = New System.Drawing.Size(583, 176)
        Me.dgvCustomerDetails.TabIndex = 8
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.BackColor = System.Drawing.Color.White
        Me.lblCustID.Location = New System.Drawing.Point(20, 29)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(95, 16)
        Me.lblCustID.TabIndex = 9
        Me.lblCustID.Text = "Customer ID:"
        Me.lblCustID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Customer Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "E-Mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Address:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Khaki
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(163, 78)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 51)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdoDebit)
        Me.GroupBox1.Controls.Add(Me.rdoCredit)
        Me.GroupBox1.Controls.Add(Me.rdoCash)
        Me.GroupBox1.Controls.Add(Me.PanelCardDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(679, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 308)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'rdoDebit
        '
        Me.rdoDebit.AutoSize = True
        Me.rdoDebit.BackColor = System.Drawing.Color.Cornsilk
        Me.rdoDebit.Location = New System.Drawing.Point(46, 185)
        Me.rdoDebit.Name = "rdoDebit"
        Me.rdoDebit.Size = New System.Drawing.Size(109, 20)
        Me.rdoDebit.TabIndex = 3
        Me.rdoDebit.TabStop = True
        Me.rdoDebit.Text = "DEBIT CARD"
        Me.rdoDebit.UseVisualStyleBackColor = False
        '
        'rdoCredit
        '
        Me.rdoCredit.AutoSize = True
        Me.rdoCredit.BackColor = System.Drawing.Color.Moccasin
        Me.rdoCredit.Location = New System.Drawing.Point(46, 124)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(119, 20)
        Me.rdoCredit.TabIndex = 2
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "CREDIT CARD"
        Me.rdoCredit.UseVisualStyleBackColor = False
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.rdoCash.Location = New System.Drawing.Point(46, 60)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(65, 20)
        Me.rdoCash.TabIndex = 1
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "CASH"
        Me.rdoCash.UseVisualStyleBackColor = False
        '
        'PanelCardDetails
        '
        Me.PanelCardDetails.BackColor = System.Drawing.Color.Transparent
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
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CARD PAYMENT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
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
        Me.Label8.BackColor = System.Drawing.Color.Silver
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
        Me.Label7.BackColor = System.Drawing.Color.Silver
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
        Me.Label6.BackColor = System.Drawing.Color.LightGray
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
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.PeachPuff
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.Location = New System.Drawing.Point(10, 16)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(119, 48)
        Me.btnProceed.TabIndex = 17
        Me.btnProceed.Text = "PROCEED"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnProceed)
        Me.Panel1.Controls.Add(Me.btnSaveDetails)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnConfirmPayment)
        Me.Panel1.Location = New System.Drawing.Point(904, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 173)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtCustID)
        Me.Panel2.Controls.Add(Me.txtCustomerName)
        Me.Panel2.Controls.Add(Me.txtCustomerPhone)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtCustomerEmail)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCustomerAddress)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblCustID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 233)
        Me.Panel2.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Labeldate)
        Me.Panel3.Controls.Add(Me.Labeltime)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Location = New System.Drawing.Point(2, -4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1282, 73)
        Me.Panel3.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(1190, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(90, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 32)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Krishi Saadhan"
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldate.Location = New System.Drawing.Point(1030, 8)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(69, 19)
        Me.Labeldate.TabIndex = 4
        Me.Labeldate.Text = "Label13"
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Location = New System.Drawing.Point(1038, 41)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(61, 17)
        Me.Labeltime.TabIndex = 3
        Me.Labeltime.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(955, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "TIME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(955, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "DATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(294, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 40)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "BILL"
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1283, 628)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCustomerDetails)
        Me.Controls.Add(Me.dgvBillDetails)
        Me.Name = "BillForm"
        Me.Text = "Form8"
        CType(Me.dgvBillDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelCardDetails.ResumeLayout(False)
        Me.PanelCardDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnClear As Button
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
    Friend WithEvents rdoDebit As RadioButton
    Friend WithEvents rdoCredit As RadioButton
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents btnProceed As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Labeldate As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
End Class
