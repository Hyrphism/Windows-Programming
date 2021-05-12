using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using WP.Classes;

namespace WP.ContactForm
{
    public partial class ShowFullContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public ShowFullContactForm()
        {
            InitializeComponent();
        }

        private void ShowFullContactForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxGroup.DataSource = group.GetAllGroup();
            listBoxGroup.ValueMember = "id";
            listBoxGroup.DisplayMember = "name";
            listBoxGroup.SelectedItem = 0;
        }

        private void linkLabelShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowContact(contact.SelectContactList());
        }

        private void listBoxGroup_DoubleClick(object sender, EventArgs e)
        {
            int idx = listBoxGroup.SelectedIndex;
            string _group = group.GetAllGroup().Rows[idx].ItemArray[1].ToString();
            DataTable table = contact.GetContactByGroup(_group);
            this.ShowContact(table);
        }

        private void ShowContact(DataTable table)
        {
            dataGridViewShowAll.DataSource = table;
            dataGridViewShowAll.RowTemplate.Height = 80;
            dataGridViewShowAll.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridViewShowAll.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewShowAll.AllowUserToAddRows = false;
        }
    }
}
