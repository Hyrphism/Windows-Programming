using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Classes;

namespace WP.Course_Form
{
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        int index = 0;

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            ReloadListBoxData();
        }

        void ReloadListBoxData()
        {
            listBoxCourse.DataSource = course.GetAllCourses();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = 0;
            labelTotalCourse.Text = ("Total Course: " + course.TotalCourse());
        }

        void ShowData(int idx)
        {
            DataRow dataRow = course.GetAllCourses().Rows[idx];
            listBoxCourse.SelectedIndex = idx;
            textBoxID.Text = dataRow.ItemArray[0].ToString();
            textBoxLabel.Text = dataRow.ItemArray[1].ToString();
            numericUpDown1.Value = int.Parse(dataRow.ItemArray[2].ToString());
            textBoxDescription.Text = dataRow.ItemArray[3].ToString();
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)listBoxCourse.SelectedItem;
            index = listBoxCourse.SelectedIndex;
            ShowData(index);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string label = textBoxLabel.Text;
            int period = Convert.ToInt32(numericUpDown1.Value);
            string description = textBoxDescription.Text;

            if (period < 1 || period > 24)
            {
                MessageBox.Show("The course period must be between 1 and 24 hours", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label.Trim() == "")
            {
                MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.CheckCourseName(label, id))
            {
                if (course.InsertCourse(id, label, period, description))
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

            textBoxID.Text = "";
            textBoxLabel.Text = "";
            textBoxDescription.Text = "";
            numericUpDown1.Value = 0;
            ReloadListBoxData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            string label = textBoxLabel.Text;
            int hour = (int)numericUpDown1.Value;
            string description = textBoxDescription.Text;

            if (course.UpdateCourse(id, label, hour, description))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);

                if ((MessageBox.Show("Are you sure to delete course?", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (course.DeleteCourse(id))
                    {
                        textBoxID.Text = "";
                        textBoxLabel.Text = "";
                        textBoxDescription.Text = "";
                        numericUpDown1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Course not deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Valid ID", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            index = 0;
            ReloadListBoxData();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxLabel.Text = "";
            textBoxDescription.Text = "";
            numericUpDown1.Value = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowData(index);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < course.GetAllCourses().Rows.Count - 1)
            {
                index += 1;
                ShowData(index);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index -= 1;
                ShowData(index);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            index = course.GetAllCourses().Rows.Count - 1;
            ShowData(index);
        }

    }
}
