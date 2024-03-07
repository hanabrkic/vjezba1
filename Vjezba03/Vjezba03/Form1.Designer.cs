namespace Vjezba03
{
    partial class OnlineKupovina
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbProizvodi = new System.Windows.Forms.GroupBox();
            this.rbGPS = new System.Windows.Forms.RadioButton();
            this.rbMobilni = new System.Windows.Forms.RadioButton();
            this.rbLaptop = new System.Windows.Forms.RadioButton();
            this.rbDesktop = new System.Windows.Forms.RadioButton();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblProcesor = new System.Windows.Forms.Label();
            this.lblMemorija = new System.Windows.Forms.Label();
            this.cbProizvodjac = new System.Windows.Forms.ComboBox();
            this.cbProcesor = new System.Windows.Forms.ComboBox();
            this.cbMemorija = new System.Windows.Forms.ComboBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.cbPlacanje = new System.Windows.Forms.CheckBox();
            this.gbPlacanje = new System.Windows.Forms.GroupBox();
            this.gbOsobniPodaci = new System.Windows.Forms.GroupBox();
            this.mtbZiroRacun = new System.Windows.Forms.MaskedTextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lbKartice = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEuro = new System.Windows.Forms.CheckBox();
            this.cbKuna = new System.Windows.Forms.CheckBox();
            this.mKalendar = new System.Windows.Forms.MonthCalendar();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.gbProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbPlacanje.SuspendLayout();
            this.gbOsobniPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online kupovina - najbolja ponuda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
          
            // 
            // gbProizvodi
            // 
            this.gbProizvodi.Controls.Add(this.rbGPS);
            this.gbProizvodi.Controls.Add(this.rbMobilni);
            this.gbProizvodi.Controls.Add(this.rbLaptop);
            this.gbProizvodi.Controls.Add(this.rbDesktop);
            this.gbProizvodi.Location = new System.Drawing.Point(12, 49);
            this.gbProizvodi.Name = "gbProizvodi";
            this.gbProizvodi.Size = new System.Drawing.Size(125, 126);
            this.gbProizvodi.TabIndex = 1;
            this.gbProizvodi.TabStop = false;
            this.gbProizvodi.Text = "Proizvodi";
            // 
            // rbGPS
            // 
            this.rbGPS.AutoSize = true;
            this.rbGPS.Location = new System.Drawing.Point(6, 88);
            this.rbGPS.Name = "rbGPS";
            this.rbGPS.Size = new System.Drawing.Size(80, 17);
            this.rbGPS.TabIndex = 3;
            this.rbGPS.TabStop = true;
            this.rbGPS.Text = "GPS uređaj";
            this.rbGPS.UseVisualStyleBackColor = true;
            // 
            // rbMobilni
            // 
            this.rbMobilni.AutoSize = true;
            this.rbMobilni.Location = new System.Drawing.Point(6, 65);
            this.rbMobilni.Name = "rbMobilni";
            this.rbMobilni.Size = new System.Drawing.Size(91, 17);
            this.rbMobilni.TabIndex = 2;
            this.rbMobilni.TabStop = true;
            this.rbMobilni.Text = "Mobilni uređaj";
            this.rbMobilni.UseVisualStyleBackColor = true;
            // 
            // rbLaptop
            // 
            this.rbLaptop.AutoSize = true;
            this.rbLaptop.Location = new System.Drawing.Point(6, 42);
            this.rbLaptop.Name = "rbLaptop";
            this.rbLaptop.Size = new System.Drawing.Size(102, 17);
            this.rbLaptop.TabIndex = 1;
            this.rbLaptop.TabStop = true;
            this.rbLaptop.Text = "Laptop računalo";
            this.rbLaptop.UseVisualStyleBackColor = true;
            // 
            // rbDesktop
            // 
            this.rbDesktop.AutoSize = true;
            this.rbDesktop.Location = new System.Drawing.Point(6, 19);
            this.rbDesktop.Name = "rbDesktop";
            this.rbDesktop.Size = new System.Drawing.Size(109, 17);
            this.rbDesktop.TabIndex = 0;
            this.rbDesktop.TabStop = true;
            this.rbDesktop.Text = "Desktop računalo";
            this.rbDesktop.UseVisualStyleBackColor = true;
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(147, 49);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(64, 13);
            this.lblProizvodjac.TabIndex = 7;
            this.lblProizvodjac.Text = "Proizvođač:";
            this.lblProizvodjac.Visible = false;
            // 
            // lblProcesor
            // 
            this.lblProcesor.AutoSize = true;
            this.lblProcesor.Location = new System.Drawing.Point(147, 88);
            this.lblProcesor.Name = "lblProcesor";
            this.lblProcesor.Size = new System.Drawing.Size(52, 13);
            this.lblProcesor.TabIndex = 8;
            this.lblProcesor.Text = "Procesor:";
            this.lblProcesor.Visible = false;
            // 
            // lblMemorija
            // 
            this.lblMemorija.AutoSize = true;
            this.lblMemorija.Location = new System.Drawing.Point(147, 130);
            this.lblMemorija.Name = "lblMemorija";
            this.lblMemorija.Size = new System.Drawing.Size(52, 13);
            this.lblMemorija.TabIndex = 9;
            this.lblMemorija.Text = "Memorija:";
            // 
            // cbProizvodjac
            // 
            this.cbProizvodjac.FormattingEnabled = true;
            this.cbProizvodjac.Location = new System.Drawing.Point(150, 64);
            this.cbProizvodjac.Name = "cbProizvodjac";
            this.cbProizvodjac.Size = new System.Drawing.Size(171, 21);
            this.cbProizvodjac.TabIndex = 10;
            this.cbProizvodjac.Visible = false;
            // 
            // cbProcesor
            // 
            this.cbProcesor.FormattingEnabled = true;
            this.cbProcesor.Location = new System.Drawing.Point(150, 104);
            this.cbProcesor.Name = "cbProcesor";
            this.cbProcesor.Size = new System.Drawing.Size(171, 21);
            this.cbProcesor.TabIndex = 11;
            this.cbProcesor.Visible = false;
            // 
            // cbMemorija
            // 
            this.cbMemorija.FormattingEnabled = true;
            this.cbMemorija.Location = new System.Drawing.Point(150, 146);
            this.cbMemorija.Name = "cbMemorija";
            this.cbMemorija.Size = new System.Drawing.Size(171, 21);
            this.cbMemorija.TabIndex = 12;
            this.cbMemorija.Visible = false;
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(361, 49);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(225, 202);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 13;
            this.pbSlika.TabStop = false;
            // 
            // cbPlacanje
            // 
            this.cbPlacanje.AutoSize = true;
            this.cbPlacanje.Location = new System.Drawing.Point(12, 191);
            this.cbPlacanje.Name = "cbPlacanje";
            this.cbPlacanje.Size = new System.Drawing.Size(67, 17);
            this.cbPlacanje.TabIndex = 14;
            this.cbPlacanje.Text = "Plaćanje";
            this.cbPlacanje.UseVisualStyleBackColor = true;
            // 
            // gbPlacanje
            // 
            this.gbPlacanje.Controls.Add(this.gbOsobniPodaci);
            this.gbPlacanje.Controls.Add(this.lbKartice);
            this.gbPlacanje.Controls.Add(this.label3);
            this.gbPlacanje.Controls.Add(this.cbEuro);
            this.gbPlacanje.Controls.Add(this.cbKuna);
            this.gbPlacanje.Location = new System.Drawing.Point(12, 214);
            this.gbPlacanje.Name = "gbPlacanje";
            this.gbPlacanje.Size = new System.Drawing.Size(322, 187);
            this.gbPlacanje.TabIndex = 15;
            this.gbPlacanje.TabStop = false;
            this.gbPlacanje.Text = "Plaćanje";
            this.gbPlacanje.Visible = false;
            // 
            // gbOsobniPodaci
            // 
            this.gbOsobniPodaci.Controls.Add(this.mtbZiroRacun);
            this.gbOsobniPodaci.Controls.Add(this.txtAdresa);
            this.gbOsobniPodaci.Controls.Add(this.txtImePrezime);
            this.gbOsobniPodaci.Controls.Add(this.label6);
            this.gbOsobniPodaci.Controls.Add(this.lblAdresa);
            this.gbOsobniPodaci.Controls.Add(this.lblImePrezime);
            this.gbOsobniPodaci.Location = new System.Drawing.Point(116, 19);
            this.gbOsobniPodaci.Name = "gbOsobniPodaci";
            this.gbOsobniPodaci.Size = new System.Drawing.Size(192, 156);
            this.gbOsobniPodaci.TabIndex = 4;
            this.gbOsobniPodaci.TabStop = false;
            this.gbOsobniPodaci.Text = "Osobni podaci";
            // 
            // mtbZiroRacun
            // 
            this.mtbZiroRacun.Location = new System.Drawing.Point(9, 130);
            this.mtbZiroRacun.Mask = "000-0000000000000-00";
            this.mtbZiroRacun.Name = "mtbZiroRacun";
            this.mtbZiroRacun.Size = new System.Drawing.Size(179, 20);
            this.mtbZiroRacun.TabIndex = 5;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(6, 80);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(179, 20);
            this.txtAdresa.TabIndex = 4;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(6, 33);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(179, 20);
            this.txtImePrezime.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Žiro-račun";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(6, 64);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(6, 16);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(68, 13);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "Ime i prezime";
            // 
            // lbKartice
            // 
            this.lbKartice.FormattingEnabled = true;
            this.lbKartice.Location = new System.Drawing.Point(6, 68);
            this.lbKartice.Name = "lbKartice";
            this.lbKartice.Size = new System.Drawing.Size(105, 108);
            this.lbKartice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plaćanje karticom";
            // 
            // cbEuro
            // 
            this.cbEuro.AutoSize = true;
            this.cbEuro.Location = new System.Drawing.Point(67, 19);
            this.cbEuro.Name = "cbEuro";
            this.cbEuro.Size = new System.Drawing.Size(48, 17);
            this.cbEuro.TabIndex = 1;
            this.cbEuro.Text = "Euro";
            this.cbEuro.UseVisualStyleBackColor = true;
            // 
            // cbKuna
            // 
            this.cbKuna.AutoSize = true;
            this.cbKuna.Location = new System.Drawing.Point(6, 19);
            this.cbKuna.Name = "cbKuna";
            this.cbKuna.Size = new System.Drawing.Size(51, 17);
            this.cbKuna.TabIndex = 0;
            this.cbKuna.Text = "Kuna";
            this.cbKuna.UseVisualStyleBackColor = true;
            // 
            // mKalendar
            // 
            this.mKalendar.Location = new System.Drawing.Point(361, 263);
            this.mKalendar.Name = "mKalendar";
            this.mKalendar.TabIndex = 6;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(18, 402);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 16;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(128, 402);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 17;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // OnlineKupovina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 429);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.mKalendar);
            this.Controls.Add(this.gbPlacanje);
            this.Controls.Add(this.cbPlacanje);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.cbMemorija);
            this.Controls.Add(this.cbProcesor);
            this.Controls.Add(this.cbProizvodjac);
            this.Controls.Add(this.lblMemorija);
            this.Controls.Add(this.lblProcesor);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.gbProizvodi);
            this.Controls.Add(this.label1);
            this.Name = "OnlineKupovina";
            this.Text = "Online kupovina";
            this.gbProizvodi.ResumeLayout(false);
            this.gbProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbPlacanje.ResumeLayout(false);
            this.gbPlacanje.PerformLayout();
            this.gbOsobniPodaci.ResumeLayout(false);
            this.gbOsobniPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProizvodi;
        private System.Windows.Forms.RadioButton rbGPS;
        private System.Windows.Forms.RadioButton rbMobilni;
        private System.Windows.Forms.RadioButton rbLaptop;
        private System.Windows.Forms.RadioButton rbDesktop;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblProcesor;
        private System.Windows.Forms.Label lblMemorija;
        private System.Windows.Forms.ComboBox cbProizvodjac;
        private System.Windows.Forms.ComboBox cbProcesor;
        private System.Windows.Forms.ComboBox cbMemorija;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.CheckBox cbPlacanje;
        private System.Windows.Forms.GroupBox gbPlacanje;
        private System.Windows.Forms.GroupBox gbOsobniPodaci;
        private System.Windows.Forms.MaskedTextBox mtbZiroRacun;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.ListBox lbKartice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEuro;
        private System.Windows.Forms.CheckBox cbKuna;
        private System.Windows.Forms.MonthCalendar mKalendar;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}

