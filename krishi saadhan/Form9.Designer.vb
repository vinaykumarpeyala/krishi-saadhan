<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGenerationForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGenerationForm))
        Me.salesReportButton = New System.Windows.Forms.Button()
        Me.stockReportButton = New System.Windows.Forms.Button()
        Me.reportDataGridView = New System.Windows.Forms.DataGridView()
        Me.endDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartDisplayButton = New System.Windows.Forms.Button()
        Me.chartComboBox = New System.Windows.Forms.ComboBox()
        Me.topProductsGridView = New System.Windows.Forms.DataGridView()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.reportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topProductsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salesReportButton
        '
        Me.salesReportButton.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.salesReportButton.Location = New System.Drawing.Point(382, 224)
        Me.salesReportButton.Name = "salesReportButton"
        Me.salesReportButton.Size = New System.Drawing.Size(116, 37)
        Me.salesReportButton.TabIndex = 0
        Me.salesReportButton.Text = "Sales Report"
        Me.salesReportButton.UseVisualStyleBackColor = False
        '
        'stockReportButton
        '
        Me.stockReportButton.BackColor = System.Drawing.Color.NavajoWhite
        Me.stockReportButton.Location = New System.Drawing.Point(213, 224)
        Me.stockReportButton.Name = "stockReportButton"
        Me.stockReportButton.Size = New System.Drawing.Size(133, 37)
        Me.stockReportButton.TabIndex = 1
        Me.stockReportButton.Text = "Stock Report"
        Me.stockReportButton.UseVisualStyleBackColor = False
        '
        'reportDataGridView
        '
        Me.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportDataGridView.Location = New System.Drawing.Point(15, 305)
        Me.reportDataGridView.Name = "reportDataGridView"
        Me.reportDataGridView.RowHeadersWidth = 51
        Me.reportDataGridView.RowTemplate.Height = 24
        Me.reportDataGridView.Size = New System.Drawing.Size(740, 261)
        Me.reportDataGridView.TabIndex = 3
        '
        'endDatePicker
        '
        Me.endDatePicker.Location = New System.Drawing.Point(55, 108)
        Me.endDatePicker.Name = "endDatePicker"
        Me.endDatePicker.Size = New System.Drawing.Size(165, 22)
        Me.endDatePicker.TabIndex = 4
        '
        'startDatePicker
        '
        Me.startDatePicker.Location = New System.Drawing.Point(55, 64)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(164, 22)
        Me.startDatePicker.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TO"
        '
        'SalesChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.SalesChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.SalesChart.Legends.Add(Legend2)
        Me.SalesChart.Location = New System.Drawing.Point(804, 24)
        Me.SalesChart.Name = "SalesChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.SalesChart.Series.Add(Series2)
        Me.SalesChart.Size = New System.Drawing.Size(412, 523)
        Me.SalesChart.TabIndex = 8
        Me.SalesChart.Text = "Chart1"
        '
        'chartDisplayButton
        '
        Me.chartDisplayButton.BackColor = System.Drawing.Color.PaleTurquoise
        Me.chartDisplayButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chartDisplayButton.Location = New System.Drawing.Point(55, 222)
        Me.chartDisplayButton.Name = "chartDisplayButton"
        Me.chartDisplayButton.Size = New System.Drawing.Size(114, 39)
        Me.chartDisplayButton.TabIndex = 10
        Me.chartDisplayButton.Text = "Generate"
        Me.chartDisplayButton.UseVisualStyleBackColor = False
        '
        'chartComboBox
        '
        Me.chartComboBox.FormattingEnabled = True
        Me.chartComboBox.Location = New System.Drawing.Point(175, 176)
        Me.chartComboBox.Name = "chartComboBox"
        Me.chartComboBox.Size = New System.Drawing.Size(121, 24)
        Me.chartComboBox.TabIndex = 11
        '
        'topProductsGridView
        '
        Me.topProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.topProductsGridView.Location = New System.Drawing.Point(325, 64)
        Me.topProductsGridView.Name = "topProductsGridView"
        Me.topProductsGridView.RowHeadersWidth = 51
        Me.topProductsGridView.RowTemplate.Height = 24
        Me.topProductsGridView.Size = New System.Drawing.Size(447, 91)
        Me.topProductsGridView.TabIndex = 12
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 583)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(1248, 22)
        Me.HScrollBar1.TabIndex = 13
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1229, 3)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 602)
        Me.VScrollBar1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "SELECT DATE RANGE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(424, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TOP SELLING PRODUCTS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CHOOSE TYPE:"
        '
        'ReportGenerationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1247, 603)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.topProductsGridView)
        Me.Controls.Add(Me.chartComboBox)
        Me.Controls.Add(Me.chartDisplayButton)
        Me.Controls.Add(Me.SalesChart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startDatePicker)
        Me.Controls.Add(Me.endDatePicker)
        Me.Controls.Add(Me.stockReportButton)
        Me.Controls.Add(Me.salesReportButton)
        Me.Controls.Add(Me.reportDataGridView)
        Me.Name = "ReportGenerationForm"
        Me.Text = "Form9"
        CType(Me.reportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topProductsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salesReportButton As Button
    Friend WithEvents stockReportButton As Button
    Friend WithEvents reportDataGridView As DataGridView
    Friend WithEvents endDatePicker As DateTimePicker
    Friend WithEvents startDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents SalesChart As DataVisualization.Charting.Chart
    Friend WithEvents chartDisplayButton As Button
    Friend WithEvents chartComboBox As ComboBox
    Friend WithEvents topProductsGridView As DataGridView
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
