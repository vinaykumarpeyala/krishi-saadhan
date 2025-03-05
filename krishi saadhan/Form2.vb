Imports System.Data.SqlClient

Public Class LoginForm
    ' Connection string for the database
    Private ReadOnly conString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;"

    ' Form load event to set password character and event handlers
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c ' Mask the password field
        PictureBox4.Image = My.Resources.bluehide ' Set the initial image to bluehide

        ' Ensure the textboxes accept the Enter key as input
        txtUsername.AcceptsReturn = False
        txtPassword.AcceptsReturn = False
    End Sub

    ' Add function to validate input fields
    Private Function ValidateFields() As Boolean
        If txtUsername.Text.Trim() = "" And txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill in both of the fields to login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return False
        ElseIf txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Please enter your username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return False
        ElseIf txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If
        Return True
    End Function

    ' Login button click event handler with updated validation
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if fields are valid before proceeding
        If Not ValidateFields() Then
            Return
        End If

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim isAdminChecked As Boolean = chkAdmin.Checked

        Try
            Using conn As New SqlConnection(conString)
                conn.Open()

                ' Query to fetch user details
                Dim query As String = "SELECT UserID, Password, Role FROM Users WHERE Username = @Username"
                Using cmd As New SqlCommand(query, conn)
                    cmd.CommandTimeout = 60 ' Set timeout to 60 seconds
                    cmd.Parameters.AddWithValue("@Username", username)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim userId As Integer = Convert.ToInt32(reader("UserID"))
                            Dim dbPassword As String = reader("Password").ToString()
                            Dim role As String = reader("Role").ToString()

                            ' Handle admin login - check both conditions
                            If role = "Admin" AndAlso Not isAdminChecked Then
                                MessageBox.Show("Please check the Admin checkbox to login as Admin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            ElseIf role = "Seller" AndAlso isAdminChecked Then
                                MessageBox.Show("You don't have admin privileges. Please uncheck the Admin checkbox.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Validate password
                            If password = dbPassword Then
                                If role = "Admin" AndAlso isAdminChecked Then
                                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    AdminDashboard.Show() ' Redirect to Admin Dashboard
                                    Me.Hide()
                                ElseIf role = "Seller" Then
                                    ' The rest of your seller login code remains the same
                                    If password.StartsWith("temp@") Then
                                        MessageBox.Show("Temporary password verified! Redirecting to Reset Password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Dim resetForm As New ResetPasswordForm(username) ' Redirect to Reset Password form
                                        resetForm.Show()
                                        Me.Hide()
                                    Else
                                        MessageBox.Show(txtUsername.Text + " Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        ' Redirect to seller dashboard or other appropriate form
                                        Dim sellerDashboard As New SellerDashboard(userId)
                                        If sellerDashboard IsNot Nothing Then
                                            sellerDashboard.Show()
                                            Me.Hide()
                                        Else
                                            MessageBox.Show("Error loading Seller Dashboard. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        End If
                                    End If
                                End If
                            Else
                                MessageBox.Show("Invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            ' Exception handling remains the same
            If ex.Number = -2 Then
                MessageBox.Show("Server timeout. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Replace the KeyDown events with KeyPress events for better compatibility
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
            e.Handled = True ' Prevents the "ding" sound
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick() ' Simulates clicking the login button
            e.Handled = True
        End If
    End Sub

    ' Alternative approach using the Form's ProcessCmdKey method
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            If txtUsername.Focused Then
                txtPassword.Focus()
                Return True
            ElseIf txtPassword.Focused Then
                btnLogin.PerformClick()
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' Clear Button Functionality
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        chkAdmin.Checked = False
        txtUsername.Focus()
    End Sub

    ' Exit Button Functionality
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Forgot Password LinkLabel Click Event
    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        MessageBox.Show("Please contact the admin to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Show the password
            PictureBox4.Image = My.Resources.bey1 ' Use the image for hiding the password
        Else
            txtPassword.PasswordChar = "*"c ' Mask the password
            PictureBox4.Image = My.Resources.bluehide ' Use the image for showing the password
        End If
    End Sub
End Class