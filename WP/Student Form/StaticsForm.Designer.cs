namespace WP
{
    partial class StaticsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Total = new System.Windows.Forms.Label();
            this.totalGender = new System.Windows.Forms.Label();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.MaleScale = new System.Windows.Forms.Label();
            this.FemaleScale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarChart
            // 
            chartArea3.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BarChart.Legends.Add(legend3);
            this.BarChart.Location = new System.Drawing.Point(12, 161);
            this.BarChart.Name = "BarChart";
            this.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.BarChart.Series.Add(series3);
            this.BarChart.Size = new System.Drawing.Size(622, 516);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "BarChart";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(15, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(104, 39);
            this.Total.TabIndex = 1;
            this.Total.Text = "Total: ";
            this.Total.Click += new System.EventHandler(this.Total_Student);
            // 
            // totalGender
            // 
            this.totalGender.AutoSize = true;
            this.totalGender.Font = new System.Drawing.Font("Arial", 20F);
            this.totalGender.Location = new System.Drawing.Point(119, 9);
            this.totalGender.Name = "totalGender";
            this.totalGender.Size = new System.Drawing.Size(0, 39);
            this.totalGender.TabIndex = 2;
            // 
            // PieChart
            // 
            chartArea4.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PieChart.Legends.Add(legend4);
            this.PieChart.Location = new System.Drawing.Point(519, 313);
            this.PieChart.Name = "PieChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.PieChart.Series.Add(series4);
            this.PieChart.Size = new System.Drawing.Size(370, 364);
            this.PieChart.TabIndex = 3;
            this.PieChart.Text = "PieChart";
            this.PieChart.Click += new System.EventHandler(this.PieChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gender Chart";
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Arial", 20F);
            this.labelMale.Location = new System.Drawing.Point(12, 59);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(107, 39);
            this.labelMale.TabIndex = 5;
            this.labelMale.Text = "Male: ";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.Location = new System.Drawing.Point(230, 59);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(144, 39);
            this.labelFemale.TabIndex = 6;
            this.labelFemale.Text = "Female: ";
            // 
            // MaleScale
            // 
            this.MaleScale.AutoSize = true;
            this.MaleScale.Font = new System.Drawing.Font("Arial", 20F);
            this.MaleScale.Location = new System.Drawing.Point(125, 59);
            this.MaleScale.Name = "MaleScale";
            this.MaleScale.Size = new System.Drawing.Size(0, 39);
            this.MaleScale.TabIndex = 7;
            // 
            // FemaleScale
            // 
            this.FemaleScale.AutoSize = true;
            this.FemaleScale.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleScale.Location = new System.Drawing.Point(361, 59);
            this.FemaleScale.Name = "FemaleScale";
            this.FemaleScale.Size = new System.Drawing.Size(0, 39);
            this.FemaleScale.TabIndex = 8;
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 689);
            this.Controls.Add(this.FemaleScale);
            this.Controls.Add(this.MaleScale);
            this.Controls.Add(this.labelFemale);
            this.Controls.Add(this.labelMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.totalGender);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.BarChart);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label totalGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label MaleScale;
        private System.Windows.Forms.Label FemaleScale;
    }
}