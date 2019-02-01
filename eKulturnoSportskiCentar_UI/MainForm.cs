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
using eKulturnoSportskiCentar_UI.Centar_UI;
using eKulturnoSportskiCentar_UI.Dogadjaj_UI;
using eKulturnoSportskiCentar_UI.Korisnik_UI;
using eKulturnoSportskiCentar_UI.Sala_UI;
using eKulturnoSportskiCentar_UI.Termin_UI;
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI
{
    public partial class MainForm : Form
    {
        private WebAPIHelper dogadjajServices =
            new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);

        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Icon = this.Icon;
        }

        //private void upravljanjeCentromToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IndexCentar f=new IndexCentar();
        //    f.MdiParent = this;
        //    f.Show();
        //}

        //private void upravljanjeKorisnicimaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IndexKorisnici f = new IndexKorisnici();
        //    f.MdiParent = this;
        //    f.Show();
        //}

        //private void upravljanjeSalomToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IndexSala f = new IndexSala();
        //    f.MdiParent = this;
        //    f.Show();
        //}

        //private void upravljanjeOpremomToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void upravljanjeTerminomToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IndexTermin f = new IndexTermin();
        //    f.MdiParent = this;
        //    f.Show();
        //}

        //private void nepregledaneRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void rezervacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}

        //private void dogadjajToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = dogadjajServices.GetActionResponse("GetBrojNeadministriranihDogadjaja","");
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

            //SubForm F=new SubForm();
            //F.ShowDialog();
        }


        private void MainForm_Activated(object sender, EventArgs e)
        {
            SubForm F = new SubForm();
            F.MdiParent = this;
            F.Show();
        }
        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {

            AdministracijaDogadjaja f = new AdministracijaDogadjaja();
          
           f.MdiParent = this;
           f.Show();
        }

      
    }
}
