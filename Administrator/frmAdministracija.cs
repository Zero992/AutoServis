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
    public partial class frmAdministracija : Form
    {
        public frmAdministracija()
        {
            InitializeComponent();

        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if (txtKorisnickoIme.Text != null && txtPassword.Text != null)
                client.Korisnik(txtKorisnickoIme.Text, txtPassword.Text);
            else MessageBox.Show("Niste punili Korisnicko ime i/ili Prezime.");
        } 

        private void btnBrisiKorisnika_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if (txtKorisnickoIme != null)
                client.brisiKorisnika(txtKorisnickoIme.Text);
            else MessageBox.Show("Niste uneli korisnicko ime.");
        }

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if (txtKorisnickoIme != null && txtIDAutomobila != null && txtPodaci != null && txtStatus != null && txtCenePopravke != null && txtIDPopravke != null)
                client.Automobil(Int32.Parse(txtIDAutomobila.Text), txtPodaci.Text, txtStatus.Text, Convert.ToDouble(txtCenePopravke.Text), txtKorisnickoIme.Text, Int32.Parse(txtIDPopravke.Text));
            else MessageBox.Show("Niste popunili neke od navedenih polja: Korisnicko ime,IDAutomobila,Podaci,Status,Cene Popravke, IDPopravke.");
        }

        private void btnBrisiAutomobil_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if(txtIDAutomobila!=null)
                client.brisiAuto(Int32.Parse(txtIDAutomobila.Text));
            else MessageBox.Show("Niste uneli IDAutomobila.");
        }

        private void btnDodajPopravku_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if (txtIDPopravke!=null&&txtDeo!=null&&txtCenaDela!=null)
                client.Popravka(Int32.Parse(txtIDPopravke.Text), txtDeo.Text, Convert.ToDouble(txtCenaDela.Text));
            else MessageBox.Show("Niste uneli IDPopravke i/ili Cene Dela.");
        }

        private void btnBrisiPopravku_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if(txtIDPopravke!=null)
                client.brisiPopravke(Int32.Parse(txtIDPopravke.Text));
            else MessageBox.Show("Niste uneli IDPopravke.");
        }

        private void btnAzurirajCene_Click(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            if(txtDeo.Text!=null&&txtCenaDela!=null)
                client.AzuriranjeCene(txtDeo.Text, Int32.Parse(txtCenaDela.Text));
            else MessageBox.Show("Niste uneli Deo i/ili Cena Dela.");
        }

        private void timerTroskovi_Tick(object sender, EventArgs e)
        {
            AutoServis.SistemClient client = new AutoServis.SistemClient();
            txtUkupniTroskovi.Text = client.UkupniTroskoviString();
        }
    }
}
