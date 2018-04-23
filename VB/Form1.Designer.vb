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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(10, Object)})
            Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(20, Object)})
            Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(30, Object)})
            Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(40, Object)})
            Dim StackedSplineAreaSeriesView1 As DevExpress.XtraCharts.StackedSplineAreaSeriesView = New DevExpress.XtraCharts.StackedSplineAreaSeriesView
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {CType(10, Object)})
            Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {CType(20, Object)})
            Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {CType(30, Object)})
            Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {CType(40, Object)})
            Dim StackedSplineAreaSeriesView2 As DevExpress.XtraCharts.StackedSplineAreaSeriesView = New DevExpress.XtraCharts.StackedSplineAreaSeriesView
            Dim StackedSplineAreaSeriesView3 As DevExpress.XtraCharts.StackedSplineAreaSeriesView = New DevExpress.XtraCharts.StackedSplineAreaSeriesView
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl
            Me.button1 = New System.Windows.Forms.Button
            Me.Button2 = New System.Windows.Forms.Button
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisX.Range.SideMarginsEnabled = False
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Range.SideMarginsEnabled = True
            Me.chartControl1.Diagram = XyDiagram1
            Me.chartControl1.Location = New System.Drawing.Point(8, 48)
            Me.chartControl1.Name = "chartControl1"
            Series1.Name = "Series 1"
            Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4})
            Series1.View = StackedSplineAreaSeriesView1
            Series2.Name = "Series 2"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8})
            Series2.View = StackedSplineAreaSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
            Me.chartControl1.SeriesTemplate.View = StackedSplineAreaSeriesView3
            Me.chartControl1.Size = New System.Drawing.Size(456, 319)
            Me.chartControl1.TabIndex = 0
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(8, 8)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(168, 32)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Copy to Clipboard as PNG"
            Me.button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(192, 8)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(168, 32)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Copy to Clipboard as EMF"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(470, 373)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents Button2 As System.Windows.Forms.Button
    End Class
End Namespace

