Imports System.Data.SqlClient

Public Class LoginForm
    ' Connection string for the database
    Private ReadOnly conString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;"

    ' Form load event to set password character
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c ' Mask the password field
    End Sub

    ' Login button click event handler
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim isAdminChecked As Boolean = chkAdmin.Checked

        ' Validate fields
        If username = "" OrElse password = "" Then
            MessageBox.Show("Enter both username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

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

                            ' Handle admin login
                            If role = "Admin" AndAlso Not isAdminChecked Then
                                MessageBox.Show("Please check the Admin checkbox to login as Admin.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Validate password
                            If password = dbPassword Then
                                If role = "Admin" AndAlso isAdminChecked Then
                                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    AdminDashboard.Show() ' Redirect to Admin Dashboard
                                    Me.Hide()
                                ElseIf role = "Seller" Then
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
            If ex.Number = -2 Then
                MessageBox.Show("Server timeout. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Show Password Button Functionality
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Show the password
            btnShowPassword.Text = "Hide Password"
        Else
            txtPassword.PasswordChar = "*"c ' Mask the password
            btnShowPassword.Text = "Show Password"
        End If
    End Sub

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
End Class