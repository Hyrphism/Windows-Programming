namespace WP.Student_Form
{
    partial class AddCourseToStudent
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
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelAvailableCourse = new System.Windows.Forms.Label();
            this.labelSelectedCourse = new System.Windows.Forms.Label();
            this.listBoxAvailableCourse = new System.Windows.Forms.ListBox();
            this.listBoxSelectedCourse = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.labelStudentID.Location = new System.Drawing.Point(12, 47);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(171, 34);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.labelSemester.Location = new System.Drawing.Point(334, 44);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(155, 34);
            this.labelSemester.TabIndex = 1;
            this.labelSemester.Text = "Semester:";
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(177, 47);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(127, 33);
            this.comboBoxID.TabIndex = 2;
            this.comboBoxID.SelectedIndexChanged += new System.EventHandler(this.comboBoxID_SelectedIndexChanged);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(495, 47);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(150, 33);
            this.comboBoxSemester.TabIndex = 3;
            this.comboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemester_SelectedIndexChanged);
            // 
            // labelAvailableCourse
            // 
            this.labelAvailableCourse.AutoSize = true;
            this.labelAvailableCourse.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.labelAvailableCourse.Location = new System.Drawing.Point(12, 134);
            this.labelAvailableCourse.Name = "labelAvailableCourse";
            this.labelAvailableCourse.Size = new System.Drawing.Size(258, 34);
            this.labelAvailableCourse.TabIndex = 4;
            this.labelAvailableCourse.Text = "Available Course:";
            // 
            // labelSelectedCourse
            // 
            this.labelSelectedCourse.AutoSize = true;
            this.labelSelectedCourse.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.labelSelectedCourse.Location = new System.Drawing.Point(393, 134);
            this.labelSelectedCourse.Name = "labelSelectedCourse";
            this.labelSelectedCourse.Size = new System.Drawing.Size(252, 34);
            this.labelSelectedCourse.TabIndex = 5;
            this.labelSelectedCourse.Text = "Selected Course:";
            // 
            // listBoxAvailableCourse
            // 
            this.listBoxAvailableCourse.FormattingEnabled = true;
            this.listBoxAvailableCourse.ItemHeight = 16;
            this.listBoxAvailableCourse.Location = new System.Drawing.Point(18, 196);
            this.listBoxAvailableCourse.Name = "listBoxAvailableCourse";
            this.listBoxAvailableCourse.Size = new System.Drawing.Size(252, 228);
            this.listBoxAvailableCourse.TabIndex = 6;
            this.listBoxAvailableCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableCourse_SelectedIndexChanged);
            // 
            // listBoxSelectedCourse
            // 
            this.listBoxSelectedCourse.FormattingEnabled = true;
            this.listBoxSelectedCourse.HorizontalScrollbar = true;
            this.listBoxSelectedCourse.ItemHeight = 16;
            this.listBoxSelectedCourse.Location = new System.Drawing.Point(399, 196);
            this.listBoxSelectedCourse.Name = "listBoxSelectedCourse";
            this.listBoxSelectedCourse.Size = new System.Drawing.Size(252, 228);
            this.listBoxSelectedCourse.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(288, 285);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 50);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(288, 355);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 50);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAll.Location = new System.Drawing.Point(288, 210);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(95, 50);
            this.buttonAll.TabIndex = 10;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // AddCourseToStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSelectedCourse);
            this.Controls.Add(this.listBoxAvailableCourse);
            this.Controls.Add(this.labelSelectedCourse);
            this.Controls.Add(this.labelAvailableCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelStudentID);
            this.Name = "AddCourseToStudent";
            this.Text = "AddCourseToStudent";
            this.Load += new System.EventHandler(this.AddCourseToStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelAvailableCourse;
        private System.Windows.Forms.Label labelSelectedCourse;
        private System.Windows.Forms.ListBox listBoxAvailableCourse;
        private System.Windows.Forms.ListBox listBoxSelectedCourse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAll;
    }
}