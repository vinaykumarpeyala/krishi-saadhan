<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductManagementForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductManagementForm))
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.pbProductImage = New System.Windows.Forms.PictureBox()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.txtBatchQuantity = New System.Windows.Forms.TextBox()
        Me.pnlAddStock = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveStock = New System.Windows.Forms.Button()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddStock.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(170, 45)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 22)
        Me.txtProductID.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(170, 91)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(170, 185)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(170, 137)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 3
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(26, 379)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(867, 225)
        Me.dgvProducts.TabIndex = 4
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(149, 225)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmbCategory.TabIndex = 5
        '
        'pbProductImage
        '
        Me.pbProductImage.BackColor = System.Drawing.Color.Transparent
        Me.pbProductImage.ErrorImage = Nothing
        Me.pbProductImage.Location = New System.Drawing.Point(962, 342)
        Me.pbProductImage.Name = "pbProductImage"
        Me.pbProductImage.Size = New System.Drawing.Size(226, 220)
        Me.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProductImage.TabIndex = 6
        Me.pbProductImage.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImage.Location = New System.Drawing.Point(1028, 571)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(112, 33)
        Me.btnAddImage.TabIndex = 7
        Me.btnAddImage.Text = "Add Image"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.PowderBlue
        Me.btnUpdate.Location = New System.Drawing.Point(167, 24)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 50)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update Product"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAdd.Location = New System.Drawing.Point(23, 24)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 50)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PowderBlue
        Me.btnClear.Location = New System.Drawing.Point(23, 80)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 46)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.PowderBlue
        Me.btnDelete.Location = New System.Drawing.Point(167, 81)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(137, 46)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete product"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select Category:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(58, 185)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(75, 18)
        Me.lblQuantity.TabIndex = 13
        Me.lblQuantity.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Product Name:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(50, 49)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(93, 18)
        Me.lblProductID.TabIndex = 16
        Me.lblProductID.Text = "Product ID:"
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(188, 60)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchID.TabIndex = 17
        '
        'txtBatchQuantity
        '
        Me.txtBatchQuantity.Location = New System.Drawing.Point(188, 109)
        Me.txtBatchQuantity.Name = "txtBatchQuantity"
        Me.txtBatchQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchQuantity.TabIndex = 18
        '
        'pnlAddStock
        '
        Me.pnlAddStock.BackColor = System.Drawing.Color.Transparent
        Me.pnlAddStock.Controls.Add(Me.Label9)
        Me.pnlAddStock.Controls.Add(Me.Label8)
        Me.pnlAddStock.Controls.Add(Me.Label7)
        Me.pnlAddStock.Controls.Add(Me.Label6)
        Me.pnlAddStock.Controls.Add(Me.btnSaveStock)
        Me.pnlAddStock.Controls.Add(Me.txtUnitPrice)
        Me.pnlAddStock.Controls.Add(Me.txtBatchID)
        Me.pnlAddStock.Controls.Add(Me.txtBatchQuantity)
        Me.pnlAddStock.Location = New System.Drawing.Point(390, 81)
        Me.pnlAddStock.Name = "pnlAddStock"
        Me.pnlAddStock.Size = New System.Drawing.Size(382, 239)
        Me.pnlAddStock.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "STOCK DETAILS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Unit Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "BatchQuantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Batch ID:"
        '
        'btnSaveStock
        '
        Me.btnSaveStock.BackColor = System.Drawing.Color.LightGreen
        Me.btnSaveStock.Location = New System.Drawing.Point(144, 191)
        Me.btnSaveStock.Name = "btnSaveStock"
        Me.btnSaveStock.Size = New System.Drawing.Size(137, 36)
        Me.btnSaveStock.TabIndex = 20
        Me.btnSaveStock.Text = "Save Stock"
        Me.btnSaveStock.UseVisualStyleBackColor = False
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(188, 155)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitPrice.TabIndex = 19
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(1172, 13)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(102, 26)
        Me.btnReturn.TabIndex = 20
        Me.btnReturn.Text = "LOG OUT"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnAddStock
        '
        Me.btnAddStock.BackColor = System.Drawing.Color.PowderBlue
        Me.btnAddStock.Location = New System.Drawing.Point(104, 140)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(134, 46)
        Me.btnAddStock.TabIndex = 21
        Me.btnAddStock.Text = "Add Stock"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(461, 342)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(178, 22)
        Me.txtSearch.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Filter:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAddStock)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(861, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 200)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Labeltime)
        Me.Panel2.Controls.Add(Me.Labeldate)
        Me.Panel2.Controls.Add(Me.btnReturn)
        Me.Panel2.Location = New System.Drawing.Point(1, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 71)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtProductID)
        Me.Panel3.Controls.Add(Me.txtProductName)
        Me.Panel3.Controls.Add(Me.txtPrice)
        Me.Panel3.Controls.Add(Me.txtQuantity)
        Me.Panel3.Controls.Add(Me.cmbCategory)
        Me.Panel3.Controls.Add(Me.lblProductID)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblQuantity)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(26, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 273)
        Me.Panel3.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PRODUCT DETAILS"
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labeldate.Location = New System.Drawing.Point(1024, 13)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(69, 19)
        Me.Labeldate.TabIndex = 21
        Me.Labeldate.Text = "Label10"
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labeltime.Location = New System.Drawing.Point(1024, 44)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(60, 17)
        Me.Labeltime.TabIndex = 22
        Me.Labeltime.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(920, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "TIME"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(920, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "DATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(115, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 32)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Krishi Saadhan"
        '
        'Timer1
        '
        '
        'ProductManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1287, 643)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pnlAddStock)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbProductImage)
        Me.Controls.Add(Me.dgvProducts)
        Me.Name = "ProductManagementForm"
        Me.Text = "Form5"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddStock.ResumeLayout(False)
        Me.pnlAddStock.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents pbProductImage As PictureBox
    Friend WithEvents btnAddImage As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents txtBatchID As TextBox
    Friend WithEvents txtBatchQuantity As TextBox
    Friend WithEvents pnlAddStock As Panel
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents btnSaveStock As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddStock As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Labeldate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
