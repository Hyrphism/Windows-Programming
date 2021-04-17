using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WP
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void account_Login(object sender, EventArgs e)
        {

        }

        private void avatar(object sender, EventArgs e)
        {

        }

        private void text_Box_Username(object sender, EventArgs e)
        {
        }

        private void text_Box_Password(object sender, EventArgs e)
        {

        }

        private void username(object sender, EventArgs e)
        {

        }

        private void password(object sender, EventArgs e)
        {
        }

        private void cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void login(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                errorProvider1.SetError(textBoxUsername, "Please enter username");
            }
            else
            {
                errorProvider1.SetError(textBoxUsername, null);
            }
        }

        private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProvider2.SetError(textBoxPassword, "Please enter password");
            }
            else
            {
                errorProvider2.SetError(textBoxPassword, null);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;

                MY_DB db = new MY_DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                db.openConnection();
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM login WHERE username = @user AND password = @pass", db.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();
                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
