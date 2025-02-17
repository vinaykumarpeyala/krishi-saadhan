Imports System.Data.SqlClient
Imports System.IO

Public Class ProductManagementForm
    Dim con As New SqlConnection("Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim imagePath As String

    Private Sub ProductManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadProducts()
        txtProductID.Visible = False
        lblProductID.Visible = False
        btnAddStock.Visible = False ' Hide Add Stock button initially
        pnlAddStock.Visible = False ' Hide Add Stock panel initially
    End Sub

    Private Sub LoadCategories()
        Try
            Dim query As String = "SELECT CategoryID, CategoryName FROM Categories"
            da = New SqlDataAdapter(query, con)
            dt = New DataTable()
            da.Fill(dt)
            cmbCategory.DataSource = dt
            cmbCategory.DisplayMember = "CategoryName"
            cmbCategory.ValueMember = "CategoryID"
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadProducts()
        Try
            Dim query As String = "SELECT ProductID, ProductName, CategoryID, Price, StockQuantity, ProductPhoto FROM Products"
            da = New SqlDataAdapter(query, con)
            dt = New DataTable()
            da.Fill(dt)
            dgvProducts.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button to Upload Image
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Try
            ' Open FileDialog to select an image and display it in the PictureBox
            Using openFileDialog As New OpenFileDialog
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                openFileDialog.Title = "Select Product Photo"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Load selected image into PictureBox
                    pbProductImage.Image = Image.FromFile(openFileDialog.FileName)
                    imagePath = openFileDialog.FileName
                End If
            End Using

            ' Validate if image has been selected
            If pbProductImage.Image Is Nothing Then
                MessageBox.Show("Please upload an image for the product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button to Add Product
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           cmbCategory.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("Please fill all fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if an image has been uploaded
        If pbProductImage.Image Is Nothing Then
            MessageBox.Show("Please upload an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Convert image to byte array
            Dim imageData As Byte()
            Using ms As New MemoryStream()
                pbProductImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageData = ms.ToArray()
            End Using

            Dim query As String = "INSERT INTO Products (ProductName, CategoryID, Price, StockQuantity, ProductPhoto) VALUES (@name, @category, @price, @quantity, @image)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", txtProductName.Text)
                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedValue)
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))
                cmd.Parameters.AddWithValue("@image", imageData)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("Product Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProducts()
            ClearFields()
            btnAddStock.Visible = True ' Show Add Stock button after successful insertion
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            ' Assign values to text fields
            txtProductID.Text = row.Cells("ProductID").Value.ToString()
            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            cmbCategory.SelectedValue = row.Cells("CategoryID").Value
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtQuantity.Text = row.Cells("StockQuantity").Value.ToString()

            ' Load image if available
            If Not IsDBNull(row.Cells("ProductPhoto").Value) Then
                Dim imgBytes As Byte() = CType(row.Cells("ProductPhoto").Value, Byte())
                If imgBytes.Length > 0 Then
                    Using ms As New MemoryStream(imgBytes)
                        pbProductImage.Image = Image.FromStream(ms)
                    End Using
                Else
                    pbProductImage.Image = Nothing
                End If
            Else
                pbProductImage.Image = Nothing
            End If

            ' Show Product ID label
            txtProductID.Visible = True
            lblProductID.Visible = True
            btnAddStock.Visible = True ' Show Add Stock button when a product is selected
        End If
    End Sub

    ' Button to Update Product
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtProductID.Text) Then
            MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim updateImagePath As Boolean = False
        Dim imageData As Byte() = Nothing
        Dim result As DialogResult = MessageBox.Show("Do you want to update the product image?", "Update Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Open File Dialog to select a new image
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Load the selected image into the PictureBox
                pbProductImage.Image = Image.FromFile(openFileDialog.FileName)

                ' Convert the image to a byte array
                Using ms As New MemoryStream()
                    pbProductImage.Image.Save(ms, pbProductImage.Image.RawFormat)
                    imageData = ms.ToArray()
                    updateImagePath = True
                End Using
            Else
                MessageBox.Show("No image selected. Existing image will remain unchanged.", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        Try
            Dim query As String
            If updateImagePath Then
                query = "UPDATE Products SET ProductName=@name, CategoryID=@category, Price=@price, StockQuantity=@quantity, ProductPhoto=@image WHERE ProductID=@id"
            Else
                query = "UPDATE Products SET ProductName=@name, CategoryID=@category, Price=@price, StockQuantity=@quantity WHERE ProductID=@id"
            End If

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductID.Text))
                cmd.Parameters.AddWithValue("@name", txtProductName.Text)
                cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedValue)
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text))
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtQuantity.Text))

                If updateImagePath Then
                    cmd.Parameters.AddWithValue("@image", imageData)
                End If

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProducts()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtProductID.Text) Then
            MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Check if the product has stock in the Stock table
            Dim checkStockQuery As String = "SELECT COUNT(*) FROM Stock WHERE ProductID=@id"
            Using cmd As New SqlCommand(checkStockQuery, con)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductID.Text))

                con.Open()
                Dim stockCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                con.Close()

                If stockCount > 0 Then
                    MessageBox.Show("Cannot delete product with existing stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' If no stock, confirm deletion
                    If MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        Dim deleteQuery As String = "DELETE FROM Products WHERE ProductID=@id"
                        Using cmdDelete As New SqlCommand(deleteQuery, con)
                            cmdDelete.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductID.Text))

                            con.Open()
                            cmdDelete.ExecuteNonQuery()
                            con.Close()

                            MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    End If
                End If
            End Using

            LoadProducts()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub ClearFields()
        txtProductID.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        pbProductImage.Image = Nothing
        pnlAddStock.Visible = False ' Hide Add Stock panel when fields are cleared
        txtProductID.Visible = False
        lblProductID.Visible = False
        imagePath = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()

    End Sub

    ' Button to Redirect to Admin Dashboard
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim adminDashboard As New AdminDashboard()
        adminDashboard.Show()
        Me.Close()
    End Sub

    ' Add Stock Button Click
    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        If String.IsNullOrWhiteSpace(txtProductID.Text) Then
            MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pnlAddStock.Visible = True ' Show Add Stock panel
    End Sub

    ' Save Stock Button Click
    Private Sub btnSaveStock_Click(sender As Object, e As EventArgs) Handles btnSaveStock.Click
        If String.IsNullOrWhiteSpace(txtBatchID.Text) OrElse String.IsNullOrWhiteSpace(txtBatchQuantity.Text) OrElse String.IsNullOrWhiteSpace(txtUnitPrice.Text) Then
            MessageBox.Show("Please enter batch ID, batch quantity, and unit price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Insert new stock entry
            Dim insertStockQuery As String = "INSERT INTO Stock (BatchID, ProductID, BatchQuantity, UnitPrice) VALUES (@batchID, @id, @quantity, @unitprice)"
            Using cmd As New SqlCommand(insertStockQuery, con)
                cmd.Parameters.AddWithValue("@batchID", txtBatchID.Text)
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductID.Text))
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtBatchQuantity.Text))
                cmd.Parameters.AddWithValue("@unitprice", Convert.ToDecimal(txtUnitPrice.Text))

                con.Open()
                cmd.ExecuteNonQuery()

                ' Update the StockQuantity in the Products table
                Dim updateProductQuery As String = "UPDATE Products SET StockQuantity = StockQuantity + @quantity WHERE ProductID = @id"
                Using cmdUpdate As New SqlCommand(updateProductQuery, con)
                    cmdUpdate.Parameters.AddWithValue("@quantity", Convert.ToInt32(txtBatchQuantity.Text))
                    cmdUpdate.Parameters.AddWithValue("@id", Convert.ToInt32(txtProductID.Text))
                    cmdUpdate.ExecuteNonQuery()
                End Using

                con.Close()
            End Using

            MessageBox.Show("Stock added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            pnlAddStock.Visible = False ' Hide Add Stock panel after saving
            txtBatchID.Clear()
            txtBatchQuantity.Clear()
            txtUnitPrice.Clear()
            LoadProducts() ' Refresh the product list to show updated stock quantity
        Catch ex As Exception
            MessageBox.Show("Error adding stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' Search TextBox Text Changed
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            LoadProducts()
        Else
            Dim query As String = "SELECT ProductID, ProductName, CategoryID, Price, StockQuantity, ProductPhoto FROM Products WHERE ProductName LIKE @searchText"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")

                da = New SqlDataAdapter(cmd)
                dt = New DataTable()
                da.Fill(dt)
                dgvProducts.DataSource = dt
            End Using
        End If
    End Sub

    Private Sub homepage_Click(sender As Object, e As EventArgs) Handles homepage.Click
        Dim adminpage As New AdminDashboard()
        adminpage.Show()

    End Sub
End Class