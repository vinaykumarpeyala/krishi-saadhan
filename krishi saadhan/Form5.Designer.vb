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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.txtBatchQuantity = New System.Windows.Forms.TextBox()
        Me.pnlAddStock = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveStock = New System.Windows.Forms.Button()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.homepage = New System.Windows.Forms.Button()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddStock.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(124, 18)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 22)
        Me.txtProductID.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(124, 83)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(124, 205)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(124, 143)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 3
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(35, 329)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(867, 256)
        Me.dgvProducts.TabIndex = 4
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(124, 255)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmbCategory.TabIndex = 5
        '
        'pbProductImage
        '
        Me.pbProductImage.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbProductImage.ErrorImage = Nothing
        Me.pbProductImage.Location = New System.Drawing.Point(966, 305)
        Me.pbProductImage.Name = "pbProductImage"
        Me.pbProductImage.Size = New System.Drawing.Size(226, 238)
        Me.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProductImage.TabIndex = 6
        Me.pbProductImage.TabStop = False
        '
        'btnAddImage
        '
        Me.btnAddImage.Location = New System.Drawing.Point(1066, 562)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(75, 23)
        Me.btnAddImage.TabIndex = 7
        Me.btnAddImage.Text = "Button1"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(966, 123)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Button2"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(783, 123)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Button3"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1136, 123)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Button4"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(783, 205)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Button5"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Label4"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(57, 24)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(48, 16)
        Me.lblProductID.TabIndex = 16
        Me.lblProductID.Text = "Label5"
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(140, 38)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchID.TabIndex = 17
        '
        'txtBatchQuantity
        '
        Me.txtBatchQuantity.Location = New System.Drawing.Point(140, 87)
        Me.txtBatchQuantity.Name = "txtBatchQuantity"
        Me.txtBatchQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchQuantity.TabIndex = 18
        '
        'pnlAddStock
        '
        Me.pnlAddStock.Controls.Add(Me.Label8)
        Me.pnlAddStock.Controls.Add(Me.Label7)
        Me.pnlAddStock.Controls.Add(Me.Label6)
        Me.pnlAddStock.Controls.Add(Me.btnSaveStock)
        Me.pnlAddStock.Controls.Add(Me.txtUnitPrice)
        Me.pnlAddStock.Controls.Add(Me.txtBatchID)
        Me.pnlAddStock.Controls.Add(Me.txtBatchQuantity)
        Me.pnlAddStock.Location = New System.Drawing.Point(326, 18)
        Me.pnlAddStock.Name = "pnlAddStock"
        Me.pnlAddStock.Size = New System.Drawing.Size(360, 221)
        Me.pnlAddStock.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Label6"
        '
        'btnSaveStock
        '
        Me.btnSaveStock.Location = New System.Drawing.Point(140, 178)
        Me.btnSaveStock.Name = "btnSaveStock"
        Me.btnSaveStock.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveStock.TabIndex = 20
        Me.btnSaveStock.Text = "Button2"
        Me.btnSaveStock.UseVisualStyleBackColor = True
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(140, 134)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitPrice.TabIndex = 19
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(1113, 216)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 20
        Me.btnReturn.Text = "Button5"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(697, 263)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(75, 23)
        Me.btnAddStock.TabIndex = 21
        Me.btnAddStock.Text = "Button1"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(466, 279)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 22)
        Me.txtSearch.TabIndex = 22
        '
        'homepage
        '
        Me.homepage.Location = New System.Drawing.Point(1093, 24)
        Me.homepage.Name = "homepage"
        Me.homepage.Size = New System.Drawing.Size(75, 23)
        Me.homepage.TabIndex = 23
        Me.homepage.Text = "Button1"
        Me.homepage.UseVisualStyleBackColor = True
        '
        'ProductManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1248, 607)
        Me.Controls.Add(Me.homepage)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.pnlAddStock)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.pbProductImage)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtProductID)
        Me.Name = "ProductManagementForm"
        Me.Text = "Form5"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddStock.ResumeLayout(False)
        Me.pnlAddStock.PerformLayout()
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
    Friend WithEvents Label2 As Label
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
    Friend WithEvents homepage As Button
End Class
