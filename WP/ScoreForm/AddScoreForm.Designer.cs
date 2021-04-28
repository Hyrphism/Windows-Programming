
namespace WP
{
    partial class AddScoreForm
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
            this.id_lb = new System.Windows.Forms.Label();
            this.cource_lb = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.cource_cb = new System.Windows.Forms.ComboBox();
            this.score_tb = new System.Windows.Forms.TextBox();
            this.DataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(53, 13);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(141, 29);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "Student ID:";
            // 
            // cource_lb
            // 
            this.cource_lb.AutoSize = true;
            this.cource_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cource_lb.Location = new System.Drawing.Point(11, 57);
            this.cource_lb.Name = "cource_lb";
            this.cource_lb.Size = new System.Drawing.Size(185, 29);
            this.cource_lb.TabIndex = 0;
            this.cource_lb.Text = "Select Course:";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_lb.Location = new System.Drawing.Point(110, 102);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(89, 29);
            this.score_lb.TabIndex = 0;
            this.score_lb.Text = "Score:";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(44, 142);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(153, 29);
            this.description_lb.TabIndex = 0;
            this.description_lb.Text = "Description:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(207, 13);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(184, 30);
            this.id_tb.TabIndex = 3;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(207, 142);
            this.description_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(296, 133);
            this.description_tb.TabIndex = 4;
            this.description_tb.Text = "";
            // 
            // cource_cb
            // 
            this.cource_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_cb.FormattingEnabled = true;
            this.cource_cb.Location = new System.Drawing.Point(207, 57);
            this.cource_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cource_cb.Name = "cource_cb";
            this.cource_cb.Size = new System.Drawing.Size(296, 33);
            this.cource_cb.TabIndex = 5;
            // 
            // score_tb
            // 
            this.score_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_tb.Location = new System.Drawing.Point(207, 102);
            this.score_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.score_tb.Name = "score_tb";
            this.score_tb.Size = new System.Drawing.Size(184, 30);
            this.score_tb.TabIndex = 6;
            // 
            // DataGridViewStudent
            // 
            this.DataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudent.Location = new System.Drawing.Point(543, 10);
            this.DataGridViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridViewStudent.Name = "DataGridViewStudent";
            this.DataGridViewStudent.RowHeadersWidth = 62;
            this.DataGridViewStudent.RowTemplate.Height = 28;
            this.DataGridViewStudent.Size = new System.Drawing.Size(506, 338);
            this.DataGridViewStudent.TabIndex = 7;
            this.DataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentInfo_dgv_CellContentClick);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(207, 295);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(154, 53);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add Score";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1050, 416);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.DataGridViewStudent);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.cource_cb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.cource_lb);
            this.Controls.Add(this.id_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label cource_lb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.ComboBox cource_cb;
        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.DataGridView DataGridViewStudent;
        private System.Windows.Forms.Button add_btn;
    }
}