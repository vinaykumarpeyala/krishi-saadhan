<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockManagementForm
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnDeleteStock = New System.Windows.Forms.Button()
        Me.txtBatchId = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtBatchQuantity = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCheckLowStock = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReturnToHomePage = New System.Windows.Forms.Button()
        Me.txtStockId = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDeleteBatchQuantity = New System.Windows.Forms.Button()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(12, 312)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(817, 266)
        Me.dgvProducts.TabIndex = 0
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(641, 73)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStock.TabIndex = 1
        Me.btnAddStock.Text = "Button1"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.Location = New System.Drawing.Point(781, 73)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateStock.TabIndex = 16
        Me.btnUpdateStock.Text = "Button2"
        Me.btnUpdateStock.UseVisualStyleBackColor = True
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.Location = New System.Drawing.Point(641, 141)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteStock.TabIndex = 17
        Me.btnDeleteStock.Text = "delete"
        Me.btnDeleteStock.UseVisualStyleBackColor = True
        '
        'txtBatchId
        '
        Me.txtBatchId.Location = New System.Drawing.Point(114, 141)
        Me.txtBatchId.Name = "txtBatchId"
        Me.txtBatchId.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchId.TabIndex = 18
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(114, 243)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitPrice.TabIndex = 19
        '
        'txtBatchQuantity
        '
        Me.txtBatchQuantity.Location = New System.Drawing.Point(114, 191)
        Me.txtBatchQuantity.Name = "txtBatchQuantity"
        Me.txtBatchQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchQuantity.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(934, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 22)
        Me.DateTimePicker1.TabIndex = 21
        '
        'btnCheckLowStock
        '
        Me.btnCheckLowStock.Location = New System.Drawing.Point(781, 141)
        Me.btnCheckLowStock.Name = "btnCheckLowStock"
        Me.btnCheckLowStock.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckLowStock.TabIndex = 22
        Me.btnCheckLowStock.Text = "Button4"
        Me.btnCheckLowStock.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(454, 243)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(162, 22)
        Me.txtSearch.TabIndex = 23
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(114, 54)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(100, 22)
        Me.txtProductId.TabIndex = 24
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(114, 101)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Label6"
        '
        'btnReturnToHomePage
        '
        Me.btnReturnToHomePage.Location = New System.Drawing.Point(1155, 13)
        Me.btnReturnToHomePage.Name = "btnReturnToHomePage"
        Me.btnReturnToHomePage.Size = New System.Drawing.Size(75, 23)
        Me.btnReturnToHomePage.TabIndex = 29
        Me.btnReturnToHomePage.Text = "Button1"
        Me.btnReturnToHomePage.UseVisualStyleBackColor = True
        '
        'txtStockId
        '
        Me.txtStockId.Location = New System.Drawing.Point(114, 14)
        Me.txtStockId.Name = "txtStockId"
        Me.txtStockId.Size = New System.Drawing.Size(100, 22)
        Me.txtStockId.TabIndex = 30
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(781, 204)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "Button1"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDeleteBatchQuantity
        '
        Me.btnDeleteBatchQuantity.Location = New System.Drawing.Point(641, 204)
        Me.btnDeleteBatchQuantity.Name = "btnDeleteBatchQuantity"
        Me.btnDeleteBatchQuantity.Size = New System.Drawing.Size(98, 42)
        Me.btnDeleteBatchQuantity.TabIndex = 32
        Me.btnDeleteBatchQuantity.Text = "remove quantity"
        Me.btnDeleteBatchQuantity.UseVisualStyleBackColor = True
        '
        'StockManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 590)
        Me.Controls.Add(Me.btnDeleteBatchQuantity)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtStockId)
        Me.Controls.Add(Me.btnReturnToHomePage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnCheckLowStock)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtBatchQuantity)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtBatchId)
        Me.Controls.Add(Me.btnDeleteStock)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "StockManagementForm"
        Me.Text = "Form6"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnAddStock As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnDeleteStock As Button
    Friend WithEvents txtBatchId As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtBatchQuantity As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnCheckLowStock As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReturnToHomePage As Button
    Friend WithEvents txtStockId As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDeleteBatchQuantity As Button
End Class
