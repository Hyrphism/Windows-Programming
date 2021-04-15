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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void RemoveCourse_Load(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            DialogResult remove = MessageBox.Show("Do you want to delete course by id: " + textBoxID.Text, "",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            int id = Convert.ToInt32(textBoxID.Text);
            if (remove == DialogResult.Yes)
            {
                if (course.RemoveCourse(id))
                {
                    MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
