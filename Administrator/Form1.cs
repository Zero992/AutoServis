using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Administrator
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if (client.LogInAdministrator(txtUsername.Text, txtPassword.Text))
            {
                frmAdministracija frmadministracija = new frmAdministracija();
                frmadministracija.Show();
            }
            else MessageBox.Show("Niste uneli dobar username ili password");
        }
    }
}
