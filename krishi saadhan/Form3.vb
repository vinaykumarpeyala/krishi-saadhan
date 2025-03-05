Imports System.Data.SqlClient
Imports System.IO

Public Class AdminDashboard
    Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;"
    Dim isCategoriesLoaded As Boolean = False ' Flag to handle ComboBox initialization


    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        LoadCategories()
            LoadProductData()
            PanelManageCategories.Visible = False
            TextBoxCategory.Visible = False
            ButtonAddCategory.Visible = False
            LoadExpiredStockMessages()

    End Sub

    ' Method to load categories into the ComboBox
    Private Sub LoadCategories()
        Try
            Dim query As String = "SELECT CategoryID, CategoryName FROM Categories"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    Dim categories As New DataTable()
                    categories.Load(reader)
                    ComboBoxCategory.DataSource = categories
                    ComboBoxCategory.DisplayMember = "CategoryName"
                    ComboBoxCategory.ValueMember = "CategoryID"
                End Using
            End Using
            isCategoriesLoaded = True
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    ' Method to load product data into the DataGridView
    Private Sub LoadProductData(Optional categoryID As Integer? = Nothing, Optional sortByStock As Boolean = False)
        Try
            Dim query As String = "SELECT p.ProductID, p.ProductName, c.CategoryName, p.Price, p.StockQuantity " &
                                  "FROM Products p " &
                                  "JOIN Categories c ON p.CategoryID = c.CategoryID"
            If categoryID.HasValue Then
                query &= " WHERE c.CategoryID = @CategoryID"
            End If
            If sortByStock Then
                query &= " ORDER BY p.StockQuantity ASC"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    If categoryID.HasValue Then
                        command.Parameters.AddWithValue("@CategoryID", categoryID.Value)
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    Dim products As New DataTable()
                    adapter.Fill(products)
                    DataGridViewProducts.DataSource = products
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    ' Method to load expired stock messages from the log file
    Private Sub LoadExpiredStockMessages()
        Try
            Dim logFilePath As String = Path.Combine(Application.StartupPath, "ExpiredStockLog.txt")
            If File.Exists(logFilePath) Then
                Dim messages As String() = File.ReadAllLines(logFilePath)
                lstExpiredStockMessages.Items.Clear()

                ' Only add non-empty messages
                Dim hasValidMessages As Boolean = False
                For Each msg In messages
                    If Not String.IsNullOrWhiteSpace(msg) Then
                        lstExpiredStockMessages.Items.Add(msg)
                        hasValidMessages = True
                    End If
                Next

                ' Only show the alert and make controls visible if there are valid messages
                If hasValidMessages Then
                    lstExpiredStockMessages.Visible = True
                    btnHideExpiredMessages.Visible = True
                    MessageBox.Show($"Attention: {lstExpiredStockMessages.Items.Count} expired stock messages found. Please review and take action.",
                               "Stock Expiry Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    lstExpiredStockMessages.Visible = False
                    btnHideExpiredMessages.Visible = False
                End If
            Else
                lstExpiredStockMessages.Items.Add("No expired stock messages found.")
                lstExpiredStockMessages.Visible = False
                btnHideExpiredMessages.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading expired stock messages: " & ex.Message)
        End Try
    End Sub

    ' Button click event to hide the ListBox and clear the log file
    Private Sub btnHideExpiredMessages_Click(sender As Object, e As EventArgs) Handles btnHideExpiredMessages.Click
        Try
            Dim logFilePath As String = Path.Combine(Application.StartupPath, "ExpiredStockLog.txt")
            If File.Exists(logFilePath) Then
                File.WriteAllText(logFilePath, "") ' Clear the log file
            End If
            lstExpiredStockMessages.Items.Clear()
            lstExpiredStockMessages.Visible = False
            btnHideExpiredMessages.Visible = False
            MessageBox.Show("Expired stock messages cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error clearing expired stock messages: " & ex.Message)
        End Try
    End Sub

    ' Event triggered when the category is selected from ComboBox
    Private Sub ComboBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCategory.SelectedIndexChanged
        If Not isCategoriesLoaded Then Exit Sub
        Try
            If ComboBoxCategory.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBoxCategory.SelectedValue) Then
                Dim selectedCategoryID As Integer = Convert.ToInt32(ComboBoxCategory.SelectedValue)
                LoadProductData(selectedCategoryID)
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering products by category: " & ex.Message)
        End Try
    End Sub

    ' Button click event for "Manage Products"
    Private Sub ManageProducts_Click(sender As Object, e As EventArgs) Handles ManageProducts.Click
        Dim productForm As New ProductManagementForm()
        productForm.Show()
    End Sub

    ' Button click event for "Manage Users"
    Private Sub ManageUsers_Click(sender As Object, e As EventArgs) Handles ManageUsers.Click
        Dim usermanagementform As New frmUserManagement()
        usermanagementform.Show()
    End Sub

    ' Button click event for "Manage Stock"
    Private Sub ManageStock_Click(sender As Object, e As EventArgs) Handles ManageStock.Click
        Dim stockmanagement As New StockManagementForm()
        stockmanagement.Show()
    End Sub

    ' Button click event for "Manage Customers"
    Private Sub btnManageCustomers_Click(sender As Object, e As EventArgs) Handles btnManageCustomers.Click
        Dim customermanagement As New CustomerManagementForm()
        customermanagement.Show()
    End Sub

    ' Button click event for "Logout"
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim log As New LoginForm()
        log.Show()
    End Sub

    ' Button click event for "Reports"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim reports As New ReportGenerationForm()
        reports.Show()
    End Sub

    ' Button click event for "Manage Categories"
    Private Sub ButtonManageCategories_Click(sender As Object, e As EventArgs) Handles ButtonManageCategories.Click
        PanelManageCategories.Visible = True
        TextBoxCategory.Visible = True
        ButtonAddCategory.Visible = True
    End Sub

    ' Button click event for "Add Category"
    Private Sub ButtonAddCategory_Click(sender As Object, e As EventArgs) Handles ButtonAddCategory.Click
        Try
            Dim categoryName As String = TextBoxCategory.Text.Trim()
            If Not String.IsNullOrEmpty(categoryName) Then
                Dim query As String = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)"
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CategoryName", categoryName)
                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Category added successfully.")
                LoadCategories()
                PanelManageCategories.Visible = False
            Else
                MessageBox.Show("Please enter a category name.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error adding category: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Labeldate.Text = DateTime.Now.ToString("dd/MM/yyyy ")
        Labeltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class