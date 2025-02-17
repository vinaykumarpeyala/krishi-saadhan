<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellerDashboard
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
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.numericQuantity = New System.Windows.Forms.NumericUpDown()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.btnGenerateTotal = New System.Windows.Forms.Button()
        Me.btnAddToBill = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProceedToBill = New System.Windows.Forms.Button()
        Me.txtAvailableStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxProduct = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        CType(Me.numericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(106, 51)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(106, 152)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 1
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(106, 105)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 22)
        Me.txtCategory.TabIndex = 2
        '
        'numericQuantity
        '
        Me.numericQuantity.Location = New System.Drawing.Point(106, 264)
        Me.numericQuantity.Name = "numericQuantity"
        Me.numericQuantity.Size = New System.Drawing.Size(120, 22)
        Me.numericQuantity.TabIndex = 3
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(21, 364)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(735, 241)
        Me.dgvProducts.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(310, 296)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(194, 22)
        Me.txtSearch.TabIndex = 5
        '
        'dgvBilling
        '
        Me.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBilling.Location = New System.Drawing.Point(565, 140)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.RowHeadersWidth = 51
        Me.dgvBilling.RowTemplate.Height = 24
        Me.dgvBilling.Size = New System.Drawing.Size(492, 175)
        Me.dgvBilling.TabIndex = 6
        '
        'btnGenerateTotal
        '
        Me.btnGenerateTotal.Location = New System.Drawing.Point(137, 34)
        Me.btnGenerateTotal.Name = "btnGenerateTotal"
        Me.btnGenerateTotal.Size = New System.Drawing.Size(92, 40)
        Me.btnGenerateTotal.TabIndex = 7
        Me.btnGenerateTotal.Text = "Generate Total"
        Me.btnGenerateTotal.UseVisualStyleBackColor = True
        '
        'btnAddToBill
        '
        Me.btnAddToBill.Location = New System.Drawing.Point(15, 34)
        Me.btnAddToBill.Name = "btnAddToBill"
        Me.btnAddToBill.Size = New System.Drawing.Size(92, 40)
        Me.btnAddToBill.TabIndex = 8
        Me.btnAddToBill.Text = "Add To Bill"
        Me.btnAddToBill.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(964, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Search :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(788, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label6"
        '
        'btnProceedToBill
        '
        Me.btnProceedToBill.Location = New System.Drawing.Point(81, 95)
        Me.btnProceedToBill.Name = "btnProceedToBill"
        Me.btnProceedToBill.Size = New System.Drawing.Size(91, 51)
        Me.btnProceedToBill.TabIndex = 16
        Me.btnProceedToBill.Text = "Proceed To Bill"
        Me.btnProceedToBill.UseVisualStyleBackColor = True
        '
        'txtAvailableStock
        '
        Me.txtAvailableStock.Location = New System.Drawing.Point(106, 199)
        Me.txtAvailableStock.Name = "txtAvailableStock"
        Me.txtAvailableStock.Size = New System.Drawing.Size(100, 22)
        Me.txtAvailableStock.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Avl Stock:"
        '
        'PictureBoxProduct
        '
        Me.PictureBoxProduct.Location = New System.Drawing.Point(830, 383)
        Me.PictureBoxProduct.Name = "PictureBoxProduct"
        Me.PictureBoxProduct.Size = New System.Drawing.Size(178, 187)
        Me.PictureBoxProduct.TabIndex = 19
        Me.PictureBoxProduct.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGenerateTotal)
        Me.Panel1.Controls.Add(Me.btnAddToBill)
        Me.Panel1.Controls.Add(Me.btnProceedToBill)
        Me.Panel1.Location = New System.Drawing.Point(276, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 158)
        Me.Panel1.TabIndex = 20
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(106, 228)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchID.TabIndex = 21
        '
        'SellerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(1082, 617)
        Me.Controls.Add(Me.txtBatchID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBoxProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAvailableStock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.numericQuantity)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Name = "SellerDashboard"
        Me.Text = "Form4"
        CType(Me.numericQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents numericQuantity As NumericUpDown
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents btnGenerateTotal As Button
    Friend WithEvents btnAddToBill As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProceedToBill As Button
    Friend WithEvents txtAvailableStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBoxProduct As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBatchID As TextBox
End Class
