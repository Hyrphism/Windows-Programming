using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Classes;

namespace WP.UserForm
{
    public partial class RegisterUserForm : Form
    {
        MY_DB db = new MY_DB();
        User user = new User();

        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text.Trim());
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            MemoryStream pic = new MemoryStream();
            pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);

            if (username != "" || password != "")
            {
                if (!user.CheckUsernameExist(username, "register", id))
                {
                    if (user.InsertUser(id, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This User Already Exists", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Required Fields - Username/Password", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBox()
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            pictureBox.Image = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
