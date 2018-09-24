namespace Klijent
{
    partial class frmKlijent
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
            this.btnPlati = new System.Windows.Forms.Button();
            this.txtPrikazKorisniku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlati
            // 
            this.btnPlati.Location = new System.Drawing.Point(338, 12);
            this.btnPlati.Name = "btnPlati";
            this.btnPlati.Size = new System.Drawing.Size(75, 31);
            this.btnPlati.TabIndex = 7;
            this.btnPlati.Text = "Plati";
            this.btnPlati.UseVisualStyleBackColor = true;
            this.btnPlati.Click += new System.EventHandler(this.btnPlati_Click);
            // 
            // txtPrikazKorisniku
            // 
            this.txtPrikazKorisniku.Location = new System.Drawing.Point(13, 12);
            this.txtPrikazKorisniku.Name = "txtPrikazKorisniku";
            this.txtPrikazKorisniku.Size = new System.Drawing.Size(319, 20);
            this.txtPrikazKorisniku.TabIndex = 8;
            // 
            // frmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 51);
            this.Controls.Add(this.txtPrikazKorisniku);
            this.Controls.Add(this.btnPlati);
            this.Name = "frmKlijent";
            this.Text = "Klijent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlati;
        private System.Windows.Forms.TextBox txtPrikazKorisniku;
    }
}