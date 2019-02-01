using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using eKulturnoSportskiCentar_PCL;
using eKulturnoSportskiCentar_PCL.Model;
using eKulturnoSportskiCentar_PCL.Util;
using Newtonsoft.Json;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace eKSC_Solutions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KreirajDogadjaj : ContentPage
	{
        private Dogadjaj dogadjaj { get; set; }
        private Termin termin{ get; set; }
        private WebAPIHelper dogadjajServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajRoute);
        private WebAPIHelper terminServices = new WebAPIHelper(Global.apiRoute, Global.TerminRoute);
        private WebAPIHelper vrsteDogadjajaServices = new WebAPIHelper(Global.apiRoute,Global.VrstaDogadjajaRoute);
        private WebAPIHelper dodatnaOpremaServices = new WebAPIHelper(Global.apiRoute, Global.DodatnaOpremaRoute);
        private WebAPIHelper salaServices = new WebAPIHelper(Global.apiRoute, Global.SalaRoute);

        public KreirajDogadjaj (Termin T)
		{
			InitializeComponent ();
            termin = T;
            dogadjaj = new Dogadjaj();
            dogadjaj.DodatnaOprema=new List<DodatnaOprema>();
           BindInfo();
            javniDogadjajaLayout.IsVisible = false;
          }

        protected override void OnAppearing()
        {
            base.OnAppearing();
           BindVrsteDogadjaj();
           BindDodatnaOprema();
           BindInfo();
        }

        private void BindInfo()
        {
            SatnicaInput.Text = "Datum:" + termin.Datum.ToString("dd.MM.yyyy") + " - Početak: " + termin.Pocetak + " - Kraj: " +
                                termin.Kraj;
            SatnicaInput.FontSize = 15;
            HttpResponseMessage response = salaServices.GetResponse(termin.SalaID.ToString());
            var jsonObject = response.Content.ReadAsStringAsync();
            SALA S = JsonConvert.DeserializeObject<SALA>(jsonObject.Result);
            salaInput.Text = "Sala: " + S.Naziv;
            salaInput.FontSize = 15;

        } 
        bool Validacija()
        {
            if (string.IsNullOrEmpty(NazivInput.Text))
            {
                DisplayAlert("Upozorenje!", "Naziv je obavezno polje", "OK");
                return false;
            }
            else if (vrstaPicker.SelectedItem == null)
            {
                DisplayAlert("Upozorenje!", "Niste odabrali vrstu događaja", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BindVrsteDogadjaj()
        {

            HttpResponseMessage response = vrsteDogadjajaServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<VrsteDogadjaja> vrstaDogadjaje = new List<VrsteDogadjaja>();
                var jsonObject = response.Content.ReadAsStringAsync();
                vrstaDogadjaje = JsonConvert.DeserializeObject<List<VrsteDogadjaja>>(jsonObject.Result);
                vrstaPicker.ItemsSource = vrstaDogadjaje;
                vrstaPicker.ItemDisplayBinding = new Binding("Naziv");
               
            }
           
        }

        private void BindDodatnaOprema(List<DodatnaOprema> Oprema = null)
        {
            if (Oprema == null)
            {
                HttpResponseMessage response = dodatnaOpremaServices.GetResponse();
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<DodatnaOprema> dodatnaOprema =
                        JsonConvert.DeserializeObject<List<DodatnaOprema>>(jsonObject.Result);
                    foreach (var x in dodatnaOprema)
                    {
                        x.IsOznacen = false;
                    }
                    DodatnaOpremaList.ItemsSource = dodatnaOprema;
                }
            }
            else
            {
                DodatnaOpremaList.ItemsSource = null;
                 DodatnaOpremaList.ItemsSource = Oprema;
            }
            
            
        }

        


        private void CheckDodatnaOprema(int dodatnaOpremaId)
        {
            List<DodatnaOprema> dodatnaOprema = DodatnaOpremaList.ItemsSource as List<DodatnaOprema>;
            foreach (var x in dodatnaOprema)
            {
                if (x.DodatnaOpremaID == dodatnaOpremaId)
                {
                    if (x.IsOznacen == false){

                        x.IsOznacen = true;
                        dogadjaj.DodatnaOprema.Add(x);
                    }
                    else if(x.IsOznacen){
                      
                        x.IsOznacen = false;
                        dogadjaj.DodatnaOprema.Remove(x);
                    }
                }
            }
           BindDodatnaOprema(dodatnaOprema); 
        }

        private void JavniDogadjajSwitch_OnToggled(object sender, ToggledEventArgs e)
        {
            if (javniDogadjajSwitch.IsToggled == true)
            {
                javniDogadjajaLayout.IsVisible = true;
            }
            else
            {
                javniDogadjajaLayout.IsVisible = false;
            }
        }

        private void DodatnaOpremaList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            int dodatnaOpremaID=(DodatnaOpremaList.SelectedItem as DodatnaOprema).DodatnaOpremaID;
            
            CheckDodatnaOprema(dodatnaOpremaID);
        }

      

        private void KreirajDogadjaj_BTN_OnClicked(object sender, EventArgs e)
        {
            if (Validacija())
            {
                HttpResponseMessage reposnse = terminServices.PostResponse(termin);
                if (reposnse.IsSuccessStatusCode)
                {
                    var jsonObject = reposnse.Content.ReadAsStringAsync();
                    termin = JsonConvert.DeserializeObject<Termin>(jsonObject.Result);
                    dogadjaj.KorisnikID = Global.logiraniKorisnik.KorisnikID;
                    dogadjaj.TerminID = termin.TerminID;
                    dogadjaj.VrstaDogadjajaID = (vrstaPicker.SelectedItem as VrsteDogadjaja).VrstaDogadjajaID;
                    dogadjaj.Naziv = NazivInput.Text;
                    if (javniDogadjajSwitch.IsToggled)
                    {
                        dogadjaj.JavniDogadjaj = true;
                        dogadjaj.BrojMijesta = Convert.ToInt32(brojMjestaInput.Text);
                        dogadjaj.CijenaUlaza = Convert.ToDecimal(brojMjestaInput.Text);
                    }
                    else
                    {
                        dogadjaj.JavniDogadjaj = false;
                    }

                    HttpResponseMessage responseDogadjaj = dogadjajServices.PostResponse(dogadjaj);
                    if (responseDogadjaj.IsSuccessStatusCode)
                    {
                        DisplayAlert("Uspjeh", "Uspješno ste rezervisali termin", "OK");
                        Navigation.PushAsync(new VlastitiDogadjaji(Global.logiraniKorisnik.KorisnikID));
                    }
                }
            }
           
        }
    }
}