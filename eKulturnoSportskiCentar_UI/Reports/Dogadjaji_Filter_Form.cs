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

namespace eKulturnoSportskiCentar_UI.Reports
{
    public partial class Dogadjaji_Filter_Form : Form
    {
        private WebAPIHelper vrsteDogadjajaServices =
            new WebAPIHelper("http://localhost:51348/", Global.VrstaDogadjajaRoute);

        private WebAPIHelper salaServices =
            new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);

        private WebAPIHelper dogadjajServices =
            new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        public Dogadjaji_Filter_Form()
        {
            InitializeComponent();
            PocetniDatum.MinDate=new DateTime(2018,1,1);
        }

        private void KreirajIzvjestaj_BTN_Click(object sender, EventArgs e)
        {

            string pocetak = PocetniDatum.Value.ToString("MMddyyyy");
            string kraj = Krajnji_Datum.Value.ToString("MMddyyyy");
            List<Dogadjaj_Detalji_Result> lista = new List<Dogadjaj_Detalji_Result>();
            HttpResponseMessage response =
                dogadjajServices.GetResponse(pocetak, kraj);
            if (response.IsSuccessStatusCode)
            {
                lista = response.Content.ReadAsAsync<List<Dogadjaj_Detalji_Result>>().Result;
                List<Dogadjaj_Detalji_Result> povrat = new List<Dogadjaj_Detalji_Result>();

            int salaId = Convert.ToInt32(Sala_CMB.SelectedValue);
            int vrstaDogadjajId = Convert.ToInt32(Vrsta_CMB.SelectedValue);

            if (salaId != 0 && vrstaDogadjajId != 0)
            {
                povrat =lista.Where(x => x.SalaId == salaId && x.VrstaDogadjajaID == vrstaDogadjajId).ToList();
            }
            else if (salaId == 0 && vrstaDogadjajId != 0)
            {
                povrat =lista.Where(x => x.VrstaDogadjajaID == vrstaDogadjajId).ToList();
            }
            else if(salaId != 0 && vrstaDogadjajId == 0)
            {
               povrat =lista.Where(x => x.SalaId == salaId).ToList();
            }
            else
            {
                povrat = lista;
            }


                Reports.ReportForm f = new ReportForm();
                f.pocetniDatum = PocetniDatum.Value.Date;
                f.krajnjiDatum = Krajnji_Datum.Value.Date;
                f.sala = (Sala_CMB.SelectedItem as Sala_Result).Sala;
                f.vrstaDogadjaja = (Vrsta_CMB.SelectedItem as VrstaDogadjaja).Naziv;

                f.Dogadjaji = povrat;
                f.Show();


            }
        }
        

        private void Dogadjaji_Filter_Form_Load(object sender, EventArgs e)
        {
            BindSale();
            BindVrsteDogadjaja();
        }
        private void BindSale()
        {
            HttpResponseMessage response = salaServices.GetResponse();
            List<Sala_Result> sale = new List<Sala_Result>();
            sale.Add(new Sala_Result { Sala = "SVE SALE", SalaID = 0 });
            sale.AddRange(response.Content.ReadAsAsync<List<Sala_Result>>().Result);
            Sala_CMB.DataSource = sale;
            Sala_CMB.DisplayMember = "Sala";
            Sala_CMB.ValueMember = "SalaID";
        }

        private void BindVrsteDogadjaja()
        {
            HttpResponseMessage response = vrsteDogadjajaServices.GetResponse();
            List<VrstaDogadjaja> vrstaDogadjaja = new List<VrstaDogadjaja>();
            vrstaDogadjaja.Add(new VrstaDogadjaja { Naziv = "SVE VRSTE", VrstaDogadjajaID = 0 });
            List<VrstaDogadjaja> dogadjaji = response.Content.ReadAsAsync<List<VrstaDogadjaja>>().Result;
            vrstaDogadjaja.AddRange(dogadjaji);
            Vrsta_CMB.DataSource = vrstaDogadjaja;
            Vrsta_CMB.ValueMember = "VrstaDogadjajaID";
            Vrsta_CMB.DisplayMember = "Naziv";
        }
    }
}
