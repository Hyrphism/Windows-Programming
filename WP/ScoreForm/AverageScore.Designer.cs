
namespace WP
{
    partial class AverageScore
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
            this.DataGridViewAVG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAVG)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewAVG
            // 
            this.DataGridViewAVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAVG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAVG.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewAVG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewAVG.Name = "DataGridViewAVG";
            this.DataGridViewAVG.RowHeadersWidth = 62;
            this.DataGridViewAVG.RowTemplate.Height = 28;
            this.DataGridViewAVG.Size = new System.Drawing.Size(641, 454);
            this.DataGridViewAVG.TabIndex = 0;
            // 
            // AverageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 454);
            this.Controls.Add(this.DataGridViewAVG);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AverageScore";
            this.Text = "AvarageScore";
            this.Load += new System.EventHandler(this.AvarageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewAVG;
    }
}