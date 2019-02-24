using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Centar_UI;
using eKulturnoSportskiCentar_UI.DodatnaOprema_UI;
using eKulturnoSportskiCentar_UI.Dogadjaj_UI;
using eKulturnoSportskiCentar_UI.Korisnik_UI;
using eKulturnoSportskiCentar_UI.Oprema_UI;
using eKulturnoSportskiCentar_UI.Reports;
using eKulturnoSportskiCentar_UI.Sala_UI;
using eKulturnoSportskiCentar_UI.Termin_UI;
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI
{
    public partial class MainForm : Form
    {
        private WebAPIHelper dogadjajServices =
            new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper korisnikUlogaServices = 
            new WebAPIHelper("http://localhost:51348/", Global.KorisnikUlogaRoute);


        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Icon = this.Icon;
            CheckUloge();
        }

       private void CheckUloge()
        {
            HttpResponseMessage responseUloge = korisnikUlogaServices.GetActionResponse("getById",
                Global.logiraniKorisnik.KorisnikID.ToString());
            if (responseUloge.IsSuccessStatusCode)
            {
                List<KorisnikUloga> korisnikUloge =
                    responseUloge.Content.ReadAsAsync<List<KorisnikUloga>>().Result;
                foreach (var X in korisnikUloge)
                {
                    if (X.Uloga.Naziv.ToLower() == "zaposlenik"|| X.Uloga.Naziv.ToLower() == "administrator")
                    {
                       
                        HttpResponseMessage response = dogadjajServices.GetActionResponse("GetBrojNeadministriranihDogadjaja", "");
                        if (response.IsSuccessStatusCode)
                        {
                            int brojNepregledanihRezervacija = response.Content.ReadAsAsync<int>().Result;
                            if (brojNepregledanihRezervacija > 0)
                            {
                                notifyIcon.Visible = true;

                                notifyIcon.ShowBalloonTip(40000, "Nove rezervacija!",
                                    "Broj rezervacija: " + brojNepregledanihRezervacija, ToolTipIcon.Info);
                            }
                        }
                        break;
                    }
                   else if (X.Uloga.Naziv.ToLower() == "korisnik")
                    {
                        seleToolStripMenuItem.Visible = false;
                        centriToolStripMenuItem.Visible = false;
                        kSCToolStripMenuItem.Visible = false;
                        korisniciToolStripMenuItem.Visible = false;
                        administracijaToolStripMenuItem.Visible = false;
                        izvještajiToolStripMenuItem.Visible = false;
                    }

                }
            }
        }

      

      
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e) { 
           AdministracijaDogadjaja f = new AdministracijaDogadjaja();
           f.MdiParent = this;
           f.Show();
           f.Focus();
        }

        

        private void terminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexTermin f = new IndexTermin();
            f.MdiParent = this;
            f.Show();
        }
      

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexKorisnici f = new IndexKorisnici();
            f.MdiParent = this;
            f.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            DodajKorisnika f = new DodajKorisnika();
            f.MdiParent = this;
            f.Show();
        }

        private void centriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexCentar f = new IndexCentar();
            f.MdiParent = this;
            f.Show();
        }

        private void seleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexSala f = new IndexSala();
            f.MdiParent = this;
            f.Show();

        }

        private void opremaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexOprema f = new IndexOprema();
            f.MdiParent = this;
            f.Show();
        }

        private void dodatnaOpremaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IndexDodatnaOprema f = new IndexDodatnaOprema();
            f.MdiParent = this;
            f.Show();
        }

        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            Dogadjaji_Filter_Form f = new Dogadjaji_Filter_Form();
            f.MdiParent = this;
            f.Show();
           
        }

        private void administracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            AdministracijaDogadjaja f = new AdministracijaDogadjaja();
            f.MdiParent = this;
            f.Show();
        }

        private void javniDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            JavniDogadjaji f = new JavniDogadjaji();
            f.MdiParent = this;
            f.Show();
        }

        private void vlastitiDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            VlastitiDogadjaji f = new VlastitiDogadjaji();
            f.MdiParent = this;
            f.Show();
        }

        private void događajiZaPosjetitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            Dogadjaji_za_posjetiti f = new Dogadjaji_za_posjetiti();
            f.MdiParent = this;
            f.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.logiraniKorisnik = null;
            Application.Restart();
        }

        private void izmjeniProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var x in this.MdiChildren)
            {
                x.Close();
            }
            IzmjeniProfil f = new IzmjeniProfil(Global.logiraniKorisnik.KorisnikID);
            f.MdiParent = this;
            f.Show();
            
            
        }
    }
}
