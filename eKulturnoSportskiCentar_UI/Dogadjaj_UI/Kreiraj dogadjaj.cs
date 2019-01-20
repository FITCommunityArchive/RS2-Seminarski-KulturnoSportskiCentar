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

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class KreirajDogadjaj : Form
    {
        private WebAPIHelper salaServices = new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        private WebAPIHelper dogadjajServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);

        private WebAPIHelper dodatnaOpremaServices =
            new WebAPIHelper("http://localhost:51348/", Global.DodatnaOpremaRoute);

        private WebAPIHelper dogadjajDodatnaOpremaServices =
            new WebAPIHelper("http://localhost:51348/", Global.DogadjajDodatnaOpremaRoute);

        private WebAPIHelper vrsteDogadjajaServices =
            new WebAPIHelper("http://localhost:51348/", Global.VrstaDogadjajaRoute);

        private WebAPIHelper terminServices = new WebAPIHelper("http://localhost:51348/", Global.TerminRoute);

        private Dogadjaj Dogadjaj { get; set; }


        public KreirajDogadjaj(Dogadjaj D)
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            Dogadjaj = new Dogadjaj();
            Dogadjaj.TerminID = D.TerminID;
            DodatnaOprema_DGV.AutoGenerateColumns = false;
            Termin T = terminServices.GetResponse(D.TerminID.ToString()).Content.ReadAsAsync<Termin>().Result;
            DatumInput.Text = T.Datum.ToString("dd.MM.yyyy.") + " - Početak: " + T.Pocetak.ToString() + " - Kraj: " +
                              T.Kraj.ToString();
            SalaInput.Text = T.Sala.Naziv;

        }

        private void KreirajDogadjaj_Load(object sender, EventArgs e)
        {
            BindVrsteDogadjaj();
            javniDogadjaj_box.Visible = false;
            BindGridDodatnaOprema();
        }

        private void BindGridDodatnaOprema()
        {
            HttpResponseMessage response = dodatnaOpremaServices.GetResponse();
            List<DodatnaOprema> dodatnaOprema = response.Content.ReadAsAsync<List<DodatnaOprema>>().Result;
            DodatnaOprema_DGV.DataSource = dodatnaOprema;
        }

        private void BindVrsteDogadjaj()
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

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Da_RDB_CheckedChanged(object sender, EventArgs e)
        {
            javniDogadjaj_box.Visible = true;
            Dogadjaj.JavniDogadjaj = true;
        }

        private void NE_RDB_CheckedChanged(object sender, EventArgs e)
        {
            javniDogadjaj_box.Visible = false;
        }

        private void Rezevisi_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Dogadjaj.VrstaDogadjajaID = Convert.ToInt32(Vrsta_CMB.SelectedValue);
                Dogadjaj.Naziv = Naziv_Input.Text;
                Dogadjaj.KorisnikID = Global.logiraniKorisnik.KorisnikID;
                if (Da_RDB.Checked == true)
                {
                    Dogadjaj.JavniDogadjaj = true;
                    Dogadjaj.BrojMijesta = Convert.ToInt32(BrojMijesta_Input.Text);
                    Dogadjaj.CijenaUlaza = Convert.ToDecimal(Cijena_Input.Text);
                }
                else
                {
                    Dogadjaj.JavniDogadjaj = false;
                }
                Dogadjaj.DodatnaOprema = OdabirDodatneOpreme();
                HttpResponseMessage response = dogadjajServices.PostResponse(Dogadjaj);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Uspješno ste kreirali dogadjaj!", "Uspjeh", MessageBoxButtons.OK);
                    //this.Close();
                    DialogResult = DialogResult.OK;
                    Dogadjaj = response.Content.ReadAsAsync<Dogadjaj>().Result;
                    this.Close();
                    VlastitiDogadjaji f=new VlastitiDogadjaji();
                    f.ShowDialog();
                }
            }
        }

        private List<DodatnaOprema> OdabirDodatneOpreme()
        {
            List<DodatnaOprema> povrat = new List<DodatnaOprema>();
            int DodatnaOpremaID = 0;
            for (var i = 0; i < DodatnaOprema_DGV.RowCount; i++)
                if (Convert.ToBoolean(DodatnaOprema_DGV.Rows[i].Cells[4].Value))
                {
                    DodatnaOpremaID = Convert.ToInt32(DodatnaOprema_DGV.Rows[i].Cells[0].Value);
                    HttpResponseMessage response = dodatnaOpremaServices.GetResponse(DodatnaOpremaID.ToString());
                    if (response.IsSuccessStatusCode) povrat.Add(response.Content.ReadAsAsync<DodatnaOprema>().Result);
                }

            return povrat;
        }

        private void Naziv_Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Naziv_Input.Text))
            {
                e.Cancel = true;
               errorProvider.SetError(Naziv_Input,Messages.Name_Required);
            }
        }

        private void Vrsta_CMB_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(Vrsta_CMB.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(Vrsta_CMB,Messages.DropDown_NotSelected);
            }
        }
    }
}
