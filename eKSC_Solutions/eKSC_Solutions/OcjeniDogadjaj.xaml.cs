using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eKulturnoSportskiCentar_PCL;
using eKulturnoSportskiCentar_PCL.Model;
using eKulturnoSportskiCentar_PCL.Util;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKSC_Solutions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcjeniDogadjaj : ContentPage
	{
        private WebAPIHelper ocjenaServices = new WebAPIHelper(Global.apiRoute, Global.OcjenaRoute);
        private WebAPIHelper dogadjajServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajRoute);
        private WebAPIHelper dogadjajOcjenaServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajOcjenaRoute);
        private DogadjajOcjena dogadjajOcjena { get; set; }
        private int IsOcjenjen { get; set; }
        private int DogadjajID { get; set; }
        public OcjeniDogadjaj (int dogadjajId)
		{
			InitializeComponent ();
            DogadjajID = dogadjajId;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            HttpResponseMessage response = dogadjajServices.GetResponse(DogadjajID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                Dogadjaj D = JsonConvert.DeserializeObject<Dogadjaj>(jsonObject.Result);
                NazivInput.Text ="Događaj: "+  D.Naziv;
                KorisnikInput.Text = "Korisnik: "+Global.logiraniKorisnik.KorisnickoIme;
                dogadjajOcjena = new DogadjajOcjena();
                dogadjajOcjena.DogadjajID = DogadjajID;
                dogadjajOcjena.KorisnikID = Global.logiraniKorisnik.KorisnikID;

                HttpResponseMessage responseIsOcjenjen = dogadjajOcjenaServices.PostActionResponse("IsOcjenjen", dogadjajOcjena);
                jsonObject = responseIsOcjenjen.Content.ReadAsStringAsync();
                IsOcjenjen = JsonConvert.DeserializeObject<int>(jsonObject.Result);

            }
            BindOcjeneCMB();

        }

        private void BindOcjeneCMB()
        {
            HttpResponseMessage response = ocjenaServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Ocjena> ocjene = new List<Ocjena>();
                var jsonObject = response.Content.ReadAsStringAsync();
                ocjene.AddRange(JsonConvert.DeserializeObject<List<Ocjena>>(jsonObject.Result));
                OcjenePicker.ItemsSource = ocjene;
                OcjenePicker.ItemDisplayBinding = new Binding("Naziv");
                if (IsOcjenjen != 0)
                {
                    HttpResponseMessage responseDogadjajOcjena =
                        dogadjajOcjenaServices.GetResponse(IsOcjenjen.ToString());
                    if (responseDogadjajOcjena.IsSuccessStatusCode)
                    {
                        jsonObject = responseDogadjajOcjena.Content.ReadAsStringAsync();
                        DogadjajOcjena DO = JsonConvert.DeserializeObject<DogadjajOcjena>(jsonObject.Result);
                        OcjenePicker.SelectedIndex = Convert.ToInt32(DO.OcjenaID) - 1;
                    }
                }
            }
           
        }

        private void Odustani_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DogadjajiZaPrisustvovati());
        }

        private bool Validacija()
        {
            if (OcjenePicker.SelectedItem == null)
                return false;
            else if ((OcjenePicker.SelectedItem as Ocjena).OcjenaID == 0)
            {
                return false;
            }
            else
            return true;
        }
        private void Ocjeni_OnClicked(object sender, EventArgs e)
        {
            if (Validacija())
            {
                dogadjajOcjena.OcjenaID = (OcjenePicker.SelectedItem as Ocjena).OcjenaID;
                if (IsOcjenjen != 0)
                {
                    dogadjajOcjena.DogadjajOcjenaID = IsOcjenjen;

                }

                HttpResponseMessage response = dogadjajOcjenaServices.PutResponse(IsOcjenjen, dogadjajOcjena);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Uspjeh", "Upsješno ste ocijenili odabrani događaj", "OK");
                    Navigation.PushAsync(new DogadjajiZaPrisustvovati());
                }
            }
        }
    }
}