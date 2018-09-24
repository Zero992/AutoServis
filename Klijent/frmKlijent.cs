using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Klijent.AutoServis;

namespace Klijent
{
    public partial class frmKlijent : Form
    {
        string korisnicko_ime;
        public frmKlijent(string korisnicko_ime)
        {
            InitializeComponent();
            KlijentClient client = new KlijentClient();
            txtPrikazKorisniku.Text = client.PrikazKorisniku(korisnicko_ime);
            this.korisnicko_ime = korisnicko_ime;
        }

        private void btnPlati_Click(object sender, EventArgs e)
        {
            KlijentClient client = new KlijentClient();
            client.Uplati(korisnicko_ime);
        }
    }
}
