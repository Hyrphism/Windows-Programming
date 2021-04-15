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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                updateDeleteStdF.maleButton.Checked = true;
            }
            else
            {
                updateDeleteStdF.femaleButton.Checked = true;
            }

            updateDeleteStdF.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.pictureBox.Image = Image.FromStream(picture);

            updateDeleteStdF.Show();
        }

        private void showList()
        {
            try
            {
                MY_DB db = new MY_DB();
                db.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Student", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Student");
                db.closeConnection();

                dataGridView1.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Student"];
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            showList();
        }
    }
}
