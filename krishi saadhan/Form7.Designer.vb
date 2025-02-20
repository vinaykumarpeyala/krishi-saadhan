<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerManagementForm
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
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.dgvCustomerSales = New System.Windows.Forms.DataGridView()
        Me.btnAddUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnFetchCustomerSales = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomerDetails = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        CType(Me.dgvCustomerSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(152, 56)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerName.TabIndex = 0
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(152, 155)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerEmail.TabIndex = 1
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(152, 106)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPhone.TabIndex = 2
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(152, 199)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerAddress.TabIndex = 3
        '
        'dgvCustomerSales
        '
        Me.dgvCustomerSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerSales.Location = New System.Drawing.Point(52, 311)
        Me.dgvCustomerSales.Name = "dgvCustomerSales"
        Me.dgvCustomerSales.RowHeadersWidth = 51
        Me.dgvCustomerSales.RowTemplate.Height = 24
        Me.dgvCustomerSales.Size = New System.Drawing.Size(690, 248)
        Me.dgvCustomerSales.TabIndex = 4
        '
        'btnAddUpdateCustomer
        '
        Me.btnAddUpdateCustomer.Location = New System.Drawing.Point(15, 17)
        Me.btnAddUpdateCustomer.Name = "btnAddUpdateCustomer"
        Me.btnAddUpdateCustomer.Size = New System.Drawing.Size(120, 55)
        Me.btnAddUpdateCustomer.TabIndex = 5
        Me.btnAddUpdateCustomer.Text = "ADD/UPDATE"
        Me.btnAddUpdateCustomer.UseVisualStyleBackColor = True
        '
        'btnFetchCustomerSales
        '
        Me.btnFetchCustomerSales.Location = New System.Drawing.Point(141, 17)
        Me.btnFetchCustomerSales.Name = "btnFetchCustomerSales"
        Me.btnFetchCustomerSales.Size = New System.Drawing.Size(120, 51)
        Me.btnFetchCustomerSales.TabIndex = 6
        Me.btnFetchCustomerSales.Text = "FETCH"
        Me.btnFetchCustomerSales.UseVisualStyleBackColor = True
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(20, 92)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(115, 51)
        Me.btnSearchCustomer.TabIndex = 7
        Me.btnSearchCustomer.Text = "Button3"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'dgvCustomerDetails
        '
        Me.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerDetails.Location = New System.Drawing.Point(399, 82)
        Me.dgvCustomerDetails.Name = "dgvCustomerDetails"
        Me.dgvCustomerDetails.RowHeadersWidth = 51
        Me.dgvCustomerDetails.RowTemplate.Height = 24
        Me.dgvCustomerDetails.Size = New System.Drawing.Size(475, 190)
        Me.dgvCustomerDetails.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CustomerName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Phone Number:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCustomerID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCustomerName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCustomerPhone)
        Me.Panel1.Controls.Add(Me.txtCustomerEmail)
        Me.Panel1.Controls.Add(Me.txtCustomerAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(27, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 257)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnAddUpdateCustomer)
        Me.Panel2.Controls.Add(Me.btnFetchCustomerSales)
        Me.Panel2.Controls.Add(Me.btnSearchCustomer)
        Me.Panel2.Location = New System.Drawing.Point(920, 110)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 172)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Customer ID"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(152, 14)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerID.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 51)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1233, -11)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 593)
        Me.VScrollBar1.TabIndex = 15
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(-3, 582)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(1437, 153)
        Me.HScrollBar1.TabIndex = 16
        '
        'CustomerManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1254, 602)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvCustomerDetails)
        Me.Controls.Add(Me.dgvCustomerSales)
        Me.Name = "CustomerManagementForm"
        Me.Text = "Form7"
        CType(Me.dgvCustomerSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents dgvCustomerSales As DataGridView
    Friend WithEvents btnAddUpdateCustomer As Button
    Friend WithEvents btnFetchCustomerSales As Button
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents dgvCustomerDetails As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
