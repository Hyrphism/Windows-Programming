namespace WP.ResultForm
{
    partial class AvgResultByScoreForm
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
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.labelStudentID.Location = new System.Drawing.Point(24, 78);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(144, 30);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.labelLname.Location = new System.Drawing.Point(24, 233);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(145, 30);
            this.labelLname.TabIndex = 1;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.labelFname.Location = new System.Drawing.Point(24, 157);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(148, 30);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "First Name:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSearch.Location = new System.Drawing.Point(24, 306);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(338, 30);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search by ID or First Name:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxID.Location = new System.Drawing.Point(175, 76);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(187, 32);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxFname.Location = new System.Drawing.Point(175, 155);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(187, 32);
            this.textBoxFname.TabIndex = 5;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxLname.Location = new System.Drawing.Point(175, 231);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(187, 32);
            this.textBoxLname.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 13F);
            this.textBoxSearch.Location = new System.Drawing.Point(175, 367);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 32);
            this.textBoxSearch.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(29, 357);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 49);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(431, 76);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.RowHeadersWidth = 51;
            this.dataGridViewResult.RowTemplate.Height = 24;
            this.dataGridViewResult.Size = new System.Drawing.Size(673, 323);
            this.dataGridViewResult.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25F);
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student Result";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrint.Location = new System.Drawing.Point(339, 432);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(134, 73);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(570, 432);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 73);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AvgResultByScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1129, 522);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelStudentID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AvgResultByScoreForm";
            this.Text = "AvgResultByScoreForm";
            this.Load += new System.EventHandler(this.AvgResultByScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonCancel;
    }
}