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
    public partial class OcjeniDogadjaj : Form
    {
        private WebAPIHelper ocjenaServices = new WebAPIHelper("http://localhost:51348/", Global.OcjenaRoute);
        private WebAPIHelper dogadjajServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper dogadjajOcjenaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajOcjenaRoute);
        private DogadjajOcjena dogadjajOcjena { get; set; }
        private int IsOcjenjen { get; set; }

        public OcjeniDogadjaj(int dogadjajID)
        {
            InitializeComponent();
            HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
            Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
            Dogadjaj_Input.Text = D.Naziv;
            dogadjajOcjena = new DogadjajOcjena();
            dogadjajOcjena.DogadjajID = dogadjajID;
            dogadjajOcjena.KorisnikID = Global.logiraniKorisnik.KorisnikID;

            HttpResponseMessage responseIsOcjenjen = dogadjajOcjenaServices.PostActionResponse("IsOcjenjen", dogadjajOcjena);
            IsOcjenjen = responseIsOcjenjen.Content.ReadAsAsync<int>().Result;
            this.AutoValidate = AutoValidate.Disable;
        }

       

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ocijeni_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                dogadjajOcjena.OcjenaID = Convert.ToInt32(Ocjene_CMB.SelectedValue);
                if (IsOcjenjen != 0)
                {
                    dogadjajOcjena.DogadjajOcjenaID = IsOcjenjen;

                }

                HttpResponseMessage response = dogadjajOcjenaServices.PutResponse(IsOcjenjen, dogadjajOcjena);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ocjena uspješno spremljena");
                    this.Close();
                }
            }
        }

        private void OcjeniDogadjaj_Load(object sender, EventArgs e)
        {
            BindOcjeneCMB();
            Korisnik_Input.Text = Global.logiraniKorisnik.KorisnickoIme;
        }

        private void BindOcjeneCMB()
        {
            HttpResponseMessage response = ocjenaServices.GetResponse();
            List<Ocjena> ocjene = new List<Ocjena>();

            ocjene.Add(new Ocjena { Naziv = "Odaberi ocjeni", OcjenaID = 0 });
            ocjene.AddRange(response.Content.ReadAsAsync<List<Ocjena>>().Result);

            Ocjene_CMB.DataSource = ocjene;
            Ocjene_CMB.DisplayMember = "Naziv";
            Ocjene_CMB.ValueMember = "OcjenaID";
            if (IsOcjenjen != 0)
            {
                HttpResponseMessage responseDogadjajOcjena =
                    dogadjajOcjenaServices.GetResponse(IsOcjenjen.ToString());
                if (responseDogadjajOcjena.IsSuccessStatusCode)
                {
                    DogadjajOcjena DO = responseDogadjajOcjena.Content.ReadAsAsync<DogadjajOcjena>().Result;
                    Ocjene_CMB.SelectedIndex = Convert.ToInt32(DO.OcjenaID);
                }
            }
        }


        #region Validacija
        private void Ocjene_CMB_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(Ocjene_CMB.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(Ocjene_CMB, Messages.DropDown_NotSelected);
            }
        } 
        #endregion
    }
}
