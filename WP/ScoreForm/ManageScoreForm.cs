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
    public partial class ManageScoreForm : Form
    {
        Course course = new Course();
        Student student = new Student();
        Score score = new Score();
        DataTable labelTable;

        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, System.EventArgs e)
        {
            string query1 = "SELECT id, fname, lname FROM Student";
            string query2 = "Select id, label From Course";

            dataGridViewShow.DataSource = student.GetTable(query1);
            dataGridViewShow.AllowUserToAddRows = false;

            labelTable = course.GetTable(query2);

            foreach (DataRow row in labelTable.Rows)
            {
                cource_cb.Items.Add(row[1].ToString().Trim());
            }
        }

        private void add_btn_Click(object sender, System.EventArgs e)
        {
            if (id_tb.Text != "" && cource_cb.SelectedIndex != -1
                && description_tb.Text != "" && score_tb.Text != "")
            {
                score.StudentID = Convert.ToInt32(id_tb.Text);
                score.StudentScore = (float)Convert.ToDouble(score_tb.Text);
                score.Description = description_tb.Text;
                score.CourseID = Convert.ToInt32(labelTable.Rows[cource_cb.SelectedIndex][0].ToString());

                if (score.AddThisScore())
                {
                    MessageBox.Show("Complete!");
                }

                id_tb.Text = "";
                cource_cb.Text = "";
                score_tb.Text = "";
                description_tb.Text = "";
            }
            else
            {
                MessageBox.Show("Make sure you fill all gap!");
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            score.StudentID = Convert.ToInt32(id_tb.Text);
            score.CourseID = Convert.ToInt32(labelTable.Rows[cource_cb.SelectedIndex][0].ToString());
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
            dataGridViewShow.DataSource = score.getAllScore();
        }

        private void showStudent_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT id, fname, lname FROM Student";
            dataGridViewShow.DataSource = student.GetTable(query);
            dataGridViewShow.RowTemplate.Height = 70;
            dataGridViewShow.ReadOnly = true;
            dataGridViewShow.AllowUserToAddRows = false;

            dataGridViewShow.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewShow.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewShow.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showScore_btn_Click(object sender, EventArgs e)
        {
            dataGridViewShow.DataSource = score.getAllScore();
            dataGridViewShow.RowTemplate.Height = 70;
            dataGridViewShow.ReadOnly = true;
            dataGridViewShow.AllowUserToAddRows = false;

            dataGridViewShow.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewShow.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewShow.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewShow.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
