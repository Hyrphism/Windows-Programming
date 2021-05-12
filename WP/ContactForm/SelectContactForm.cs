using System;
using System.Windows.Forms;
using WP.Classes;

namespace WP.ContactForm
{
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }

        public int ContactID { get; set; }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            string query = "SELECT id, fname, lname, [group] FROM Contact";
            dataGridViewContact.DataSource = contact.GetTable(query);
        }

        private void dataGridViewContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ContactID = Convert.ToInt32(dataGridViewContact.CurrentRow.Cells[0].Value.ToString().Trim());
            this.Close();
        }
    }
}
