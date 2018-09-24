using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klijent
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AutoServis.KlijentClient client = new AutoServis.KlijentClient();
            if (client.LogInKorisnik(txtUsername.Text, txtPassword.Text))
            {
                frmKlijent frmklijent = new frmKlijent(txtUsername.Text);
                frmklijent.Show();
            } else MessageBox.Show("Niste uneli dobar username ili password");
        }
    }
}
