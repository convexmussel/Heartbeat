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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea3.Area3DStyle.IsRightAngleAxes = false;
            chartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea3.Area3DStyle.Perspective = 30;
            chartArea3.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea3);
            this.lineChart.Cursor = System.Windows.Forms.Cursors.Default;
            legend3.Name = "Legend1";
            this.lineChart.Legends.Add(legend3);
            this.lineChart.Location = new System.Drawing.Point(16, 0);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 6;
            this.lineChart.Series.Add(series3);
            this.lineChart.Size = new System.Drawing.Size(300, 300);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lineChart";
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(16, 323);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 1;
            this.backB.Text = "Back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // tableB
            // 
            this.tableB.Location = new System.Drawing.Point(134, 322);
            this.tableB.Name = "tableB";
            this.tableB.Size = new System.Drawing.Size(75, 23);
            this.tableB.TabIndex = 2;
            this.tableB.Text = "Table";
            this.tableB.UseVisualStyleBackColor = true;
            this.tableB.Click += new System.EventHandler(this.tableB_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableB);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.lineChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(523, 518);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Button tableB;
    }
}
