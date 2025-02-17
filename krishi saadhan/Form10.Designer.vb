<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.grpUserDetails = New System.Windows.Forms.GroupBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.GroupBoxResetPassword = New System.Windows.Forms.GroupBox()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtSellerUsername = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpUserDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxResetPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(86, 64)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(162, 22)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(86, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(162, 22)
        Me.txtPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(102, 172)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 24)
        Me.cmbRole.TabIndex = 4
        '
        'grpUserDetails
        '
        Me.grpUserDetails.Controls.Add(Me.txtUsername)
        Me.grpUserDetails.Controls.Add(Me.Label2)
        Me.grpUserDetails.Controls.Add(Me.cmbRole)
        Me.grpUserDetails.Controls.Add(Me.Label1)
        Me.grpUserDetails.Controls.Add(Me.txtPassword)
        Me.grpUserDetails.Location = New System.Drawing.Point(94, 56)
        Me.grpUserDetails.Name = "grpUserDetails"
        Me.grpUserDetails.Size = New System.Drawing.Size(329, 228)
        Me.grpUserDetails.TabIndex = 5
        Me.grpUserDetails.TabStop = False
        Me.grpUserDetails.Text = "GroupBox1"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(35, 25)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Button1"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(207, 25)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Button1"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(389, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Button1"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegister)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(539, 345)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(544, 193)
        Me.dgvUsers.TabIndex = 10
        '
        'GroupBoxResetPassword
        '
        Me.GroupBoxResetPassword.Controls.Add(Me.btnResetPassword)
        Me.GroupBoxResetPassword.Controls.Add(Me.txtNewPassword)
        Me.GroupBoxResetPassword.Controls.Add(Me.txtSellerUsername)
        Me.GroupBoxResetPassword.Location = New System.Drawing.Point(645, 83)
        Me.GroupBoxResetPassword.Name = "GroupBoxResetPassword"
        Me.GroupBoxResetPassword.Size = New System.Drawing.Size(352, 201)
        Me.GroupBoxResetPassword.TabIndex = 11
        Me.GroupBoxResetPassword.TabStop = False
        Me.GroupBoxResetPassword.Text = "GroupBox2"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Location = New System.Drawing.Point(105, 145)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(75, 23)
        Me.btnResetPassword.TabIndex = 2
        Me.btnResetPassword.Text = "Button1"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(79, 96)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtSellerUsername
        '
        Me.txtSellerUsername.Location = New System.Drawing.Point(79, 43)
        Me.txtSellerUsername.Name = "txtSellerUsername"
        Me.txtSellerUsername.Size = New System.Drawing.Size(100, 22)
        Me.txtSellerUsername.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(487, 277)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Button1"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 558)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBoxResetPassword)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpUserDetails)
        Me.Name = "frmUserManagement"
        Me.Text = "Form10"
        Me.grpUserDetails.ResumeLayout(False)
        Me.grpUserDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxResetPassword.ResumeLayout(False)
        Me.GroupBoxResetPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents grpUserDetails As GroupBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents GroupBoxResetPassword As GroupBox
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtSellerUsername As TextBox
    Friend WithEvents btnReset As Button
End Class
