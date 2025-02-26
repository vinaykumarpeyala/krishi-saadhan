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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellerDashboard))
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
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnClearBill = New System.Windows.Forms.Button()
        Me.txtBatchID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.numericQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(135, 78)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(135, 171)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 1
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(135, 128)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 22)
        Me.txtCategory.TabIndex = 2
        '
        'numericQuantity
        '
        Me.numericQuantity.Location = New System.Drawing.Point(126, 294)
        Me.numericQuantity.Name = "numericQuantity"
        Me.numericQuantity.Size = New System.Drawing.Size(120, 22)
        Me.numericQuantity.TabIndex = 3
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Location = New System.Drawing.Point(12, 381)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(737, 241)
        Me.dgvProducts.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(312, 322)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(194, 22)
        Me.txtSearch.TabIndex = 5
        '
        'dgvBilling
        '
        Me.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBilling.Location = New System.Drawing.Point(578, 157)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.RowHeadersWidth = 51
        Me.dgvBilling.RowTemplate.Height = 24
        Me.dgvBilling.Size = New System.Drawing.Size(492, 175)
        Me.dgvBilling.TabIndex = 6
        '
        'btnGenerateTotal
        '
        Me.btnGenerateTotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerateTotal.Location = New System.Drawing.Point(127, 22)
        Me.btnGenerateTotal.Name = "btnGenerateTotal"
        Me.btnGenerateTotal.Size = New System.Drawing.Size(102, 56)
        Me.btnGenerateTotal.TabIndex = 7
        Me.btnGenerateTotal.Text = "GENERATE TOTAL"
        Me.btnGenerateTotal.UseVisualStyleBackColor = False
        '
        'btnAddToBill
        '
        Me.btnAddToBill.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAddToBill.Location = New System.Drawing.Point(14, 22)
        Me.btnAddToBill.Name = "btnAddToBill"
        Me.btnAddToBill.Size = New System.Drawing.Size(107, 56)
        Me.btnAddToBill.TabIndex = 8
        Me.btnAddToBill.Text = "ADD TO BILL"
        Me.btnAddToBill.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.GreenYellow
        Me.Button3.Location = New System.Drawing.Point(967, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "LOG OUT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(225, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Search :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(782, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bill Items"
        '
        'btnProceedToBill
        '
        Me.btnProceedToBill.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnProceedToBill.Location = New System.Drawing.Point(14, 84)
        Me.btnProceedToBill.Name = "btnProceedToBill"
        Me.btnProceedToBill.Size = New System.Drawing.Size(107, 51)
        Me.btnProceedToBill.TabIndex = 16
        Me.btnProceedToBill.Text = "PROCEED TO BILL"
        Me.btnProceedToBill.UseVisualStyleBackColor = False
        '
        'txtAvailableStock
        '
        Me.txtAvailableStock.Location = New System.Drawing.Point(135, 213)
        Me.txtAvailableStock.Name = "txtAvailableStock"
        Me.txtAvailableStock.Size = New System.Drawing.Size(100, 22)
        Me.txtAvailableStock.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Avl Stock:"
        '
        'PictureBoxProduct
        '
        Me.PictureBoxProduct.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxProduct.Location = New System.Drawing.Point(809, 381)
        Me.PictureBoxProduct.Name = "PictureBoxProduct"
        Me.PictureBoxProduct.Size = New System.Drawing.Size(183, 214)
        Me.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxProduct.TabIndex = 19
        Me.PictureBoxProduct.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnRemoveItem)
        Me.Panel1.Controls.Add(Me.btnClearBill)
        Me.Panel1.Controls.Add(Me.btnGenerateTotal)
        Me.Panel1.Controls.Add(Me.btnAddToBill)
        Me.Panel1.Controls.Add(Me.btnProceedToBill)
        Me.Panel1.Location = New System.Drawing.Point(280, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 201)
        Me.Panel1.TabIndex = 20
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnRemoveItem.Location = New System.Drawing.Point(53, 141)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(134, 45)
        Me.btnRemoveItem.TabIndex = 18
        Me.btnRemoveItem.Text = "REMOVE ITEMS"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnClearBill
        '
        Me.btnClearBill.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnClearBill.Location = New System.Drawing.Point(127, 84)
        Me.btnClearBill.Name = "btnClearBill"
        Me.btnClearBill.Size = New System.Drawing.Size(102, 51)
        Me.btnClearBill.TabIndex = 17
        Me.btnClearBill.Text = "CLEAR"
        Me.btnClearBill.UseVisualStyleBackColor = False
        '
        'txtBatchID
        '
        Me.txtBatchID.Location = New System.Drawing.Point(135, 258)
        Me.txtBatchID.Name = "txtBatchID"
        Me.txtBatchID.Size = New System.Drawing.Size(100, 22)
        Me.txtBatchID.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Labeltime)
        Me.Panel2.Controls.Add(Me.Labeldate)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1093, 60)
        Me.Panel2.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(109, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 32)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Krishi Saadhan"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Azure
        Me.lblSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSubTotal.Location = New System.Drawing.Point(853, 344)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(68, 23)
        Me.lblSubTotal.TabIndex = 23
        Me.lblSubTotal.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "BatchID"
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labeldate.Location = New System.Drawing.Point(855, 9)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(61, 17)
        Me.Labeldate.TabIndex = 13
        Me.Labeldate.Text = "Label10"
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labeltime.Location = New System.Drawing.Point(855, 30)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(54, 17)
        Me.Labeltime.TabIndex = 14
        Me.Labeltime.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(767, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "DATE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(767, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "TIME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        '
        'SellerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1094, 631)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Panel2)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClearBill As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Labeldate As Label
    Friend WithEvents Timer1 As Timer
End Class
