using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Classes;

namespace WP.Course_Form
{
    public partial class AddCourseForm : Form
    {
        Course course = new Course();

        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            int year = 2019;
            for (int i = 0; i < 10; i++)
            {
                comboBoxSemester.Items.Add($"{year}-{year + 1}");
                year += 1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxCourseID.Text);
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(textBoxPeriod.Text);
            string description = textBoxDescription.Text;
            string semester = comboBoxSemester.Text;

            if (period < 1 || period > 24)
            {
                MessageBox.Show("The course period must be between 1 and 24 hours", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxSemester.Text == "")
            {
                MessageBox.Show("Invalid Semester", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label.Trim() == "")
            {
                MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.CheckCourseName(label, id))
            {
                if (course.InsertCourse(id, label, period, description, semester))
                {
                    MessageBox.Show("New course inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Course not inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This course name already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
