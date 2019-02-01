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
using eKulturnoSportskiCentar_API.Controllers;
using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Reports;
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class IndexDogadjaj : Form
    {
        private WebAPIHelper korisnikUlogaServices=new WebAPIHelper("http://localhost:51348/", Global.KorisnikUlogaRoute);
        public IndexDogadjaj()
        {
            InitializeComponent();
        }

        private void Administracija_BTN_Click(object sender, EventArgs e)
        {
            
            HttpResponseMessage response = korisnikUlogaServices.GetActionResponse("getById",
                Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                bool privilegija = false;
                List<KorisnikUloga> korisnikUloge =
                    response.Content.ReadAsAsync<List<KorisnikUloga>>().Result;
                foreach (var X in korisnikUloge)
                {
                    if (X.Uloga.Naziv == "Administrator" || X.Uloga.Naziv == "Zaposlenik")
                    {
                        privilegija = true;
                    }
                    
                }

                if (privilegija)
                {
                    Close();
                    AdministracijaDogadjaja f = new AdministracijaDogadjaja();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nemate privilegiju da pristupite odabranoj radnji", "Upozorenje",MessageBoxButtons.OK);
                }

                
            }
            
        }

        private void Javni_BTN_Click(object sender, EventArgs e)
        {
            Close();
            JavniDogadjaji f = new JavniDogadjaji();
            f.ShowDialog();
        }

        private void Vlastiti_BTN_Click(object sender, EventArgs e)
        {
            Close();
            VlastitiDogadjaji f=new VlastitiDogadjaji();
            f.ShowDialog();
        }

        private void GoingEvents_Click(object sender, EventArgs e)
        {
            Dogadjaji_za_posjetiti f=new Dogadjaji_za_posjetiti();
            Close();
            f.ShowDialog();
        }

        private void Reports_BTN_Click(object sender, EventArgs e)
        {
            Dogadjaji_Filter_Form f = new Dogadjaji_Filter_Form();
            f.ShowDialog();
        }
    }
}
