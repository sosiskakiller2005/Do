using _5._1Kozlov.AppDAta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _5._1Kozlov
{
    public partial class AuthorisationForm : Form
    {
        string path = "users.csv";
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
            StreamReader streamReader = new StreamReader(path);
            User user = new User();
            while (!streamReader.EndOfStream)
            {
                string[] userArray = streamReader.ReadLine().Split(';');
                user.Login = userArray[0];
                user.Password = userArray[1];
                user.Role = userArray[2];
                if (logTb.Text == user.Login && passTb.Text == user.Password && user.Role == "dir")
                {
                    //форма директора
                    DirectorForm directorForm = new DirectorForm();
                    directorForm.Show();

                }
                else if (logTb.Text == user.Login && passTb.Text == user.Password && user.Role == "user")
                {
                    EmptyForm emptyForm = new EmptyForm();
                    emptyForm.Show();
                }
            }

        }
    }
}
