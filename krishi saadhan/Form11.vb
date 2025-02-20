Imports System.Data.SqlClient

Public Class ResetPasswordForm
    Private ReadOnly username As String
    Private ReadOnly connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;"

    ' Constructor to accept username
    Public Sub New(user As String)
        InitializeComponent()
        username = user
    End Sub

    ' Event handler for Submit button click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newPassword As String = txtNewPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' Validate input fields
        If String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Both password fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if passwords match
        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Update the password in the database
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim updateQuery As String = "UPDATE Users SET Password = @Password WHERE Username = @Username"
                Using cmd As New SqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@Password", newPassword) ' Store password as plain text
                    cmd.Parameters.AddWithValue("@Username", username)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoginForm.Show() ' Show the login form
                        Me.Close() ' Close the reset password form
                    Else
                        MessageBox.Show("Error updating password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()
    End Sub


End Class