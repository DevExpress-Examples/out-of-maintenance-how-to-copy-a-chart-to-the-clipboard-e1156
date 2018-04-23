namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(10))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(20))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(30))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(40))});
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView1 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(10))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(20))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(30))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(40))});
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView2 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
            DevExpress.XtraCharts.StackedSplineAreaSeriesView stackedSplineAreaSeriesView3 = new DevExpress.XtraCharts.StackedSplineAreaSeriesView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Copy to Clipboard as EMF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy to Clipboard as PNG";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(8, 48);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4});
            series1.View = stackedSplineAreaSeriesView1;
            series2.Name = "Series 2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            series2.View = stackedSplineAreaSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.SeriesTemplate.View = stackedSplineAreaSeriesView3;
            this.chartControl1.Size = new System.Drawing.Size(456, 319);
            this.chartControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 373);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedSplineAreaSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

