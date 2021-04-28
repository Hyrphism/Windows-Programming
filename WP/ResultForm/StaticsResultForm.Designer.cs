namespace WP.ResultForm
{
    partial class StaticsResultForm
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
            this.labelStaticCourse = new System.Windows.Forms.Label();
            this.labelStaticResult = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStaticCourse
            // 
            this.labelStaticCourse.AutoSize = true;
            this.labelStaticCourse.Font = new System.Drawing.Font("Mistral", 28F);
            this.labelStaticCourse.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStaticCourse.Location = new System.Drawing.Point(45, 54);
            this.labelStaticCourse.Name = "labelStaticCourse";
            this.labelStaticCourse.Size = new System.Drawing.Size(270, 56);
            this.labelStaticCourse.TabIndex = 11;
            this.labelStaticCourse.Text = "Static by Course";
            // 
            // labelStaticResult
            // 
            this.labelStaticResult.AutoSize = true;
            this.labelStaticResult.Font = new System.Drawing.Font("Mistral", 28F);
            this.labelStaticResult.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStaticResult.Location = new System.Drawing.Point(429, 54);
            this.labelStaticResult.Name = "labelStaticResult";
            this.labelStaticResult.Size = new System.Drawing.Size(265, 56);
            this.labelStaticResult.TabIndex = 12;
            this.labelStaticResult.Text = "Static by Result";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPass.Location = new System.Drawing.Point(434, 160);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(88, 32);
            this.labelPass.TabIndex = 13;
            this.labelPass.Text = "Pass:";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelFail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFail.Location = new System.Drawing.Point(434, 231);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(73, 32);
            this.labelFail.TabIndex = 14;
            this.labelFail.Text = "Fail:";
            // 
            // StaticsResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelStaticResult);
            this.Controls.Add(this.labelStaticCourse);
            this.Name = "StaticsResultForm";
            this.Text = "StaticsResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaticCourse;
        private System.Windows.Forms.Label labelStaticResult;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelFail;
    }
}