Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(10))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(20))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(30))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(40))})
			Dim stackedSplineAreaSeriesView1 As New DevExpress.XtraCharts.StackedSplineAreaSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(10))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(20))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(30))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(40))})
			Dim stackedSplineAreaSeriesView2 As New DevExpress.XtraCharts.StackedSplineAreaSeriesView()
			Dim stackedSplineAreaSeriesView3 As New DevExpress.XtraCharts.StackedSplineAreaSeriesView()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button1 = New System.Windows.Forms.Button()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(192, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(168, 32)
			Me.button2.TabIndex = 4
			Me.button2.Text = "Copy to Clipboard as EMF"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(8, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(168, 32)
			Me.button1.TabIndex = 3
			Me.button1.Text = "Copy to Clipboard as PNG"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Location = New System.Drawing.Point(8, 48)
			Me.chartControl1.Name = "chartControl1"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
			series1.View = stackedSplineAreaSeriesView1
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			series2.View = stackedSplineAreaSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chartControl1.SeriesTemplate.View = stackedSplineAreaSeriesView3
			Me.chartControl1.Size = New System.Drawing.Size(456, 319)
			Me.chartControl1.TabIndex = 5
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(470, 373)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button1 As System.Windows.Forms.Button
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

