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
    public partial class frmOperater : Form
    {
        public frmOperater()
        {
            InitializeComponent();
        }
        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            OperaterClient client = new OperaterClient();
            if (txtKorisnickoIme.Text != null && txtPassword.Text != null)
                client.OperaterKorisnik(txtKorisnickoIme.Text, txtPassword.Text);
            else MessageBox.Show("Niste punili Korisnicko ime i/ili Prezime.");
        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            OperaterClient client = new OperaterClient();
            if (txtKorisnickoIme != null && txtIDAutomobila != null && txtPodaci != null && txtStatus != null && txtCenePopravke != null && txtIDPopravke != null)
                client.OperaterAutomobil(Int32.Parse(txtIDAutomobila.Text), txtPodaci.Text, txtStatus.Text, Convert.ToDouble(txtCenePopravke.Text), txtKorisnickoIme.Text, Int32.Parse(txtIDPopravke.Text));
            else MessageBox.Show("Niste popunili neke od navedenih polja: Korisnicko ime,IDAutomobila,Podaci,Status,Cene Popravke, IDPopravke.");
        }

        private void btnDodajPopravku_Click(object sender, EventArgs e)
        {
            OperaterClient client = new OperaterClient();
            if (txtIDPopravke != null && txtDeo != null && txtCenaDela != null)
                client.OperaterPopravka(Int32.Parse(txtIDPopravke.Text), txtDeo.Text, Convert.ToDouble(txtCenaDela.Text));
            else MessageBox.Show("Niste uneli IDPopravke i/ili Cene Dela.");
        }

        private void btnAzurirajCene_Click(object sender, EventArgs e)
        {
            OperaterClient client = new OperaterClient();
            if (txtDeo.Text != null && txtCenaDela != null)
                client.OperaterAzuriranjeCene(txtDeo.Text, Int32.Parse(txtCenaDela.Text));
            else MessageBox.Show("Niste uneli Deo i/ili Cena Dela.");
        }
    }
}
