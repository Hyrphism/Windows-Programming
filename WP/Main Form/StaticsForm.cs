using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WP
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            Student student = new Student();

            string query = "SELECT gender, COUNT(gender) [Total] FROM Student GROUP BY gender";

            DataTable table = student.GetTable(query);
            string[] x = (from p in table.AsEnumerable()
                          orderby p.Field<string>("gender") ascending
                          select p.Field<string>("gender")).ToArray();

            int[] y = (from p in table.AsEnumerable()
                       orderby p.Field<string>("gender") ascending
                       select p.Field<int>("Total")).ToArray();

            BarChart.Series[0].LegendText = "Gender";
            BarChart.Series[0].ChartType = SeriesChartType.Column;
            BarChart.Titles.Add("Gender");
            BarChart.Series[0].Points.DataBindXY(x, y);

            PieChart.Series[0].ChartType = SeriesChartType.Pie;
            PieChart.Series[0].IsValueShownAsLabel = true;
            PieChart.Series[0].Points.DataBindXY(x, y);
            PieChart.ChartAreas[0].Area3DStyle.Enable3D = true;

            double total = student.GetTotal();
            double male = student.GetMale();
            double female = student.GetFemale();

            totalGender.Text = total.ToString();
            MaleScale.Text = ((male / total) * 100).ToString() + '%';
            FemaleScale.Text = ((female / total) * 100).ToString() + '%';
        }

        private void Total_Student(object sender, EventArgs e)
        {

        }

        private void PieChart_Click(object sender, EventArgs e)
        {

        }
    }
}
