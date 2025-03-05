Imports System.Data.SqlClient
Imports System.Text

Public Class frmUserManagement
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True"

    Private Sub LoadRoles()
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Seller")
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub LoadUsers()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT Username, Role FROM Users"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvUsers.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cmbRole.Text.Trim()

        If username = "" OrElse password = "" OrElse role = "" Then
            MessageBox.Show("All fields are required!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Username", username)
                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Username already exists!")
                        Return
                    End If
                End Using

                Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", (password))
                    cmd.Parameters.AddWithValue("@Role", role)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("User registered successfully!")
                LoadUsers()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error registering user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim role As String = cmbRole.Text.Trim()

        If username = "" OrElse role = "" Then
            MessageBox.Show("Enter username and new role!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE Users SET Role = @Role WHERE Username = @Username"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Role", role)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User role updated!")
                        LoadUsers()
                    Else
                        MessageBox.Show("User not found!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim username As String = txtUsername.Text.Trim()

        If username = "" Then
            MessageBox.Show("Enter username to delete!")
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM Users WHERE Username = @Username"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim rowsAffected = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully!")
                        LoadUsers()
                    Else
                        MessageBox.Show("User not found!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            txtUsername.Text = row.Cells("Username").Value.ToString()
            cmbRole.Text = row.Cells("Role").Value.ToString()
        End If
    End Sub

    ' Function to Generate a Temporary Password
    Private Function GenerateTemporaryPassword() As String
        ' Generate a temporary password with a fixed pattern
        Dim tempPassword As String = "temp@" & New Random().Next(1000, 9999).ToString()
        Return tempPassword
    End Function

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim username As String = txtSellerUsername.Text.Trim()

        If username = "" Then
            MessageBox.Show("Enter the seller username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Check if Seller Exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Role = 'Seller'"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Username", username)
                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists = 0 Then
                        MessageBox.Show("Seller not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Generate Temporary Password
                Dim tempPassword As String = GenerateTemporaryPassword()
                txtNewPassword.Text = tempPassword ' Display generated password

                ' Update Password in Database
                Dim updateQuery As String = "UPDATE Users SET Password = @Password WHERE Username = @Username AND Role = 'Seller'"
                Using updateCmd As New SqlCommand(updateQuery, conn)
                    updateCmd.Parameters.AddWithValue("@Password", tempPassword)
                    updateCmd.Parameters.AddWithValue("@Username", username)
                    updateCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Temporary password generated and updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Show Reset Password Form or GroupBox
                GroupBoxResetPassword.Visible = True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoles()
        LoadUsers()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = DateTime.Now.ToString("dd/MM/yyyy ")
        Label9.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub grpUserDetails_Enter(sender As Object, e As EventArgs) Handles grpUserDetails.Enter

    End Sub
End Class