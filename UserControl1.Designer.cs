namespace Heartbeat_monitor
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backB = new System.Windows.Forms.Button();
            this.tableB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            this.lineChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineChart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.lineChart.BackSecondaryColor = System.Drawing.Color.Yellow;
            this.lineChart.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Perspective = 30;
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            this.lineChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Margin = new System.Windows.Forms.Padding(4);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.lineChart.Series.Add(series1);
            this.lineChart.Size = new System.Drawing.Size(1170, 709);
            this.lineChart.TabIndex = 0;
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(532, 681);
            this.backB.Margin = new System.Windows.Forms.Padding(4);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(100, 28);
            this.backB.TabIndex = 1;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // tableB
            // 
            this.tableB.Location = new System.Drawing.Point(653, 681);
            this.tableB.Margin = new System.Windows.Forms.Padding(4);
            this.tableB.Name = "tableB";
            this.tableB.Size = new System.Drawing.Size(100, 28);
            this.tableB.TabIndex = 2;
            this.tableB.Text = "Table";
            this.tableB.UseVisualStyleBackColor = true;
            this.tableB.Click += new System.EventHandler(this.tableB_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableB);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.lineChart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1170, 713);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button tableB;
    }
}
