Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ReportGenerationForm
    Private Sub ReportGenerationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the ComboBox with expanded chart options
        chartComboBox.Items.Add("Bar Chart")
        chartComboBox.Items.Add("Pie Chart")
        chartComboBox.Items.Add("Line Chart")
        chartComboBox.Items.Add("Area Chart")
        chartComboBox.Items.Add("Column Chart")
        chartComboBox.SelectedIndex = 0

        ' Set the DateTimePickers to today's date
        startDatePicker.Value = DateTime.Today
        endDatePicker.Value = DateTime.Today

        ' Explicitly load today's sales data
        LoadTodaysSalesData()
    End Sub

    Private Sub LoadTodaysSalesData()
        ' Get today's date and ensure it's used as both start and end date
        Dim today As DateTime = DateTime.Today

        ' Fetch today's sales data
        Dim salesData As DataTable = GetSalesData(today, today)

        ' Display the data in the DataGridView - ensure it's not null
        If salesData IsNot Nothing Then
            reportDataGridView.DataSource = salesData
        End If

        ' Load top products for today
        LoadTopProducts(today, today)

        ' Generate chart for today's data
        If reportDataGridView.DataSource IsNot Nothing Then
            chartDisplayButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub salesReportButton_Click(sender As Object, e As EventArgs) Handles salesReportButton.Click
        ' Fetch the selected date range
        Dim startDate As DateTime = startDatePicker.Value
        Dim endDate As DateTime = endDatePicker.Value

        ' Fetch the sales report data
        Dim salesData As DataTable = GetSalesData(startDate, endDate)

        ' Display the data in the DataGridView
        If salesData IsNot Nothing Then
            reportDataGridView.DataSource = salesData
        End If

        ' Update top products for the selected date range
        LoadTopProducts(startDate, endDate)
    End Sub

    Private Sub stockReportButton_Click(sender As Object, e As EventArgs) Handles stockReportButton.Click
        ' Always use the dates from the date pickers
        Dim startDate As DateTime = startDatePicker.Value
        Dim endDate As DateTime = endDatePicker.Value

        ' Fetch the stock report data for the selected date range
        Dim stockData As DataTable = GetStockLevelsData(startDate, endDate)

        ' Display the data in the DataGridView
        If stockData IsNot Nothing Then
            reportDataGridView.DataSource = stockData
        End If

        ' Generate chart for stock data if available
        If reportDataGridView.DataSource IsNot Nothing Then
            chartDisplayButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Function GetTopProducts(startDate As DateTime, endDate As DateTime) As DataTable
        Dim query As String = "SELECT p.ProductID, " &
                             "       p.ProductName, " &
                             "       SUM(sd.Quantity) as TotalQuantity, " &
                             "       SUM(sd.Total) as TotalRevenue " &
                             "FROM Products p " &
                             "INNER JOIN SalesDetails sd ON p.ProductID = sd.ProductID " &
                             "INNER JOIN Sales s ON sd.SaleID = s.SaleID " &
                             "WHERE s.SaleDate BETWEEN @startDate AND @endDate " &
                             "GROUP BY p.ProductID, p.ProductName " &
                             "ORDER BY TotalQuantity DESC"
        Return GetData(query, startDate, endDate)
    End Function

    Private Sub LoadTopProducts(startDate As DateTime, endDate As DateTime)
        Dim topProducts As DataTable = GetTopProducts(startDate, endDate)
        If topProducts IsNot Nothing Then
            topProductsGridView.DataSource = topProducts
        End If
    End Sub

    Private Function GetSalesData(startDate As DateTime, endDate As DateTime) As DataTable
        ' Ensure the dates are correct for SQL query - set time to encompass full day
        Dim startWithTime As DateTime = startDate.Date
        Dim endWithTime As DateTime = endDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59)

        Dim query As String = "SELECT s.SaleID, " &
                             "       c.CustomerName, " &
                             "       s.TotalAmount, " &
                             "       s.SaleDate, " &
                             "       s.PaymentStatus, " &
                             "       p.PaymentMode " &
                             "FROM Sales s " &
                             "LEFT JOIN Customers c ON s.CustomerID = c.CustomerID " &
                             "LEFT JOIN Payments p ON s.SaleID = p.SaleID " &
                             "WHERE s.SaleDate BETWEEN @startDate AND @endDate " &
                             "ORDER BY s.SaleDate DESC"
        Return GetData(query, startWithTime, endWithTime)
    End Function

    Private Function GetStockLevelsData(startDate As DateTime, endDate As DateTime) As DataTable
        ' Ensure the dates are correct for SQL query - set time to encompass full day
        Dim startWithTime As DateTime = startDate.Date
        Dim endWithTime As DateTime = endDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59)

        Dim query As String = "SELECT s.StockID, " &
                             "       p.ProductName, " &
                             "       s.BatchQuantity, " &
                             "       s.StockDate, " &
                             "       s.BatchID, " &
                             "       s.UnitPrice " &
                             "FROM Stock s " &
                             "INNER JOIN Products p ON s.ProductID = p.ProductID " &
                             "WHERE s.StockDate BETWEEN @startDate AND @endDate " &
                             "ORDER BY s.StockDate DESC"
        Return GetData(query, startWithTime, endWithTime)
    End Function

    Private Function GetData(query As String, startDate As DateTime, endDate As DateTime) As DataTable
        Dim connectionString As String = "Data Source=LAPTOP-V6JUA5T5\SQLEXPRESS;Initial Catalog=KrishiSaadhan;Integrated Security=True;"
        Dim dataTable As New DataTable()

        ' Add error handling for database connection
        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@startDate", startDate)
                    command.Parameters.AddWithValue("@endDate", endDate)

                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using

            Return dataTable
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable() ' Return empty datatable on error
        End Try
    End Function

    Private Sub chartDisplayButton_Click(sender As Object, e As EventArgs) Handles chartDisplayButton.Click
        ' Display the selected chart type
        Dim selectedChartType As String = chartComboBox.SelectedItem.ToString()
        Dim dataSource As DataTable = CType(reportDataGridView.DataSource, DataTable)

        If dataSource IsNot Nothing AndAlso dataSource.Rows.Count > 0 Then
            SalesChart.Series.Clear()
            SalesChart.ChartAreas.Clear()
            SalesChart.Legends.Clear()
            SalesChart.Titles.Clear() ' Clear any existing titles

            ' Add new chart area
            Dim chartArea As New ChartArea("MainChartArea")
            SalesChart.ChartAreas.Add(chartArea)

            ' Add new legend
            Dim legend As New Legend("MainLegend")
            legend.Docking = Docking.Right
            SalesChart.Legends.Add(legend)

            ' Create new series
            Dim series As New Series("Sales")

            ' Set the data bindings based on the data source type
            If dataSource.Columns.Contains("TotalQuantity") Then
                ' For top products chart
                series.XValueMember = "ProductName"
                series.YValueMembers = "TotalQuantity"
                chartArea.AxisX.Title = "Products"
                chartArea.AxisY.Title = "Quantity Sold"
                SalesChart.Titles.Add(New Title("Top Products by Quantity", Docking.Top))
            ElseIf dataSource.Columns.Contains("BatchQuantity") Then
                ' For stock levels chart
                series.XValueMember = "ProductName"
                series.YValueMembers = "BatchQuantity"
                chartArea.AxisX.Title = "Products"
                chartArea.AxisY.Title = "Stock Quantity"
                SalesChart.Titles.Add(New Title("Stock Levels", Docking.Top))
            Else
                ' For sales data chart
                series.XValueMember = "CustomerName"
                series.YValueMembers = "TotalAmount"
                chartArea.AxisX.Title = "Customer"
                chartArea.AxisY.Title = "Sales Amount"
                SalesChart.Titles.Add(New Title("Sales by Customer", Docking.Top))
            End If

            ' Set chart type based on selection
            Select Case selectedChartType
                Case "Bar Chart"
                    series.ChartType = SeriesChartType.Bar
                Case "Pie Chart"
                    series.ChartType = SeriesChartType.Pie
                Case "Line Chart"
                    series.ChartType = SeriesChartType.Line
                Case "Area Chart"
                    series.ChartType = SeriesChartType.Area
                Case "Column Chart"
                    series.ChartType = SeriesChartType.Column
            End Select

            ' Configure chart appearance
            With SalesChart
                .Series.Add(series)
                .DataSource = dataSource
                .DataBind()

                ' Format chart area
                With .ChartAreas(0)
                    .AxisX.LabelStyle.Angle = -45
                    .AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount
                    .AxisX.LabelStyle.Font = New Font("Arial", 8)
                End With

                ' Configure legend and labels based on chart type
                If selectedChartType = "Pie Chart" Then
                    series.IsVisibleInLegend = True
                    .Series("Sales").Label = "#PERCENT{P1}"
                    .Series("Sales").LegendText = "#VALX"
                Else
                    series.IsVisibleInLegend = False
                    .Series("Sales").Label = "#VALY"
                End If

                ' Adjust chart appearance
                .AntiAliasing = AntiAliasingStyles.All
                .TextAntiAliasingQuality = TextAntiAliasingQuality.High
            End With
        Else
            ' Clear chart if no data is available
            SalesChart.Series.Clear()
            SalesChart.ChartAreas.Clear()
            SalesChart.Titles.Clear()
        End If
    End Sub
End Class