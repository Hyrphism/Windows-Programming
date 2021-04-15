using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Classes;

namespace WP.Course_Form
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();

        private void EditCourse_Load(object sender, EventArgs e)
        {
            comboBoxSelect.DataSource = course.GetAllCourses();
            comboBoxSelect.DisplayMember = "label";
            comboBoxSelect.ValueMember = "id";
            comboBoxSelect.SelectedItem = 0;
        }

        public void FillCombo(int index)
        {
            comboBoxSelect.DataSource = course.GetAllCourses();
            comboBoxSelect.DisplayMember = "label";
            comboBoxSelect.ValueMember = "id";
            comboBoxSelect.SelectedItem = index;
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxSelect.Text);
                DataTable table = new DataTable();
                table = course.GetCourseByID(id);
                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDown1.Value = Convert.ToInt32(table.Rows[0][2].ToString());
                textBoxDescription.Text = table.Rows[0][3].ToString();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string label = textBoxLabel.Text;
            int period = (int)numericUpDown1.Value;
            string description = textBoxDescription.Text;
            int id = (int)comboBoxSelect.SelectedValue;

            if (course.CheckCourseName(label, id))
            {
                MessageBox.Show("This course already exists", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.UpdateCourse(id, label, period, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillCombo(comboBoxSelect.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
