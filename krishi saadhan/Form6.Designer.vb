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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockManagementForm))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblStockId = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(204, 393)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(900, 234)
        Me.dgvProducts.TabIndex = 0
        '
        'btnAddStock
        '
        Me.btnAddStock.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAddStock.Location = New System.Drawing.Point(25, 14)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(149, 64)
        Me.btnAddStock.TabIndex = 1
        Me.btnAddStock.Text = "ADD STOCK"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(48, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(48, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Batch Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(60, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Batch ID"
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnUpdateStock.Location = New System.Drawing.Point(207, 14)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(136, 64)
        Me.btnUpdateStock.TabIndex = 16
        Me.btnUpdateStock.Text = "UPDATE STOCK"
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnDeleteStock.Location = New System.Drawing.Point(25, 90)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(149, 66)
        Me.btnDeleteStock.TabIndex = 17
        Me.btnDeleteStock.Text = "DELETE STOCK"
        Me.btnDeleteStock.UseVisualStyleBackColor = False
        '
        'txtBatchId
        '
        Me.txtBatchId.Location = New System.Drawing.Point(156, 142)
        Me.txtBatchId.Name = "txtBatchId"
        Me.txtBatchId.Size = New System.Drawing.Size(137, 22)
        Me.txtBatchId.TabIndex = 18
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(156, 230)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(137, 22)
        Me.txtUnitPrice.TabIndex = 19
        '
        'txtBatchQuantity
        '
        Me.txtBatchQuantity.Location = New System.Drawing.Point(156, 183)
        Me.txtBatchQuantity.Name = "txtBatchQuantity"
        Me.txtBatchQuantity.Size = New System.Drawing.Size(137, 22)
        Me.txtBatchQuantity.TabIndex = 20
        '
        'btnCheckLowStock
        '
        Me.btnCheckLowStock.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCheckLowStock.Location = New System.Drawing.Point(375, 14)
        Me.btnCheckLowStock.Name = "btnCheckLowStock"
        Me.btnCheckLowStock.Size = New System.Drawing.Size(136, 64)
        Me.btnCheckLowStock.TabIndex = 22
        Me.btnCheckLowStock.Text = "CHECK FOR LOW STOCK"
        Me.btnCheckLowStock.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(591, 348)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(162, 22)
        Me.txtSearch.TabIndex = 23
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(156, 52)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(137, 22)
        Me.txtProductId.TabIndex = 24
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(156, 96)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(137, 22)
        Me.txtProductName.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(69, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Unit Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(493, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Search"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(48, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Product ID"
        '
        'btnReturnToHomePage
        '
        Me.btnReturnToHomePage.BackColor = System.Drawing.Color.Pink
        Me.btnReturnToHomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToHomePage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReturnToHomePage.Location = New System.Drawing.Point(1173, 10)
        Me.btnReturnToHomePage.Name = "btnReturnToHomePage"
        Me.btnReturnToHomePage.Size = New System.Drawing.Size(83, 28)
        Me.btnReturnToHomePage.TabIndex = 29
        Me.btnReturnToHomePage.Text = "EXIT"
        Me.btnReturnToHomePage.UseVisualStyleBackColor = False
        '
        'txtStockId
        '
        Me.txtStockId.Location = New System.Drawing.Point(156, 15)
        Me.txtStockId.Name = "txtStockId"
        Me.txtStockId.Size = New System.Drawing.Size(137, 22)
        Me.txtStockId.TabIndex = 30
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aquamarine
        Me.btnRefresh.Location = New System.Drawing.Point(375, 90)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(136, 66)
        Me.btnRefresh.TabIndex = 31
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnDeleteBatchQuantity
        '
        Me.btnDeleteBatchQuantity.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDeleteBatchQuantity.Location = New System.Drawing.Point(207, 90)
        Me.btnDeleteBatchQuantity.Name = "btnDeleteBatchQuantity"
        Me.btnDeleteBatchQuantity.Size = New System.Drawing.Size(136, 66)
        Me.btnDeleteBatchQuantity.TabIndex = 32
        Me.btnDeleteBatchQuantity.Text = "REMOVE QUANTITY"
        Me.btnDeleteBatchQuantity.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblStockId)
        Me.Panel1.Controls.Add(Me.txtStockId)
        Me.Panel1.Controls.Add(Me.txtProductId)
        Me.Panel1.Controls.Add(Me.txtProductName)
        Me.Panel1.Controls.Add(Me.txtBatchId)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtBatchQuantity)
        Me.Panel1.Controls.Add(Me.txtUnitPrice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(31, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 281)
        Me.Panel1.TabIndex = 33
        '
        'lblStockId
        '
        Me.lblStockId.AutoSize = True
        Me.lblStockId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStockId.Location = New System.Drawing.Point(60, 21)
        Me.lblStockId.Name = "lblStockId"
        Me.lblStockId.Size = New System.Drawing.Size(57, 16)
        Me.lblStockId.TabIndex = 31
        Me.lblStockId.Text = "StockID:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.btnAddStock)
        Me.Panel2.Controls.Add(Me.btnUpdateStock)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnDeleteBatchQuantity)
        Me.Panel2.Controls.Add(Me.btnDeleteStock)
        Me.Panel2.Controls.Add(Me.btnCheckLowStock)
        Me.Panel2.Location = New System.Drawing.Point(524, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 172)
        Me.Panel2.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(573, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(389, 37)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "STOCK MANAGEMENT"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Crimson
        Me.Panel3.Controls.Add(Me.Labeldate)
        Me.Panel3.Controls.Add(Me.Labeltime)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.btnReturnToHomePage)
        Me.Panel3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.Yellow
        Me.Panel3.Location = New System.Drawing.Point(4, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1266, 65)
        Me.Panel3.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 32)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Krishi Saadhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(948, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 19)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "TIME"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(948, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "DATE"
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltime.Location = New System.Drawing.Point(1037, 35)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(68, 19)
        Me.Labeltime.TabIndex = 34
        Me.Labeltime.Text = "Label11"
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldate.Location = New System.Drawing.Point(1036, 10)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(40, 19)
        Me.Labeldate.TabIndex = 35
        Me.Labeldate.Text = "date"
        '
        'Timer1
        '
        '
        'StockManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1272, 629)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "StockManagementForm"
        Me.Text = "Form6"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStockId As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Labeldate As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
