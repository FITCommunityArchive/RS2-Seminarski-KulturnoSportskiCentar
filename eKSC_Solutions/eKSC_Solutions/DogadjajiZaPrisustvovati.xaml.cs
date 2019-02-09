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
	public partial class DogadjajiZaPrisustvovati : ContentPage
	{
        private WebAPIHelper dogadjajaServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajRoute);
        private WebAPIHelper korisnikDogadjajServices = new WebAPIHelper(Global.apiRoute, Global.KorisnikDogadjajRoute);

        public DogadjajiZaPrisustvovati ()
		{
			InitializeComponent ();
		}
        protected override bool OnBackButtonPressed()
        {
            Navigation.PushAsync(new MainPage());
            return true;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindForm();
        }
      
        private void BindForm()
        {
            HttpResponseMessage response = dogadjajaServices.GetActionResponse("GetDogadjajiZaPrisustvovati", Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObjecT = response.Content.ReadAsStringAsync();
                List<DogadjajiZaPrisustvovati_Result> lista =
                    JsonConvert.DeserializeObject<List<DogadjajiZaPrisustvovati_Result>>(jsonObjecT.Result);
                DogadjajiList.ItemsSource = lista;
            }
        }

        private async void Otkazi_BTN_OnClicked(object sender, EventArgs e)
        {
            var odgovor=await DisplayAlert("Info!", "Da li želite otkazati prisustvo na odabranom događaju","DA","NE");
            if (odgovor)
            {
                Button B = sender as Button;
                string DogadjajID = B.CommandParameter.ToString();

                HttpResponseMessage response = dogadjajaServices.GetResponse(DogadjajID);
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();

                    Dogadjaj D = JsonConvert.DeserializeObject<Dogadjaj>(jsonObject.Result);
                    
                    int result = DateTime.Compare(DateTime.Today, D.Termin.Datum);
                    if (result > 0)
                    {
                        DisplayAlert("Greška!", "Događaj je prošao!", "OK");


                    }
                    else
                    {
                        HttpResponseMessage responseDelete = korisnikDogadjajServices.DeleteResponse(DogadjajID, Global.logiraniKorisnik.KorisnikID.ToString());
                        if (responseDelete.IsSuccessStatusCode)
                        {
                            DisplayAlert("Uspjeh!", "Uspješno ste otkazali prisustvo na događaju", "OK");
                            BindForm();

                        }
                    }
                }

                
            }
        }

        private void Ocijeni_BTN_OnClicked(object sender, EventArgs e)
        {
            Button B = sender as Button;
            string DogadjajID = B.CommandParameter.ToString();
            HttpResponseMessage response = dogadjajaServices.GetResponse(DogadjajID);
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();

                Dogadjaj D = JsonConvert.DeserializeObject<Dogadjaj>(jsonObject.Result);
                if (D.Aktivna == false)
                {
                    DisplayAlert("Greška!", "Nemoguće ocjeniti događaj jer je isti otkazan!", "OK");

                }
                else
                {
                    int result = DateTime.Compare(DateTime.Today, D.Termin.Datum);
                    if (result > 0)
                    {
                        Navigation.PushAsync(new OcjeniDogadjaj(D.DogadjajID));

                    }
                    else
                    {
                        DisplayAlert("Greška!", "Nije moguće ocjenuti događaj koji se nije desio!", "OK");
                    }
                }
                
            }
            
        }

        private void DogadjajiList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            this.Navigation.PushAsync(new DetaljiDogadjaja((e.Item as DogadjajiZaPrisustvovati_Result).DogadjajID));

        }
    }
}