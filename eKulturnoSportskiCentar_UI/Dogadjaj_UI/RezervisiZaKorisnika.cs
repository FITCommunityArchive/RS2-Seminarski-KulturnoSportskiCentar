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
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class RezervisiZaKorisnika : Form
    {
        private WebAPIHelper korisniciServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikRoute);
        private Termin termin { get; set; }
        public RezervisiZaKorisnika(Termin T)
        {
            InitializeComponent();
            Korisnici_DGV.AutoGenerateColumns = false;
            termin = T;
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response =
                korisniciServices.GetActionResponse("SearchByName", imePrezimeInput.Text.Trim());
            if (response.IsSuccessStatusCode)
            {
                List<Korisnici_Result> korisnici = response.Content.ReadAsAsync<List<Korisnici_Result>>().Result;
                Korisnici_DGV.DataSource = korisnici;
            }
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rezervisi_BTN_Click(object sender, EventArgs e)
        {
            int korisnikID = Convert.ToInt32(Korisnici_DGV.SelectedRows[0].Cells[0].Value);
            KreirajDogadjaj f=new KreirajDogadjaj(termin, korisnikID);
            f.ShowDialog();
        }

        private void RezervisiZaKorisnika_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        
    }
}
