using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Classes;

namespace WP.Student_Form
{
    public partial class AddCourseToStudent : Form
    {
        Course course = new Course();
        Student student = new Student();
        int currID;
        
        public AddCourseToStudent()
        {
            InitializeComponent();
        }

        private void AddCourseToStudent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < student.GetAllStudent().Rows.Count; i++)
            {
                comboBoxID.Items.Add(student.GetAllStudent().Rows[i].ItemArray[0]);
            }

            int year = 2019;
            for (int i = 0; i < 10; i++)
            {
                comboBoxSemester.Items.Add($"{year}-{year+1}");
                year += 1;
            }

            ReloadListBoxData();
            LoadListBoxSelectedCourse();
        }

        void ReloadListBoxData()
        {
            listBoxAvailableCourse.DataSource = course.GetAllCourses();
            listBoxAvailableCourse.ValueMember = "id";
            listBoxAvailableCourse.DisplayMember = "label";
            listBoxAvailableCourse.SelectedItem = 0;
        }

        void LoadListBoxSelectedCourse()
        {
            if (comboBoxID.Text == "")
            {
                listBoxSelectedCourse.DataSource = student.GetStudentByID();
            }
            else
            {
                listBoxSelectedCourse.DataSource = student.GetStudentByID(Convert.ToInt32(comboBoxID.Text));
            }
            listBoxSelectedCourse.ValueMember = "id";
            listBoxSelectedCourse.DisplayMember = "selected_course";
            listBoxSelectedCourse.SelectedItem = 0;
        }

        private void listBoxAvailableCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string validCourse = listBoxAvailableCourse.Text.Trim();
            string currSemester = comboBoxSemester.Text;
            string selectedCourse;

            if (currSemester == "")
            {
                MessageBox.Show("Choose semester", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (student.GetSelectedCourses(currID) == null)
                {
                    selectedCourse = "";
                }
                else
                {
                    selectedCourse = student.GetSelectedCourses(currID);
                }
                if (student.CheckValidCourse(selectedCourse, validCourse))
                {
                    if (selectedCourse == "")
                    {
                        selectedCourse += validCourse;
                    }
                    else
                    {
                        selectedCourse += (", " + validCourse);
                    }

                    if (student.InsertSelectedCourse(currID, selectedCourse))
                    {
                        MessageBox.Show("Insert Successfully ", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListBoxSelectedCourse();
                    }
                    else
                    {
                        MessageBox.Show("Insert Failed", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Course Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            comboBoxSemester.Text = "";
            ReloadListBoxData();
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAvailableCourse.DataSource = course.GetCourseBySemester(comboBoxSemester.Text);
            listBoxAvailableCourse.ValueMember = "id";
            listBoxAvailableCourse.DisplayMember = "label";
            listBoxAvailableCourse.SelectedItem = 0;
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelectedCourse.DataSource = student.GetStudentByID(Convert.ToInt32(comboBoxID.Text));
            listBoxSelectedCourse.ValueMember = "id";
            listBoxSelectedCourse.DisplayMember = "selected_course";
            listBoxSelectedCourse.SelectedItem = 0;

            currID = Convert.ToInt32(comboBoxID.Text);
        }
    }
}
