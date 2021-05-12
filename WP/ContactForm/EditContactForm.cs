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
    public partial class EditContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public EditContactForm()
        {
            InitializeComponent();
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.GetAllGroup();
            comboBoxGroup.ValueMember = "id";
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.SelectedItem = 0;
            comboBoxGroup.Text = "";
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactForm = new SelectContactForm();
            selectContactForm.ShowDialog();

            int id = selectContactForm.ContactID;

            if (id != 0)
            {
                try
                {
                    DataTable table = contact.GetContactByID(id);

                    textBoxID.Text = id.ToString();
                    textBoxFname.Text = table.Rows[0][1].ToString().Trim();
                    textBoxLname.Text = table.Rows[0][2].ToString().Trim();
                    comboBoxGroup.Text = table.Rows[0][3].ToString().Trim();
                    textBoxPhone.Text = table.Rows[0][4].ToString().Trim();
                    textBoxEmail.Text = table.Rows[0][5].ToString().Trim();
                    textBoxAddress.Text = table.Rows[0][6].ToString().Trim();

                    byte[] pic = (byte[])table.Rows[0][7];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureContact.Image = Image.FromStream(picture);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Find Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text.Trim());
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            string _group = comboBoxGroup.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            int user_id = Global.GlobalUserID;

            MemoryStream picture = new MemoryStream();
            pictureContact.Image.Save(picture, pictureContact.Image.RawFormat);

            if (contact.UpdateContact(id, fname, lname, _group, phone, email, address, picture))
            {
                MessageBox.Show("Complete", "Edit complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearText();
            }
            else
            {
                MessageBox.Show("Error", "Edit fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
