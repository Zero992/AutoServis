namespace Administrator
{
    partial class frmAdministracija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPodaci = new System.Windows.Forms.TextBox();
            this.txtIDAutomobila = new System.Windows.Forms.TextBox();
            this.lblCenaPopravke = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAzurirajCene = new System.Windows.Forms.Button();
            this.lblPodaci = new System.Windows.Forms.Label();
            this.btnBrisiPopravku = new System.Windows.Forms.Button();
            this.lblCenaDela = new System.Windows.Forms.Label();
            this.lblIDAutomobila = new System.Windows.Forms.Label();
            this.lblDodavanjeAutomobila = new System.Windows.Forms.Label();
            this.btnDodajPopravku = new System.Windows.Forms.Button();
            this.txtCenaDela = new System.Windows.Forms.TextBox();
            this.txtDeo = new System.Windows.Forms.TextBox();
            this.txtIDPopravke = new System.Windows.Forms.TextBox();
            this.lblIDPopravke = new System.Windows.Forms.Label();
            this.panKorisnik = new System.Windows.Forms.Panel();
            this.btnBrisiKorisnika = new System.Windows.Forms.Button();
            this.lblDodavanjeKorisnika = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblDeo = new System.Windows.Forms.Label();
            this.lblPopravka = new System.Windows.Forms.Label();
            this.btnBrisiAutomobil = new System.Windows.Forms.Button();
            this.btnDodajAutomobil = new System.Windows.Forms.Button();
            this.panAutomobili = new System.Windows.Forms.Panel();
            this.txtCenePopravke = new System.Windows.Forms.TextBox();
            this.panPopravka = new System.Windows.Forms.Panel();
            this.timerTroskovi = new System.Windows.Forms.Timer(this.components);
            this.panUkupniTroskovi = new System.Windows.Forms.Panel();
            this.lblUkupniTroskovi = new System.Windows.Forms.Label();
            this.txtUkupniTroskovi = new System.Windows.Forms.TextBox();
            this.panKorisnik.SuspendLayout();
            this.panAutomobili.SuspendLayout();
            this.panPopravka.SuspendLayout();
            this.panUkupniTroskovi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(103, 89);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 7;
            // 
            // txtPodaci
            // 
            this.txtPodaci.Location = new System.Drawing.Point(103, 63);
            this.txtPodaci.Name = "txtPodaci";
            this.txtPodaci.Size = new System.Drawing.Size(100, 20);
            this.txtPodaci.TabIndex = 6;
            // 
            // txtIDAutomobila
            // 
            this.txtIDAutomobila.Location = new System.Drawing.Point(103, 37);
            this.txtIDAutomobila.Name = "txtIDAutomobila";
            this.txtIDAutomobila.Size = new System.Drawing.Size(100, 20);
            this.txtIDAutomobila.TabIndex = 5;
            // 
            // lblCenaPopravke
            // 
            this.lblCenaPopravke.AutoSize = true;
            this.lblCenaPopravke.Location = new System.Drawing.Point(18, 119);
            this.lblCenaPopravke.Name = "lblCenaPopravke";
            this.lblCenaPopravke.Size = new System.Drawing.Size(81, 13);
            this.lblCenaPopravke.TabIndex = 4;
            this.lblCenaPopravke.Text = "Cena Popravke";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // btnAzurirajCene
            // 
            this.btnAzurirajCene.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAzurirajCene.Location = new System.Drawing.Point(23, 177);
            this.btnAzurirajCene.Name = "btnAzurirajCene";
            this.btnAzurirajCene.Size = new System.Drawing.Size(168, 23);
            this.btnAzurirajCene.TabIndex = 9;
            this.btnAzurirajCene.Text = "Azuriraj Cene";
            this.btnAzurirajCene.UseVisualStyleBackColor = false;
            this.btnAzurirajCene.Click += new System.EventHandler(this.btnAzurirajCene_Click);
            // 
            // lblPodaci
            // 
            this.lblPodaci.AutoSize = true;
            this.lblPodaci.Location = new System.Drawing.Point(18, 67);
            this.lblPodaci.Name = "lblPodaci";
            this.lblPodaci.Size = new System.Drawing.Size(40, 13);
            this.lblPodaci.TabIndex = 2;
            this.lblPodaci.Text = "Podaci";
            // 
            // btnBrisiPopravku
            // 
            this.btnBrisiPopravku.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrisiPopravku.Location = new System.Drawing.Point(23, 148);
            this.btnBrisiPopravku.Name = "btnBrisiPopravku";
            this.btnBrisiPopravku.Size = new System.Drawing.Size(168, 23);
            this.btnBrisiPopravku.TabIndex = 8;
            this.btnBrisiPopravku.Text = "Brisi Popravku";
            this.btnBrisiPopravku.UseVisualStyleBackColor = false;
            this.btnBrisiPopravku.Click += new System.EventHandler(this.btnBrisiPopravku_Click);
            // 
            // lblCenaDela
            // 
            this.lblCenaDela.AutoSize = true;
            this.lblCenaDela.Location = new System.Drawing.Point(20, 90);
            this.lblCenaDela.Name = "lblCenaDela";
            this.lblCenaDela.Size = new System.Drawing.Size(57, 13);
            this.lblCenaDela.TabIndex = 3;
            this.lblCenaDela.Text = "Cena Dela";
            // 
            // lblIDAutomobila
            // 
            this.lblIDAutomobila.AutoSize = true;
            this.lblIDAutomobila.Location = new System.Drawing.Point(18, 41);
            this.lblIDAutomobila.Name = "lblIDAutomobila";
            this.lblIDAutomobila.Size = new System.Drawing.Size(70, 13);
            this.lblIDAutomobila.TabIndex = 1;
            this.lblIDAutomobila.Text = "IDAutomobila";
            // 
            // lblDodavanjeAutomobila
            // 
            this.lblDodavanjeAutomobila.AutoSize = true;
            this.lblDodavanjeAutomobila.Location = new System.Drawing.Point(56, 13);
            this.lblDodavanjeAutomobila.Name = "lblDodavanjeAutomobila";
            this.lblDodavanjeAutomobila.Size = new System.Drawing.Size(114, 13);
            this.lblDodavanjeAutomobila.TabIndex = 0;
            this.lblDodavanjeAutomobila.Text = "Dodavanje Automobila";
            // 
            // btnDodajPopravku
            // 
            this.btnDodajPopravku.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDodajPopravku.Location = new System.Drawing.Point(23, 119);
            this.btnDodajPopravku.Name = "btnDodajPopravku";
            this.btnDodajPopravku.Size = new System.Drawing.Size(168, 23);
            this.btnDodajPopravku.TabIndex = 7;
            this.btnDodajPopravku.Text = "Dodaj Popravku";
            this.btnDodajPopravku.UseVisualStyleBackColor = false;
            this.btnDodajPopravku.Click += new System.EventHandler(this.btnDodajPopravku_Click);
            // 
            // txtCenaDela
            // 
            this.txtCenaDela.Location = new System.Drawing.Point(91, 86);
            this.txtCenaDela.Name = "txtCenaDela";
            this.txtCenaDela.Size = new System.Drawing.Size(100, 20);
            this.txtCenaDela.TabIndex = 6;
            // 
            // txtDeo
            // 
            this.txtDeo.Location = new System.Drawing.Point(91, 62);
            this.txtDeo.Name = "txtDeo";
            this.txtDeo.Size = new System.Drawing.Size(100, 20);
            this.txtDeo.TabIndex = 5;
            // 
            // txtIDPopravke
            // 
            this.txtIDPopravke.Location = new System.Drawing.Point(91, 36);
            this.txtIDPopravke.Name = "txtIDPopravke";
            this.txtIDPopravke.Size = new System.Drawing.Size(100, 20);
            this.txtIDPopravke.TabIndex = 4;
            // 
            // lblIDPopravke
            // 
            this.lblIDPopravke.AutoSize = true;
            this.lblIDPopravke.Location = new System.Drawing.Point(20, 40);
            this.lblIDPopravke.Name = "lblIDPopravke";
            this.lblIDPopravke.Size = new System.Drawing.Size(64, 13);
            this.lblIDPopravke.TabIndex = 1;
            this.lblIDPopravke.Text = "IDPopravke";
            // 
            // panKorisnik
            // 
            this.panKorisnik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panKorisnik.Controls.Add(this.btnBrisiKorisnika);
            this.panKorisnik.Controls.Add(this.lblDodavanjeKorisnika);
            this.panKorisnik.Controls.Add(this.lblKorisnickoIme);
            this.panKorisnik.Controls.Add(this.btnDodajKorisnika);
            this.panKorisnik.Controls.Add(this.lblPassword);
            this.panKorisnik.Controls.Add(this.txtPassword);
            this.panKorisnik.Controls.Add(this.txtKorisnickoIme);
            this.panKorisnik.Location = new System.Drawing.Point(12, 12);
            this.panKorisnik.Name = "panKorisnik";
            this.panKorisnik.Size = new System.Drawing.Size(225, 165);
            this.panKorisnik.TabIndex = 18;
            // 
            // btnBrisiKorisnika
            // 
            this.btnBrisiKorisnika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrisiKorisnika.Location = new System.Drawing.Point(18, 125);
            this.btnBrisiKorisnika.Name = "btnBrisiKorisnika";
            this.btnBrisiKorisnika.Size = new System.Drawing.Size(180, 23);
            this.btnBrisiKorisnika.TabIndex = 6;
            this.btnBrisiKorisnika.Text = "Brisi Korisnika";
            this.btnBrisiKorisnika.UseVisualStyleBackColor = false;
            this.btnBrisiKorisnika.Click += new System.EventHandler(this.btnBrisiKorisnika_Click);
            // 
            // lblDodavanjeKorisnika
            // 
            this.lblDodavanjeKorisnika.AutoSize = true;
            this.lblDodavanjeKorisnika.Location = new System.Drawing.Point(54, 14);
            this.lblDodavanjeKorisnika.Name = "lblDodavanjeKorisnika";
            this.lblDodavanjeKorisnika.Size = new System.Drawing.Size(105, 13);
            this.lblDodavanjeKorisnika.TabIndex = 5;
            this.lblDodavanjeKorisnika.Text = "Dodavanje Korisnika";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(15, 46);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(76, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisnicko Ime";
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(18, 95);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(180, 23);
            this.btnDodajKorisnika.TabIndex = 4;
            this.btnDodajKorisnika.Text = "Dodaj Korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(98, 42);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnickoIme.TabIndex = 2;
            // 
            // lblDeo
            // 
            this.lblDeo.AutoSize = true;
            this.lblDeo.Location = new System.Drawing.Point(20, 66);
            this.lblDeo.Name = "lblDeo";
            this.lblDeo.Size = new System.Drawing.Size(27, 13);
            this.lblDeo.TabIndex = 2;
            this.lblDeo.Text = "Deo";
            // 
            // lblPopravka
            // 
            this.lblPopravka.AutoSize = true;
            this.lblPopravka.Location = new System.Drawing.Point(88, 13);
            this.lblPopravka.Name = "lblPopravka";
            this.lblPopravka.Size = new System.Drawing.Size(53, 13);
            this.lblPopravka.TabIndex = 0;
            this.lblPopravka.Text = "Popravka";
            // 
            // btnBrisiAutomobil
            // 
            this.btnBrisiAutomobil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrisiAutomobil.Location = new System.Drawing.Point(21, 171);
            this.btnBrisiAutomobil.Name = "btnBrisiAutomobil";
            this.btnBrisiAutomobil.Size = new System.Drawing.Size(182, 23);
            this.btnBrisiAutomobil.TabIndex = 10;
            this.btnBrisiAutomobil.Text = "Brisi Automobil";
            this.btnBrisiAutomobil.UseVisualStyleBackColor = false;
            this.btnBrisiAutomobil.Click += new System.EventHandler(this.btnBrisiAutomobil_Click);
            // 
            // btnDodajAutomobil
            // 
            this.btnDodajAutomobil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDodajAutomobil.Location = new System.Drawing.Point(21, 141);
            this.btnDodajAutomobil.Name = "btnDodajAutomobil";
            this.btnDodajAutomobil.Size = new System.Drawing.Size(182, 23);
            this.btnDodajAutomobil.TabIndex = 9;
            this.btnDodajAutomobil.Text = "Dodaj Automobil";
            this.btnDodajAutomobil.UseVisualStyleBackColor = false;
            this.btnDodajAutomobil.Click += new System.EventHandler(this.btnDodajAutomobil_Click);
            // 
            // panAutomobili
            // 
            this.panAutomobili.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panAutomobili.Controls.Add(this.btnBrisiAutomobil);
            this.panAutomobili.Controls.Add(this.btnDodajAutomobil);
            this.panAutomobili.Controls.Add(this.txtCenePopravke);
            this.panAutomobili.Controls.Add(this.txtStatus);
            this.panAutomobili.Controls.Add(this.txtPodaci);
            this.panAutomobili.Controls.Add(this.txtIDAutomobila);
            this.panAutomobili.Controls.Add(this.lblCenaPopravke);
            this.panAutomobili.Controls.Add(this.lblStatus);
            this.panAutomobili.Controls.Add(this.lblPodaci);
            this.panAutomobili.Controls.Add(this.lblIDAutomobila);
            this.panAutomobili.Controls.Add(this.lblDodavanjeAutomobila);
            this.panAutomobili.Location = new System.Drawing.Point(244, 13);
            this.panAutomobili.Name = "panAutomobili";
            this.panAutomobili.Size = new System.Drawing.Size(236, 204);
            this.panAutomobili.TabIndex = 19;
            // 
            // txtCenePopravke
            // 
            this.txtCenePopravke.Location = new System.Drawing.Point(103, 115);
            this.txtCenePopravke.Name = "txtCenePopravke";
            this.txtCenePopravke.Size = new System.Drawing.Size(100, 20);
            this.txtCenePopravke.TabIndex = 8;
            // 
            // panPopravka
            // 
            this.panPopravka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panPopravka.Controls.Add(this.btnAzurirajCene);
            this.panPopravka.Controls.Add(this.btnBrisiPopravku);
            this.panPopravka.Controls.Add(this.btnDodajPopravku);
            this.panPopravka.Controls.Add(this.txtCenaDela);
            this.panPopravka.Controls.Add(this.txtDeo);
            this.panPopravka.Controls.Add(this.txtIDPopravke);
            this.panPopravka.Controls.Add(this.lblCenaDela);
            this.panPopravka.Controls.Add(this.lblDeo);
            this.panPopravka.Controls.Add(this.lblIDPopravke);
            this.panPopravka.Controls.Add(this.lblPopravka);
            this.panPopravka.Location = new System.Drawing.Point(497, 13);
            this.panPopravka.Name = "panPopravka";
            this.panPopravka.Size = new System.Drawing.Size(200, 222);
            this.panPopravka.TabIndex = 20;
            // 
            // timerTroskovi
            // 
            this.timerTroskovi.Enabled = true;
            this.timerTroskovi.Interval = 3000;
            this.timerTroskovi.Tick += new System.EventHandler(this.timerTroskovi_Tick);
            // 
            // panUkupniTroskovi
            // 
            this.panUkupniTroskovi.Controls.Add(this.txtUkupniTroskovi);
            this.panUkupniTroskovi.Controls.Add(this.lblUkupniTroskovi);
            this.panUkupniTroskovi.Location = new System.Drawing.Point(13, 253);
            this.panUkupniTroskovi.Name = "panUkupniTroskovi";
            this.panUkupniTroskovi.Size = new System.Drawing.Size(224, 253);
            this.panUkupniTroskovi.TabIndex = 21;
            // 
            // lblUkupniTroskovi
            // 
            this.lblUkupniTroskovi.AutoSize = true;
            this.lblUkupniTroskovi.Location = new System.Drawing.Point(63, 10);
            this.lblUkupniTroskovi.Name = "lblUkupniTroskovi";
            this.lblUkupniTroskovi.Size = new System.Drawing.Size(85, 13);
            this.lblUkupniTroskovi.TabIndex = 1;
            this.lblUkupniTroskovi.Text = "Ukupni Troskovi";
            // 
            // txtUkupniTroskovi
            // 
            this.txtUkupniTroskovi.Location = new System.Drawing.Point(17, 26);
            this.txtUkupniTroskovi.Multiline = true;
            this.txtUkupniTroskovi.Name = "txtUkupniTroskovi";
            this.txtUkupniTroskovi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUkupniTroskovi.Size = new System.Drawing.Size(193, 213);
            this.txtUkupniTroskovi.TabIndex = 2;
            // 
            // frmAdministracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 518);
            this.Controls.Add(this.panUkupniTroskovi);
            this.Controls.Add(this.panKorisnik);
            this.Controls.Add(this.panAutomobili);
            this.Controls.Add(this.panPopravka);
            this.Name = "frmAdministracija";
            this.Text = "Administracija";
            this.panKorisnik.ResumeLayout(false);
            this.panKorisnik.PerformLayout();
            this.panAutomobili.ResumeLayout(false);
            this.panAutomobili.PerformLayout();
            this.panPopravka.ResumeLayout(false);
            this.panPopravka.PerformLayout();
            this.panUkupniTroskovi.ResumeLayout(false);
            this.panUkupniTroskovi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPodaci;
        private System.Windows.Forms.TextBox txtIDAutomobila;
        private System.Windows.Forms.Label lblCenaPopravke;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAzurirajCene;
        private System.Windows.Forms.Label lblPodaci;
        private System.Windows.Forms.Button btnBrisiPopravku;
        private System.Windows.Forms.Label lblCenaDela;
        private System.Windows.Forms.Label lblIDAutomobila;
        private System.Windows.Forms.Label lblDodavanjeAutomobila;
        private System.Windows.Forms.Button btnDodajPopravku;
        private System.Windows.Forms.TextBox txtCenaDela;
        private System.Windows.Forms.TextBox txtDeo;
        private System.Windows.Forms.TextBox txtIDPopravke;
        private System.Windows.Forms.Label lblIDPopravke;
        private System.Windows.Forms.Panel panKorisnik;
        private System.Windows.Forms.Button btnBrisiKorisnika;
        private System.Windows.Forms.Label lblDodavanjeKorisnika;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblDeo;
        private System.Windows.Forms.Label lblPopravka;
        private System.Windows.Forms.Button btnBrisiAutomobil;
        private System.Windows.Forms.Button btnDodajAutomobil;
        private System.Windows.Forms.Panel panAutomobili;
        private System.Windows.Forms.TextBox txtCenePopravke;
        private System.Windows.Forms.Panel panPopravka;
        private System.Windows.Forms.Timer timerTroskovi;
        private System.Windows.Forms.Panel panUkupniTroskovi;
        private System.Windows.Forms.Label lblUkupniTroskovi;
        private System.Windows.Forms.TextBox txtUkupniTroskovi;
    }
}