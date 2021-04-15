using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Add_Student_Form_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureStudent.Image = Image.FromFile(opf.FileName);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            int id = Convert.ToInt32(textBoxStudentID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year < 10) || (this_year - born_year > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                PictureStudent.Image.Save(pic, PictureStudent.Image.RawFormat);
                if (student.InsertStudent(id, fname, lname, bdate, gender, phone, address, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (PictureStudent.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PictureStudent_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
