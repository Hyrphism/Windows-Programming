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

namespace WP.ContactForm
{
    public partial class AddContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.GetAllGroup();
            comboBoxGroup.ValueMember = "id";
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.SelectedItem = 0;
            comboBoxGroup.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text.Trim());
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            string _group = comboBoxGroup.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            int user_id = Global.GlobalUserID;

            MemoryStream pic = new MemoryStream();
            pictureContact.Image.Save(pic, pictureContact.Image.RawFormat);

            if (verif())
            {
                if (!contact.CheckContactID(id, user_id))
                {
                    if (contact.InsertContact(id, fname, lname, _group, phone, email, address, pic, user_id))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contact Already Exists", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((textBoxID.Text.Trim() == "")
                || (textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "") 
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "") 
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (pictureContact.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureContact.Image = Image.FromFile(opf.FileName);
                pictureContact.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ClearText()
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            comboBoxGroup.Text = "";
            pictureContact.Image = null;
        }
    }
}
