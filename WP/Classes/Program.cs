using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.ContactForm;

namespace WP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login_Form = new LoginForm();

            if (login_Form.ShowDialog() == DialogResult.OK)
            {
                if (login_Form.radioButtonStudent.Checked == true)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Run(new MainContactForm());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
