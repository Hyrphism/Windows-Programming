using System.Windows.Forms;
using WP.Classes;

namespace WP
{
    public partial class AverageScore : Form
    {
        public AverageScore()
        {
            InitializeComponent();
        }

        private void AvarageScore_Load(object sender, System.EventArgs e)
        {
            Course course = new Course();

            DataGridViewAVG.DataSource = course.GetAverageScore();
            DataGridViewAVG.RowTemplate.Height = 70;
            DataGridViewAVG.ReadOnly = true;
            DataGridViewAVG.AllowUserToAddRows = false;

            DataGridViewAVG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewAVG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
