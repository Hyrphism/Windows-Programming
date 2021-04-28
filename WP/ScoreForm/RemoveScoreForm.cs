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

namespace WP
{
    public partial class RemoveScoreForm : Form
    {
        Score score = new Score();

        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            loadScore();

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            score.StudentID = Convert.ToInt32(dataGridViewRemove.CurrentRow.Cells[0].Value);
            score.CourseID = Convert.ToInt32(dataGridViewRemove.CurrentRow.Cells[1].Value);
            if (score.RemoveThisScore())
            {
                MessageBox.Show("Complete!");
                this.loadScore();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
        private void loadScore()
        {
            string query = "select s.student_id, st.fname, st.lname, c.id as 'course_id' , c.label, s.student_score " +
                           "from Score s " +
                           "inner join Course c " +
                           "on s.course_id = c.id " +
                           "inner join Student st " +
                           "on st.id = s.student_id";
            dataGridViewRemove.DataSource = score.GetTable(query);
            dataGridViewRemove.RowTemplate.Height = 70;
            dataGridViewRemove.ReadOnly = true;
            dataGridViewRemove.AllowUserToAddRows = false;

            dataGridViewRemove.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewRemove.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewRemove.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewRemove.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewRemove.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewRemove.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
