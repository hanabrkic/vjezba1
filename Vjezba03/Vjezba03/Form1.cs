using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba03
{
    public partial class OnlineKupovina : Form
    {
        string[] proizvodjac = new string[] { "Toshiba", "Samsung", "Sony", "Asus", "Acer" };
        string[] procesor = new string[] { "Intel", "ADM" };
        string[] memorija = new string[] { "1GB", "2GB", "3GB", "4GB", "8GB", "16GB" };
        string[] kartice = new string[] { "Visa", "Masters", "Maestro", "Diners", "American", "PayPal" };
        public OnlineKupovina()
        {
            InitializeComponent();
            cbMemorija.DataSource = memorija;
            cbProcesor.DataSource = procesor;
            lbKartice.DataSource = kartice;
            cbProizvodjac.DataSource = proizvodjac;
        }
        private void prikaziKontrole()
        {
            lblMemorija.Visible = true;
            cbMemorija.Visible = true;
            lblProizvodjac.Visible = true;
            cbProizvodjac.Visible = true;
            lblProcesor.Visible = true;
            cbProcesor.Visible = true;
        }
        private void sakrijKontrole()
        {
            lblMemorija.Visible = false;
            cbMemorija.Visible = false;
            lblProizvodjac.Visible = false;
            cbProizvodjac.Visible = false;
            lblProcesor.Visible = false;
            cbProcesor.Visible = false;
        }
        private void rbDesktop_CheckedChanged(object sender, EventArgs e)
        {
            pbSlika.Load("d:/desktop.jpg");
            prikaziKontrole();
        }
        private void rbLaptop_CheckedChanged(object sender, EventArgs e)
        {
            pbSlika.Load("d:/laptop.jpg");
            prikaziKontrole();
        }
        private void rbMobilni_CheckedChanged(object sender, EventArgs e)
        {
            pbSlika.Load("d:/mobilni.jpg");
            prikaziKontrole();
        }
        private void rbGps_CheckedChanged(object sender, EventArgs e)
        {
            pbSlika.Load("d:/gps.jpg");
            prikaziKontrole();
        }
        private void cbPlacanje_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlacanje.Checked)
                gbPlacanje.Visible = true;
            else
                gbPlacanje.Visible = false;
        }
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if(cbPlacanje.Checked == true)
            {
                if(txtImePrezime.Text != "")
                {
                    if(mtbZiroRacun.Text.Length == 20)
                    {
                        string poruka = "Proizvod: ";
                        if (rbDesktop.Checked)
                            poruka += rbDesktop.Text;
                        if (rbLaptop.Checked)
                            poruka += rbLaptop.Text;
                        if (rbMobilni.Checked)
                            poruka += rbMobilni.Text;
                        if (rbGps.Checked)
                            poruka += rbGps.Text;
                        poruka += "\nProidvođač: " + cbProizvodjac.SelectedItem + "\nValuta plaćanja: ";
                    }
                }    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
