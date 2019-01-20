using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_UI.Centar_UI;
using eKulturnoSportskiCentar_UI.DodatnaOprema_UI;
using eKulturnoSportskiCentar_UI.Dogadjaj_UI;
using eKulturnoSportskiCentar_UI.Korisnik_UI;
using eKulturnoSportskiCentar_UI.Oprema_UI;
using eKulturnoSportskiCentar_UI.Sala_UI;
using eKulturnoSportskiCentar_UI.Termin_UI;

namespace eKulturnoSportskiCentar_UI
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }

        private void Termini_BTN_Click(object sender, EventArgs e)
        {
            IndexTermin f = new IndexTermin();
            Visible = false;
            f.ShowDialog();
        }

        private void Centar_BTN_Click(object sender, EventArgs e)
        {
           IndexCentar f=new IndexCentar();
           Visible = false;
            f.ShowDialog();
        }

        private void Sala_BTN_Click(object sender, EventArgs e)
        {
            IndexSala f = new IndexSala();
            Visible = false;
            f.ShowDialog();
        }

        private void Korisnici_BTN_Click(object sender, EventArgs e)
        {
            IndexKorisnici f = new IndexKorisnici();
            Visible = false;
            f.ShowDialog();
        }

        private void Oprema_BTN_Click(object sender, EventArgs e)
        {
            IndexOprema f = new IndexOprema();
            Visible = false;
            f.ShowDialog();
        }

        private void DodatnaOprema_BTN_Click(object sender, EventArgs e)
        {
            IndexDodatnaOprema f = new IndexDodatnaOprema();
            Visible = false;
            f.ShowDialog();
        }

        private void Dogadjaji_BTN_Click(object sender, EventArgs e)
        {
            IndexDogadjaj f = new IndexDogadjaj();
            Visible = false;
            f.ShowDialog();
            
        }


        private void Izlaz_BTN_Click(object sender, EventArgs e)
        {
            Global.logiraniKorisnik = null;
            Close();
            Application.Exit();
        }
    }
}
