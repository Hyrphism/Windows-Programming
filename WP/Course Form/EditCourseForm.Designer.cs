namespace WP.Course_Form
{
    partial class EditCourseForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.selectCourse = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(279, 25);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(351, 33);
            this.comboBoxSelect.TabIndex = 0;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // selectCourse
            // 
            this.selectCourse.AutoSize = true;
            this.selectCourse.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCourse.Location = new System.Drawing.Point(47, 26);
            this.selectCourse.Name = "selectCourse";
            this.selectCourse.Size = new System.Drawing.Size(208, 32);
            this.selectCourse.TabIndex = 1;
            this.selectCourse.Text = "Select Course:";
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabel.Location = new System.Drawing.Point(279, 84);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(351, 32);
            this.textBoxLabel.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(158, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 32);
            this.label.TabIndex = 6;
            this.label.Text = "Label:";
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(144, 198);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(111, 32);
            this.period.TabIndex = 7;
            this.period.Text = "Period:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(78, 263);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(177, 32);
            this.description.TabIndex = 8;
            this.description.Text = "Description:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(279, 198);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 32);
            this.numericUpDown1.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(279, 265);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(351, 116);
            this.textBoxDescription.TabIndex = 10;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Tomato;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(182, 409);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(472, 70);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Select Hours";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(106, 142);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(149, 32);
            this.labelSemester.TabIndex = 12;
            this.labelSemester.Text = "Semester:";
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemester.Location = new System.Drawing.Point(279, 144);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(351, 32);
            this.textBoxSemester.TabIndex = 13;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.period);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.selectCourse);
            this.Controls.Add(this.comboBoxSelect);
            this.Name = "EditCourseForm";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label selectCourse;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.TextBox textBoxSemester;
    }
}