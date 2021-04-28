
namespace WP
{
    partial class ManageScoreForm
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
            this.score_tb = new System.Windows.Forms.TextBox();
            this.cource_cb = new System.Windows.Forms.ComboBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.description_lb = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.cource_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.avg_btn = new System.Windows.Forms.Button();
            this.showStudent_btn = new System.Windows.Forms.Button();
            this.showScore_btn = new System.Windows.Forms.Button();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // score_tb
            // 
            this.score_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_tb.Location = new System.Drawing.Point(203, 100);
            this.score_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.score_tb.Name = "score_tb";
            this.score_tb.Size = new System.Drawing.Size(184, 30);
            this.score_tb.TabIndex = 14;
            // 
            // cource_cb
            // 
            this.cource_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_cb.FormattingEnabled = true;
            this.cource_cb.Location = new System.Drawing.Point(203, 55);
            this.cource_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cource_cb.Name = "cource_cb";
            this.cource_cb.Size = new System.Drawing.Size(296, 33);
            this.cource_cb.TabIndex = 13;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(203, 141);
            this.description_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(296, 142);
            this.description_tb.TabIndex = 12;
            this.description_tb.Text = "";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(203, 11);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(184, 30);
            this.id_tb.TabIndex = 11;
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(39, 141);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(153, 29);
            this.description_lb.TabIndex = 7;
            this.description_lb.Text = "Description:";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_lb.Location = new System.Drawing.Point(106, 100);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(89, 29);
            this.score_lb.TabIndex = 8;
            this.score_lb.Text = "Score:";
            // 
            // cource_lb
            // 
            this.cource_lb.AutoSize = true;
            this.cource_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cource_lb.Location = new System.Drawing.Point(6, 55);
            this.cource_lb.Name = "cource_lb";
            this.cource_lb.Size = new System.Drawing.Size(185, 29);
            this.cource_lb.TabIndex = 9;
            this.cource_lb.Text = "Select Course:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(49, 11);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(141, 29);
            this.id_lb.TabIndex = 10;
            this.id_lb.Text = "Student ID:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(82, 309);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(154, 53);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "Add Score";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(276, 309);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(154, 53);
            this.remove_btn.TabIndex = 16;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // avg_btn
            // 
            this.avg_btn.BackColor = System.Drawing.Color.Blue;
            this.avg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avg_btn.Location = new System.Drawing.Point(82, 395);
            this.avg_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avg_btn.Name = "avg_btn";
            this.avg_btn.Size = new System.Drawing.Size(348, 74);
            this.avg_btn.TabIndex = 17;
            this.avg_btn.Text = "Average Score By Course";
            this.avg_btn.UseVisualStyleBackColor = false;
            this.avg_btn.Click += new System.EventHandler(this.avg_btn_Click);
            // 
            // showStudent_btn
            // 
            this.showStudent_btn.Location = new System.Drawing.Point(705, 13);
            this.showStudent_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showStudent_btn.Name = "showStudent_btn";
            this.showStudent_btn.Size = new System.Drawing.Size(171, 29);
            this.showStudent_btn.TabIndex = 18;
            this.showStudent_btn.Text = "Show Student";
            this.showStudent_btn.UseVisualStyleBackColor = true;
            this.showStudent_btn.Click += new System.EventHandler(this.showStudent_btn_Click);
            // 
            // showScore_btn
            // 
            this.showScore_btn.Location = new System.Drawing.Point(997, 13);
            this.showScore_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showScore_btn.Name = "showScore_btn";
            this.showScore_btn.Size = new System.Drawing.Size(171, 29);
            this.showScore_btn.TabIndex = 18;
            this.showScore_btn.Text = "Show Score";
            this.showScore_btn.UseVisualStyleBackColor = true;
            this.showScore_btn.Click += new System.EventHandler(this.showScore_btn_Click);
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(527, 55);
            this.dataGridViewShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersWidth = 62;
            this.dataGridViewShow.RowTemplate.Height = 28;
            this.dataGridViewShow.Size = new System.Drawing.Size(783, 442);
            this.dataGridViewShow.TabIndex = 19;
            this.dataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShow_CellContentClick);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1316, 519);
            this.Controls.Add(this.dataGridViewShow);
            this.Controls.Add(this.showScore_btn);
            this.Controls.Add(this.showStudent_btn);
            this.Controls.Add(this.avg_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.cource_cb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.cource_lb);
            this.Controls.Add(this.id_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.ComboBox cource_cb;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label cource_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button avg_btn;
        private System.Windows.Forms.Button showStudent_btn;
        private System.Windows.Forms.Button showScore_btn;
        private System.Windows.Forms.DataGridView dataGridViewShow;
    }
}