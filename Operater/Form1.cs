using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Operater.AutoServis;

namespace Operater
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AutoServis.OperaterClient client = new AutoServis.OperaterClient();
            if (client.OperaterLogin(txtUsername.Text, txtPassword.Text))
            {
                frmOperater frmoperater = new frmOperater();
                frmoperater.Show();
            } else MessageBox.Show("Niste uneli dobar username ili password");
        }
    }
}
