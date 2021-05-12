using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WP.Classes;
using WP.UserForm;

namespace WP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            if (radioButtonStudent.Checked == true)
            {
                RegisterStudentForm registerStudentForm = new RegisterStudentForm();
                registerStudentForm.ShowDialog();
            }
            else
            {
                RegisterUserForm registerUserForm = new RegisterUserForm();
                registerUserForm.ShowDialog();
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            radioButtonStudent.Checked = true;
        }

        private void textBoxUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string source = "login";
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;

                if (radioButtonHumanResource.Checked == true)
                {
                    source = "[User]";
                }
                MY_DB db = new MY_DB();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                db.openConnection();
                SqlCommand command = new SqlCommand(
                    $"SELECT * FROM {source} WHERE username = @user AND password = @pass", db.getConnection);
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = textBoxUsername.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.closeConnection();
                if (table.Rows.Count > 0)
                {
                    if (source == "[User]")
                    {
                        int id = Convert.ToInt32(table.Rows[0][0].ToString());
                        Global.SetGlobalUserID(id);
                    }
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
