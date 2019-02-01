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
using eKulturnoSportskiCentar_UI.Reports;

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class AdministracijaDogadjaja : Form
    {
        private WebAPIHelper vrsteDogadjajaServices =
            new WebAPIHelper("http://localhost:51348/", Global.VrstaDogadjajaRoute);

        private WebAPIHelper salaServices =
            new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);

        private WebAPIHelper dogadjajServices =
            new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private int brojac=0;

        private WebAPIHelper dogadjajDodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajDodatnaOpremaRoute);

        public AdministracijaDogadjaja()
        {
            InitializeComponent();
            Dogadjaj_DGV.AutoGenerateColumns = false;
        }

        private void AdministracijaDogadjaja_Load(object sender, EventArgs e)
        {
            BindSale();
            BindVrsteDogadjaja();
            BindGrid(true);
        }

        private void BindSale()
        {
            HttpResponseMessage response = salaServices.GetResponse();
            List<Sala_Result> sale = new List<Sala_Result>();
            sale.Add(new Sala_Result {Sala = "Odaberi Salu", SalaID = 0});
            sale.AddRange(response.Content.ReadAsAsync<List<Sala_Result>>().Result);
            Sala_CMB.DataSource = sale;
            Sala_CMB.DisplayMember = "Sala";
            Sala_CMB.ValueMember = "SalaID";
        }

        private void BindVrsteDogadjaja()
        {
            HttpResponseMessage response = vrsteDogadjajaServices.GetResponse();
            List<VrstaDogadjaja> vrstaDogadjaja = new List<VrstaDogadjaja>();
            vrstaDogadjaja.Add(new VrstaDogadjaja {Naziv = "<<ODABERI VRSTU>>", VrstaDogadjajaID = 0});
            List<VrstaDogadjaja> dogadjaji = response.Content.ReadAsAsync<List<VrstaDogadjaja>>().Result;
            vrstaDogadjaja.AddRange(dogadjaji);
            Vrsta_CMB.DataSource = vrstaDogadjaja;
            Vrsta_CMB.ValueMember = "VrstaDogadjajaID";
            Vrsta_CMB.DisplayMember = "Naziv";
        }

    
        private void BindGrid(bool prikaziSve=false)
        {
           
            HttpResponseMessage response = dogadjajServices.GetActionResponse("GetDogadjajiZaAdministraciju","");
            List<DogadjajiZaAdministraciju_Result> lista = response.Content.ReadAsAsync<List<DogadjajiZaAdministraciju_Result>>().Result;
            int salaId = Convert.ToInt32(Sala_CMB.SelectedValue);
            int vrstaId = Convert.ToInt32(Vrsta_CMB.SelectedValue);
            DateTime datum = Datum_PCK.Value.Date;
            if (prikaziSve)
            {
                Dogadjaj_DGV.DataSource = lista;
            }
            else if (salaId == 0 && vrstaId != 0)
            {
                Dogadjaj_DGV.DataSource =
                    lista.Where(x => x.Datum == datum && x.VrstaDogadjajaID == vrstaId).ToList();
            }
            else if (vrstaId == 0 && salaId != 0)
            {
                Dogadjaj_DGV.DataSource =
                    lista.Where(x => x.Datum == datum && x.SalaID == salaId).ToList();
            }
            else if (salaId == 0 && vrstaId == 0)
            {
                Dogadjaj_DGV.DataSource =
                    lista.Where(x => x.Datum == datum).ToList();
            }

            else
            {
                Dogadjaj_DGV.DataSource =
                    lista.Where(x => x.Datum == datum && x.SalaID == salaId && x.VrstaDogadjajaID == vrstaId).ToList();
            }

            brojac++;
        
        }

        private void Datum_PCK_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Sala_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brojac != 0)
            {
                BindGrid();
            }
        }

        private void Vrsta_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brojac != 0)
            {
                BindGrid();
            }
        }

        private void PrikaziSve_BTN_Click(object sender, EventArgs e)
        {
            BindGrid(true);
        }

        private void Detalji_BTN_Click(object sender, EventArgs e)
        {
            if (Dogadjaj_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.dogadjaj_action);
            }
            else { 
            int dogadjajID = Convert.ToInt32(Dogadjaj_DGV.SelectedRows[0].Cells[0].Value);
            DetaljiDogadjaja f = new DetaljiDogadjaja(dogadjajID);
            if(f.ShowDialog()==DialogResult.Yes)
                BindGrid(true);
            }

        }

        public void CreateReport(int dogadjajID)
        {
            List<DodatnaOprema> dogadjajDodatnaOprema =
                new List<DodatnaOprema>();
            HttpResponseMessage response =
                dogadjajDodatnaOpremaServices.GetActionResponse("GetDogadatnaOpremaByDogadjaj", dogadjajID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dogadjajDodatnaOprema = response.Content.ReadAsAsync<List<DodatnaOprema>>().Result;
               
            }

            Detalji_Dogadjaja_Result dogadjaj = new Detalji_Dogadjaja_Result();
            HttpResponseMessage responseDogadjaj =
                dogadjajServices.GetActionResponse("GetDetaljiDogadjaja", dogadjajID.ToString());
            //dogadjaj = responseDogadjaj.Content.ReadAsAsync<Detalji_Dogadjaja_Result>().Result;
            if (responseDogadjaj.IsSuccessStatusCode)
            {
                dogadjaj = responseDogadjaj.Content.ReadAsAsync<Detalji_Dogadjaja_Result>().Result;
                if (dogadjajDodatnaOprema.Count == 0)
                {
                    dogadjaj.CijenaDodatneOpreme = 0;
                 }
                else
                {
                    dogadjaj.CijenaDodatneOpreme = 0;
                    foreach (var x in dogadjajDodatnaOprema)
                    {
                        dogadjaj.CijenaDodatneOpreme +=(Convert.ToDouble(x.Cijena));

                    }
                }

            RacunForm f=new RacunForm();
                f.DodatnaOprema = dogadjajDodatnaOprema;
                f.sala = dogadjaj.Sala;
                f.vrstaDogadjaja = dogadjaj.Vrsta;
                f.korisnik = dogadjaj.Korisnik;
                f.satnica = dogadjaj.Termin;
                f.dogadjaj = dogadjaj.Dogadjaj;
                f.cijenaDodatneOpreme = dogadjaj.CijenaDodatneOpreme;
                f.Show();
            }
        }

        private void Odobri_Btn_Click(object sender, EventArgs e)
        {
            if (Dogadjaj_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.dogadjaj_action);
            }
            else { 
                int dogadjajID = Convert.ToInt32(Dogadjaj_DGV.SelectedRows[0].Cells[0].Value);
                CreateReport(dogadjajID);

             HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
             Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
             D.Odobrena = true;
             D.Aktivna = true;
             HttpResponseMessage putResponse = dogadjajServices.PutResponse(dogadjajID, D);
             if (putResponse.IsSuccessStatusCode)
             {
                 MessageBox.Show("Dogadjaj odobren");
                 BindGrid(true);
             }
            }
        }

        private void Odbij_BTN_Click(object sender, EventArgs e)
        {
            if (Dogadjaj_DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show(Messages.dogadjaj_action);
            }
            else
            {
                int dogadjajID = Convert.ToInt32(Dogadjaj_DGV.SelectedRows[0].Cells[0].Value);
                HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
                Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
                D.Odobrena = false;
                HttpResponseMessage putResponse = dogadjajServices.PutResponse(dogadjajID, D);
                if (putResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Dogadjaj odbijen");
                    BindGrid(true);
                }
            }
        }
    }
}
