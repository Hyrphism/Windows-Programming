namespace WP.ContactForm
{
    partial class ShowFullContactForm
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
            this.linkLabelGroup = new System.Windows.Forms.LinkLabel();
            this.linkLabelShowAll = new System.Windows.Forms.LinkLabel();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.dataGridViewShowAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelGroup
            // 
            this.linkLabelGroup.AutoSize = true;
            this.linkLabelGroup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGroup.LinkColor = System.Drawing.Color.DeepPink;
            this.linkLabelGroup.Location = new System.Drawing.Point(12, 25);
            this.linkLabelGroup.Name = "linkLabelGroup";
            this.linkLabelGroup.Size = new System.Drawing.Size(87, 30);
            this.linkLabelGroup.TabIndex = 0;
            this.linkLabelGroup.TabStop = true;
            this.linkLabelGroup.Text = "Group";
            this.linkLabelGroup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGroup_LinkClicked);
            // 
            // linkLabelShowAll
            // 
            this.linkLabelShowAll.AutoSize = true;
            this.linkLabelShowAll.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelShowAll.LinkColor = System.Drawing.Color.DeepPink;
            this.linkLabelShowAll.Location = new System.Drawing.Point(182, 25);
            this.linkLabelShowAll.Name = "linkLabelShowAll";
            this.linkLabelShowAll.Size = new System.Drawing.Size(116, 30);
            this.linkLabelShowAll.TabIndex = 1;
            this.linkLabelShowAll.TabStop = true;
            this.linkLabelShowAll.Text = "Show All";
            this.linkLabelShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowAll_LinkClicked);
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.BackColor = System.Drawing.Color.HotPink;
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 16;
            this.listBoxGroup.Location = new System.Drawing.Point(13, 75);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(151, 356);
            this.listBoxGroup.TabIndex = 2;
            this.listBoxGroup.DoubleClick += new System.EventHandler(this.listBoxGroup_DoubleClick);
            // 
            // dataGridViewShowAll
            // 
            this.dataGridViewShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAll.Location = new System.Drawing.Point(187, 75);
            this.dataGridViewShowAll.Name = "dataGridViewShowAll";
            this.dataGridViewShowAll.RowHeadersWidth = 18;
            this.dataGridViewShowAll.RowTemplate.Height = 80;
            this.dataGridViewShowAll.Size = new System.Drawing.Size(907, 357);
            this.dataGridViewShowAll.TabIndex = 3;
            // 
            // ShowFullContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1106, 444);
            this.Controls.Add(this.dataGridViewShowAll);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.linkLabelShowAll);
            this.Controls.Add(this.linkLabelGroup);
            this.Name = "ShowFullContactForm";
            this.Text = "ShowFullContactForm";
            this.Load += new System.EventHandler(this.ShowFullContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelGroup;
        private System.Windows.Forms.LinkLabel linkLabelShowAll;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.DataGridView dataGridViewShowAll;
    }
}