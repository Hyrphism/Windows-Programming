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

namespace WP
{
    public partial class RegisterStudentForm : Form
    {
        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlCommand command = new SqlCommand("INSERT INTO login (username, password) VALUES (@username, @password)", db.getConnection);
            SqlCommand checkUsername = new SqlCommand("SELECT * FROM login WHERE username = @username", db.getConnection);
            checkUsername.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameText.Text;

            db.openConnection();

            if (checkUsername.ExecuteNonQuery() < 1)
            {
                if (passwordText.Text == rePasswordText.Text)
                {
                    command.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameText.Text;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordText.Text;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Register complete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Your password is not unified", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Your username has been used", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            db.closeConnection();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
