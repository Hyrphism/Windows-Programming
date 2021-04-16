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
            for (int i = 0; i < course.GetAllCourses().Rows.Count; i++)
            {
                comboBoxSelect.Items.Add(course.GetAllCourses().Rows[i].ItemArray[0]);
            }
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
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(numericUpDown1.Value);
            string description = textBoxDescription.Text;
            int id = Convert.ToInt32(comboBoxSelect.Text);

            if (course.UpdateCourse(id, label, period, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
