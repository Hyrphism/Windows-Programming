using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Student student = new Student();
        private void Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE id = " + id);
            DataTable table = student.GetStudent(command);

            if (table.Rows.Count > 0)
            {
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    femaleButton.Checked = true;
                }
                else
                {
                    maleButton.Checked = true;
                }

                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            string path = null;
            OpenFileDialog ofdImage = new OpenFileDialog();
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                path = ofdImage.FileName;
            }
            pictureBox.Image = Image.FromFile(path.ToString());
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                MY_DB db = new MY_DB();
                SqlCommand command = new SqlCommand(
                    "UPDATE Student " +
                    "SET " +
                    "fname = @fname, " +
                    "lname = @lname, " +
                    "bdate = @bdate, " +
                    "gender = @gender, " +
                    "phone = @phone, " +
                    "address = @address, " +
                    "picture = @picture " +
                    "WHERE id = @id"
                    , db.getConnection);
                command.Parameters.Add("@fname", SqlDbType.VarChar).Value = textBoxFname.Text;
                command.Parameters.Add("@lname", SqlDbType.VarChar).Value = textBoxLname.Text;
                command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = dateTimePicker1.Value;

                string gender = "Male";
                if (femaleButton.Checked)
                {
                    gender = "Female";
                }
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = textBoxPhone.Text;
                command.Parameters.Add("@address", SqlDbType.VarChar).Value = textBoxAddress.Text;

                ImageConverter imgConverter = new ImageConverter();
                byte[] pic = (byte[])imgConverter.ConvertTo(pictureBox.Image, typeof(byte[]));
                command.Parameters.Add("@picture", SqlDbType.Image).Value = pic;
                command.Parameters.Add("@id", SqlDbType.Int).Value = textBoxID.Text;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Complete", "Edit complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "Edit fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.closeConnection();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you really want to delete student with id: " + textBoxID.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                int id = Convert.ToInt32(textBoxID.Text);
                if (delete == DialogResult.Yes)
                {
                    if (student.DeleteStudent(id))
                    {
                        MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxID.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

    }
}
