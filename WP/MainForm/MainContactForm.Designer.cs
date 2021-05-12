namespace WP.ContactForm
{
    partial class MainContactForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveContact = new System.Windows.Forms.Button();
            this.buttonSelectContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelContactID = new System.Windows.Forms.Label();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelected = new System.Windows.Forms.ComboBox();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewGroup = new System.Windows.Forms.Label();
            this.labelSelectGoup = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxSelected2 = new System.Windows.Forms.ComboBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabelRefresh);
            this.groupBox1.Controls.Add(this.linkLabelEdit);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelWelcome);
            this.groupBox1.Controls.Add(this.pictureBoxContact);
            this.groupBox1.Location = new System.Drawing.Point(-2, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "||";
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRefresh.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelRefresh.Location = new System.Drawing.Point(286, 91);
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size(79, 25);
            this.linkLabelRefresh.TabIndex = 16;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            this.linkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefresh_LinkClicked);
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEdit.LinkColor = System.Drawing.Color.Red;
            this.linkLabelEdit.Location = new System.Drawing.Point(141, 91);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(112, 25);
            this.linkLabelEdit.TabIndex = 15;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit my info";
            this.linkLabelEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEdit_LinkClicked);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Broadway", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(178, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(174, 31);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Full Name";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWelcome.Location = new System.Drawing.Point(139, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(105, 37);
            this.labelWelcome.TabIndex = 13;
            this.labelWelcome.Text = "Welcome";
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxContact.Location = new System.Drawing.Point(15, 19);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(106, 89);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 0;
            this.pictureBoxContact.TabStop = false;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Brush Script MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelContact.Location = new System.Drawing.Point(2, 136);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(159, 61);
            this.labelContact.TabIndex = 1;
            this.labelContact.Text = "Contact";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Brush Script MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGroup.Location = new System.Drawing.Point(555, 136);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(130, 61);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Group";
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddContact.Location = new System.Drawing.Point(12, 210);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(166, 38);
            this.buttonAddContact.TabIndex = 3;
            this.buttonAddContact.Text = "Add";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditContact.Location = new System.Drawing.Point(215, 210);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(166, 38);
            this.buttonEditContact.TabIndex = 4;
            this.buttonEditContact.Text = "Edit";
            this.buttonEditContact.UseVisualStyleBackColor = true;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveContact);
            this.groupBox2.Controls.Add(this.buttonSelectContact);
            this.groupBox2.Controls.Add(this.textBoxContactID);
            this.groupBox2.Controls.Add(this.labelContactID);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 184);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // buttonRemoveContact
            // 
            this.buttonRemoveContact.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveContact.Location = new System.Drawing.Point(264, 117);
            this.buttonRemoveContact.Name = "buttonRemoveContact";
            this.buttonRemoveContact.Size = new System.Drawing.Size(220, 37);
            this.buttonRemoveContact.TabIndex = 7;
            this.buttonRemoveContact.Text = "Remove Contact";
            this.buttonRemoveContact.UseVisualStyleBackColor = true;
            this.buttonRemoveContact.Click += new System.EventHandler(this.buttonRemoveContact_Click);
            // 
            // buttonSelectContact
            // 
            this.buttonSelectContact.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.buttonSelectContact.Location = new System.Drawing.Point(264, 60);
            this.buttonSelectContact.Name = "buttonSelectContact";
            this.buttonSelectContact.Size = new System.Drawing.Size(220, 37);
            this.buttonSelectContact.TabIndex = 6;
            this.buttonSelectContact.Text = "Select Contact";
            this.buttonSelectContact.UseVisualStyleBackColor = true;
            this.buttonSelectContact.Click += new System.EventHandler(this.buttonSelectContact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactID.Location = new System.Drawing.Point(11, 60);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(247, 33);
            this.textBoxContactID.TabIndex = 1;
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactID.Location = new System.Drawing.Point(6, 18);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(187, 26);
            this.labelContactID.TabIndex = 0;
            this.labelContactID.Text = "Enter Contact ID:";
            // 
            // buttonShowList
            // 
            this.buttonShowList.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.buttonShowList.Location = new System.Drawing.Point(13, 446);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(490, 38);
            this.buttonShowList.TabIndex = 8;
            this.buttonShowList.Text = "Show Full List Contact";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 374);
            this.label2.TabIndex = 9;
            this.label2.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n|" +
    "|\r\n||";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxGroupID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonAddGroup);
            this.groupBox3.Controls.Add(this.textBoxGroupName);
            this.groupBox3.Controls.Add(this.labelGroupID);
            this.groupBox3.Location = new System.Drawing.Point(531, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 97);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupID.Location = new System.Drawing.Point(209, 11);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.Size = new System.Drawing.Size(183, 33);
            this.textBoxGroupID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Group ID:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.Location = new System.Drawing.Point(397, 30);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(126, 38);
            this.buttonAddGroup.TabIndex = 11;
            this.buttonAddGroup.Text = "Add";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(208, 58);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(183, 33);
            this.textBoxGroupName.TabIndex = 8;
            // 
            // labelGroupID
            // 
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupID.Location = new System.Drawing.Point(0, 61);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(209, 26);
            this.labelGroupID.TabIndex = 1;
            this.labelGroupID.Text = "Enter Group Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSelected);
            this.groupBox4.Controls.Add(this.buttonEditGroup);
            this.groupBox4.Controls.Add(this.textBoxNewName);
            this.groupBox4.Controls.Add(this.labelNewGroup);
            this.groupBox4.Controls.Add(this.labelSelectGoup);
            this.groupBox4.Location = new System.Drawing.Point(531, 303);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 105);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // comboBoxSelected
            // 
            this.comboBoxSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxSelected.FormattingEnabled = true;
            this.comboBoxSelected.Location = new System.Drawing.Point(208, 15);
            this.comboBoxSelected.Name = "comboBoxSelected";
            this.comboBoxSelected.Size = new System.Drawing.Size(183, 34);
            this.comboBoxSelected.TabIndex = 15;
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditGroup.Location = new System.Drawing.Point(397, 37);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(126, 38);
            this.buttonEditGroup.TabIndex = 12;
            this.buttonEditGroup.Text = "Edit";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(208, 61);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(183, 33);
            this.textBoxNewName.TabIndex = 14;
            // 
            // labelNewGroup
            // 
            this.labelNewGroup.AutoSize = true;
            this.labelNewGroup.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGroup.Location = new System.Drawing.Point(11, 61);
            this.labelNewGroup.Name = "labelNewGroup";
            this.labelNewGroup.Size = new System.Drawing.Size(192, 26);
            this.labelNewGroup.TabIndex = 13;
            this.labelNewGroup.Text = "Enter New Name:";
            // 
            // labelSelectGoup
            // 
            this.labelSelectGoup.AutoSize = true;
            this.labelSelectGoup.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGoup.Location = new System.Drawing.Point(51, 18);
            this.labelSelectGoup.Name = "labelSelectGoup";
            this.labelSelectGoup.Size = new System.Drawing.Size(152, 26);
            this.labelSelectGoup.TabIndex = 12;
            this.labelSelectGoup.Text = "Select Group:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSelected2);
            this.groupBox5.Controls.Add(this.buttonRemoveGroup);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(531, 414);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(529, 70);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // comboBoxSelected2
            // 
            this.comboBoxSelected2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxSelected2.FormattingEnabled = true;
            this.comboBoxSelected2.Location = new System.Drawing.Point(208, 15);
            this.comboBoxSelected2.Name = "comboBoxSelected2";
            this.comboBoxSelected2.Size = new System.Drawing.Size(183, 34);
            this.comboBoxSelected2.TabIndex = 16;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveGroup.Location = new System.Drawing.Point(397, 11);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(126, 38);
            this.buttonRemoveGroup.TabIndex = 15;
            this.buttonRemoveGroup.Text = "Remove";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Group:";
            // 
            // MainContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1072, 505);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonEditContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainContactForm";
            this.Text = "MainContactForm";
            this.Load += new System.EventHandler(this.MainContactForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.Button buttonRemoveContact;
        private System.Windows.Forms.Button buttonSelectContact;
        private System.Windows.Forms.Label labelContactID;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelGroupID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ComboBox comboBoxSelected;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewGroup;
        private System.Windows.Forms.Label labelSelectGoup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxSelected2;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Label label4;
    }
}