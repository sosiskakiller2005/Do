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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
