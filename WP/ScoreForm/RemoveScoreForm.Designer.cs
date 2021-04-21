
namespace WP
{
    partial class RemoveScoreForm
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
            this.dataGridViewRemove = new System.Windows.Forms.DataGridView();
            this.remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRemove
            // 
            this.dataGridViewRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemove.Location = new System.Drawing.Point(11, 10);
            this.dataGridViewRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRemove.Name = "dataGridViewRemove";
            this.dataGridViewRemove.RowHeadersWidth = 62;
            this.dataGridViewRemove.RowTemplate.Height = 28;
            this.dataGridViewRemove.Size = new System.Drawing.Size(690, 348);
            this.dataGridViewRemove.TabIndex = 0;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(245, 377);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(198, 45);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 433);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.dataGridViewRemove);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRemove;
        private System.Windows.Forms.Button remove_btn;
    }
}