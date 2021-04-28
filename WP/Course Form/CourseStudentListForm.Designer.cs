namespace WP.Course_Form
{
    partial class CourseStudentListForm
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
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCourseName.Location = new System.Drawing.Point(23, 38);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(204, 32);
            this.labelCourseName.TabIndex = 4;
            this.labelCourseName.Text = "Course Name:";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSemester.Location = new System.Drawing.Point(492, 40);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(149, 32);
            this.labelSemester.TabIndex = 5;
            this.labelSemester.Text = "Semester:";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxCourseName.Location = new System.Drawing.Point(233, 40);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(253, 32);
            this.textBoxCourseName.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 78);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(745, 360);
            this.dataGridView.TabIndex = 8;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxSemester.Location = new System.Drawing.Point(647, 40);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(127, 32);
            this.textBoxSemester.TabIndex = 9;
            // 
            // CourseStudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelCourseName);
            this.Name = "CourseStudentListForm";
            this.Text = "CourseStudentListForm";
            this.Load += new System.EventHandler(this.CourseStudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelSemester;
        public System.Windows.Forms.TextBox textBoxCourseName;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox textBoxSemester;
    }
}