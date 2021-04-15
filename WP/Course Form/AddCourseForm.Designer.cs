namespace WP.Course_Form
{
    partial class AddCourseForm
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
            this.courseID = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.coursePeriod = new System.Windows.Forms.Label();
            this.courseDescription = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseID
            // 
            this.courseID.AutoSize = true;
            this.courseID.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseID.Location = new System.Drawing.Point(60, 33);
            this.courseID.Name = "courseID";
            this.courseID.Size = new System.Drawing.Size(156, 32);
            this.courseID.TabIndex = 0;
            this.courseID.Text = "Course ID:";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(119, 102);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(97, 32);
            this.courseLabel.TabIndex = 1;
            this.courseLabel.Text = "Label:";
            // 
            // coursePeriod
            // 
            this.coursePeriod.AutoSize = true;
            this.coursePeriod.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursePeriod.Location = new System.Drawing.Point(105, 174);
            this.coursePeriod.Name = "coursePeriod";
            this.coursePeriod.Size = new System.Drawing.Size(111, 32);
            this.coursePeriod.TabIndex = 2;
            this.coursePeriod.Text = "Period:";
            // 
            // courseDescription
            // 
            this.courseDescription.AutoSize = true;
            this.courseDescription.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDescription.Location = new System.Drawing.Point(39, 252);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(177, 32);
            this.courseDescription.TabIndex = 3;
            this.courseDescription.Text = "Description:";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseID.Location = new System.Drawing.Point(235, 33);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(313, 32);
            this.textBoxCourseID.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(235, 252);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(313, 32);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriod.Location = new System.Drawing.Point(235, 174);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(313, 32);
            this.textBoxPeriod.TabIndex = 6;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(235, 102);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(313, 32);
            this.textBoxLabel.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(186, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(232, 73);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(600, 416);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.courseDescription);
            this.Controls.Add(this.coursePeriod);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.courseID);
            this.Name = "AddCourseForm";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseID;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label coursePeriod;
        private System.Windows.Forms.Label courseDescription;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Button buttonAdd;
    }
}