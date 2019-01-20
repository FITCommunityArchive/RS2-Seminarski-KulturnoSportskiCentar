using eKulturnoSportskiCentar_API.Models;
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
using eKulturnoSportskiCentar_UI.Dogadjaj_UI;

namespace eKulturnoSportskiCentar_UI.Termin_UI
{
    public partial class IndexTermin : Form
    {
      
        private WebAPIHelper salaServices = new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        private WebAPIHelper terminServices = new WebAPIHelper("http://localhost:51348/", Global.TerminRoute);
        private WebAPIHelper dogadjajServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private Dogadjaj Dogadjaj { get; set; }
        private int brojac = 0;
        public IndexTermin()
        {
            InitializeComponent();
            BindSale();
            Termin_DGV.AutoGenerateColumns = false;
            Datum_PCK.MinDate = DateTime.Today;
           
        }
        void BindSale()
        {
            HttpResponseMessage response = salaServices.GetResponse();
            List<Sala_Result> sale = new List<Sala_Result>();
          //  sale.Add(new Sala_Result { Sala = "Odaberi Salu", SalaID = 0 });
            sale.AddRange(response.Content.ReadAsAsync<List<Sala_Result>>().Result);
            Sala_CMB.DataSource = sale;
            Sala_CMB.DisplayMember = "Sala";
            Sala_CMB.ValueMember = "SalaID";
        }

        private void Rezervisi_BTN_Click(object sender, EventArgs e)
        {
           


            if (Termin_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati termin da bi ste izvršili rezervaciju!");
            }
            else
            {
                Termin T = new Termin();
                T.Pocetak = TimeSpan.Parse((Termin_DGV.SelectedRows[0].Cells[2].Value).ToString());
                T.Kraj = TimeSpan.Parse((Termin_DGV.SelectedRows[0].Cells[3].Value).ToString());
                T.Datum = Datum_PCK.Value;
                T.SalaID = Convert.ToInt32(Sala_CMB.SelectedValue);
                HttpResponseMessage response = terminServices.PostResponse(T);
                if (response.IsSuccessStatusCode)
                    T = response.Content.ReadAsAsync<Termin>().Result;

                Dogadjaj = new Dogadjaj();
                Dogadjaj.KorisnikID = Global.logiraniKorisnik.KorisnikID;
                Dogadjaj.TerminID = T.TerminID;
                KreirajDogadjaj f=new KreirajDogadjaj(Dogadjaj);
                f.ShowDialog();

            }
            

        }

        private void RezervisiZaKorisnika_BTN_Click(object sender, EventArgs e)
        {

        }

        void BindGrid()
        {
            Termin_DGV.DataSource = null;
            int salaId = Convert.ToInt32(Sala_CMB.SelectedValue);
            string datum = Datum_PCK.Value.ToString("MMddyyyy");
            HttpResponseMessage response = terminServices.GetActionResponse(datum, salaId.ToString());
          //HttpResponseMessage response = terminServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Termin> termin = response.Content.ReadAsAsync<List<Termin>>().Result;
                //List<Termin> termin = response.Content.ReadAsAsync<List<Termin>>().Result;
                Termin_DGV.DataSource = termin;
                brojac++;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void IndexTermin_Load(object sender, EventArgs e)
        {
           
            //if (!Global.terminGenerated)
            //{
            //    GenerateTermin();
            //    Global.terminGenerated = true;
            //}
            BindGrid();
        }

   

       private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
        //    int terminID = Convert.ToInt32(Termin_DGV.SelectedRows[0].Cells[0].Value);

        //    HttpResponseMessage response = terminServices.DeleteResponse(terminID);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        MessageBox.Show("Izbrisano");
        //        BindGrid();
        //    }

        }

        private void Sala_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brojac != 0)
                BindGrid();
        }

        private void Datum_PCK_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Termin T = new Termin();
            T.Pocetak = TimeSpan.Parse((Termin_DGV.SelectedRows[0].Cells[2].Value).ToString());
            T.Kraj = TimeSpan.Parse((Termin_DGV.SelectedRows[0].Cells[3].Value).ToString());
            T.Datum = Datum_PCK.Value;
            T.SalaID = Convert.ToInt32(Sala_CMB.SelectedValue);
            HttpResponseMessage response = terminServices.PostResponse(T);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("UPJESH");
            }

        }

      
    }
}
