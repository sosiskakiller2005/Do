using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1Kozlov
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (logTb.Text == "Login" && passTb.Text == "Password")
            {
                EmptyForm emptyForm = new EmptyForm();
                emptyForm.Show();
               
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
