<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.ManageStock = New System.Windows.Forms.Button()
        Me.btnManageCustomers = New System.Windows.Forms.Button()
        Me.ManageUsers = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonManageCategories = New System.Windows.Forms.Button()
        Me.ManageProducts = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.PanelManageCategories = New System.Windows.Forms.Panel()
        Me.ButtonAddCategory = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelManageCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Location = New System.Drawing.Point(574, 243)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCategory.TabIndex = 0
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Location = New System.Drawing.Point(204, 303)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.RowHeadersWidth = 51
        Me.DataGridViewProducts.RowTemplate.Height = 24
        Me.DataGridViewProducts.Size = New System.Drawing.Size(856, 261)
        Me.DataGridViewProducts.TabIndex = 1
        '
        'ManageStock
        '
        Me.ManageStock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ManageStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageStock.Location = New System.Drawing.Point(11, 22)
        Me.ManageStock.Name = "ManageStock"
        Me.ManageStock.Size = New System.Drawing.Size(175, 69)
        Me.ManageStock.TabIndex = 2
        Me.ManageStock.Text = "Manage Stock"
        Me.ManageStock.UseVisualStyleBackColor = False
        '
        'btnManageCustomers
        '
        Me.btnManageCustomers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnManageCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageCustomers.Location = New System.Drawing.Point(11, 268)
        Me.btnManageCustomers.Name = "btnManageCustomers"
        Me.btnManageCustomers.Size = New System.Drawing.Size(175, 75)
        Me.btnManageCustomers.TabIndex = 3
        Me.btnManageCustomers.Text = "Manage Customers"
        Me.btnManageCustomers.UseVisualStyleBackColor = False
        '
        'ManageUsers
        '
        Me.ManageUsers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ManageUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageUsers.Location = New System.Drawing.Point(11, 184)
        Me.ManageUsers.Name = "ManageUsers"
        Me.ManageUsers.Size = New System.Drawing.Size(175, 78)
        Me.ManageUsers.TabIndex = 4
        Me.ManageUsers.Text = "Manage Sellers"
        Me.ManageUsers.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(11, 353)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(175, 70)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Generate reports"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonManageCategories)
        Me.Panel1.Controls.Add(Me.ManageProducts)
        Me.Panel1.Controls.Add(Me.ManageStock)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.ManageUsers)
        Me.Panel1.Controls.Add(Me.btnManageCustomers)
        Me.Panel1.Location = New System.Drawing.Point(1, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 516)
        Me.Panel1.TabIndex = 7
        '
        'ButtonManageCategories
        '
        Me.ButtonManageCategories.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonManageCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonManageCategories.Location = New System.Drawing.Point(11, 429)
        Me.ButtonManageCategories.Name = "ButtonManageCategories"
        Me.ButtonManageCategories.Size = New System.Drawing.Size(175, 75)
        Me.ButtonManageCategories.TabIndex = 8
        Me.ButtonManageCategories.Text = "Manage Categories"
        Me.ButtonManageCategories.UseVisualStyleBackColor = False
        '
        'ManageProducts
        '
        Me.ManageProducts.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ManageProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageProducts.Location = New System.Drawing.Point(11, 103)
        Me.ManageProducts.Name = "ManageProducts"
        Me.ManageProducts.Size = New System.Drawing.Size(175, 70)
        Me.ManageProducts.TabIndex = 7
        Me.ManageProducts.Text = "Manage Products"
        Me.ManageProducts.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1070, 14)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(98, 27)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "LOG OUT"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 37)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "KRISHI SAADHAN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Labeldate)
        Me.Panel2.Controls.Add(Me.Labeltime)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1192, 76)
        Me.Panel2.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Cyan
        Me.Label8.Location = New System.Drawing.Point(847, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TIME"
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldate.ForeColor = System.Drawing.Color.Gold
        Me.Labeldate.Location = New System.Drawing.Point(937, 18)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(60, 19)
        Me.Labeldate.TabIndex = 16
        Me.Labeldate.Text = "Label7"
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltime.ForeColor = System.Drawing.Color.Gold
        Me.Labeltime.Location = New System.Drawing.Point(937, 51)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(60, 19)
        Me.Labeltime.TabIndex = 15
        Me.Labeltime.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(844, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DATE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1190, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 589)
        Me.VScrollBar1.TabIndex = 14
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(201, 579)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(992, 13)
        Me.HScrollBar1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Category Name:"
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(132, 52)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxCategory.TabIndex = 17
        '
        'PanelManageCategories
        '
        Me.PanelManageCategories.BackColor = System.Drawing.Color.Transparent
        Me.PanelManageCategories.Controls.Add(Me.ButtonAddCategory)
        Me.PanelManageCategories.Controls.Add(Me.Label4)
        Me.PanelManageCategories.Controls.Add(Me.Label3)
        Me.PanelManageCategories.Controls.Add(Me.TextBoxCategory)
        Me.PanelManageCategories.Location = New System.Drawing.Point(848, 113)
        Me.PanelManageCategories.Name = "PanelManageCategories"
        Me.PanelManageCategories.Size = New System.Drawing.Size(256, 132)
        Me.PanelManageCategories.TabIndex = 18
        '
        'ButtonAddCategory
        '
        Me.ButtonAddCategory.Location = New System.Drawing.Point(93, 87)
        Me.ButtonAddCategory.Name = "ButtonAddCategory"
        Me.ButtonAddCategory.Size = New System.Drawing.Size(119, 33)
        Me.ButtonAddCategory.TabIndex = 19
        Me.ButtonAddCategory.Text = "Add Category"
        Me.ButtonAddCategory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "CATEGORIES:"
        '
        'Timer1
        '
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1202, 592)
        Me.Controls.Add(Me.PanelManageCategories)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewProducts)
        Me.Controls.Add(Me.ComboBoxCategory)
        Me.Name = "AdminDashboard"
        Me.Text = "Form3"
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelManageCategories.ResumeLayout(False)
        Me.PanelManageCategories.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCategory As ComboBox
    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents ManageStock As Button
    Friend WithEvents btnManageCustomers As Button
    Friend WithEvents ManageUsers As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ManageProducts As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents PanelManageCategories As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonAddCategory As Button
    Friend WithEvents ButtonManageCategories As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Labeldate As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
End Class
