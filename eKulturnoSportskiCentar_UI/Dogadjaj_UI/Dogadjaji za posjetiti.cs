using eKulturnoSportskiCentar_UI.Util;
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

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class Dogadjaji_za_posjetiti : Form
    {
        private WebAPIHelper dogadjajaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper korisnikDogadjajServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikDogadjajRoute);

        public Dogadjaji_za_posjetiti()
        {
            InitializeComponent();
            Dogadjaji_DGV.AutoGenerateColumns = false;
        }

        private void Dogadjaji_za_posjetiti_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            HttpResponseMessage response = dogadjajaServices.GetActionResponse("GetDogadjajiZaPrisustvovati", Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<DogadjajiZaPrisustvovati_Result> lista = response.Content.ReadAsAsync<List<DogadjajiZaPrisustvovati_Result>>().Result;
                Dogadjaji_DGV.DataSource = lista;
            }

        }

        private void Otkazi_BTN_Click(object sender, EventArgs e)
        {
            int DogadjajID = Convert.ToInt32(Dogadjaji_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = korisnikDogadjajServices.DeleteResponse(DogadjajID.ToString(), Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Prisustvo uspješno otkazano!");
                BindGrid();
            }
        }

        private void Ocijeni_BTN_Click(object sender, EventArgs e)
        {
           
            int DogadjajID = Convert.ToInt32(Dogadjaji_DGV.SelectedRows[0].Cells[0].Value);
            Dogadjaj D = dogadjajaServices.GetResponse(DogadjajID.ToString()).Content.ReadAsAsync<Dogadjaj>().Result;
            int result = DateTime.Compare(DateTime.Today, D.Termin.Datum);
            if (result > 0)
            {
                OcjeniDogadjaj f = new OcjeniDogadjaj(DogadjajID);
                f.Show();

            }
            else
            {
                MessageBox.Show("Nije moguće ocjenuti događaj koji se nije desio!");
            }

        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
