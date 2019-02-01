using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
	public partial class JavniDogadjaji : ContentPage
    {
        private WebAPIHelper dogadjajServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajRoute);
        private WebAPIHelper vrsteDogadjajaServices = new WebAPIHelper(Global.apiRoute, Global.VrstaDogadjajaRoute);
        private WebAPIHelper salaServices = new WebAPIHelper(Global.apiRoute, Global.SalaRoute);
        private WebAPIHelper korisnikDogadjajServices =
            new WebAPIHelper(Global.apiRoute, Global.KorisnikDogadjajRoute);

        private List<MojiDogadjaji_Result> lista { get; set; }
        private int DogadjajID { get; set; }
        private KorisnikDogadjaj korisnikDogadjaj { get; set; }

        public JavniDogadjaji ()
		{
			InitializeComponent ();
            
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindSale();
            BindVrsteDogadjaja();
            DatumPicker.Format = "dd - MM - yyyy";
            naslovLabel.Text = "eKulturnoSportskiCentar::Javni događaji";
            GetDogadjaji();
           BindForm(true);
           korisnikDogadjaj = new KorisnikDogadjaj();
        }

        private void GetDogadjaji()
        {
            DogadjajiList.ItemsSource = null;
            lista = new List<MojiDogadjaji_Result>();

            HttpResponseMessage response =
                dogadjajServices.GetActionResponse("GetSlicniDogadjaji", Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                lista = JsonConvert.DeserializeObject<List<MojiDogadjaji_Result>>(jsonObject.Result);
                foreach (var x in lista)
                {
                    if (x.Aktivna == null)
                    {
                        x.Aktivna = false;
                    }
                    if (x.Odobrena == null)
                    {
                        x.Odobrena = false;
                    }
                }
            }
          
        }
        private void BindForm(bool prikaziSve=false)
        {
            int salaId = SalaPicker.SelectedItem == null ? 0 : Convert.ToInt32((SalaPicker.SelectedItem as SALA).SalaID);
            int vrstaId = vrstaDogadjajaPicker.SelectedItem == null ? 0 : Convert.ToInt32((vrstaDogadjajaPicker.SelectedItem as VrsteDogadjaja).VrstaDogadjajaID);
            DateTime datum = DatumPicker.Date;
            if (prikaziSve)
            {
                DogadjajiList.ItemsSource = lista;
            }
            else if (salaId == 0 && vrstaId != 0)
            {
                List<MojiDogadjaji_Result> test = lista.Where(x => x.Datum == datum && x.VrstaDogadjajaID == vrstaId).ToList();
                DogadjajiList.ItemsSource = test;

            }
            else if (vrstaId == 0 && salaId != 0)
            {
                List<MojiDogadjaji_Result> test = lista.Where(x => x.Datum == datum && x.SalaID == salaId).ToList();
                DogadjajiList.ItemsSource = test;


            }
            else if (salaId == 0 && vrstaId == 0)
            {
                DogadjajiList.ItemsSource =
                    lista.Where(x => x.Datum == datum).ToList();
            }

            else
            {
                DogadjajiList.ItemsSource =
                    lista.Where(x => x.Datum == datum && x.SalaID == salaId && x.VrstaDogadjajaID == vrstaId).ToList();
            }
        }

        private void BindSale()
        {
            HttpResponseMessage response = salaServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<SALA> sale =
                    JsonConvert.DeserializeObject<List<SALA>>(jsonObject.Result);
                SalaPicker.ItemsSource = sale;
                SalaPicker.ItemDisplayBinding = new Binding("Sala");
            }
        }
        private void BindVrsteDogadjaja()
        {
            HttpResponseMessage response = vrsteDogadjajaServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                List<VrsteDogadjaja> vrsteDogadjaja =
                    JsonConvert.DeserializeObject<List<VrsteDogadjaja>>(jsonObject.Result);
                vrstaDogadjajaPicker.ItemsSource = vrsteDogadjaja;
                vrstaDogadjajaPicker.ItemDisplayBinding = new Binding("Naziv");
            }
        }

        private void PrikaziSveBtn_OnClicked(object sender, EventArgs e)
        {
           BindForm(true);
        }

        private void SalaPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BindForm();
        }

        private void VrstaDogadjajaPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            BindForm();
        }

        private void DatumPicker_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            BindForm(true);
        }

        private void OznaciSeBtn_OnClicked(object sender, EventArgs e)
        {
            Button b = sender as Button;
            DogadjajID =Convert.ToInt32(b.CommandParameter.ToString());
            korisnikDogadjaj.KorisnikID = Global.logiraniKorisnik.KorisnikID;
            korisnikDogadjaj.DogadjajID = DogadjajID;
            HttpResponseMessage response = korisnikDogadjajServices.PostResponse(korisnikDogadjaj);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Uspjeh", "Uspješno ste se označili na odabrani događaj", "OK");
                this.Navigation.PushAsync(new DogadjajiZaPrisustvovati());

            }
            else if(response.StatusCode==HttpStatusCode.Conflict)
            {
                DisplayAlert("Info", "Već ste označeni na odabrani događaj", "OK");

            }

        }

        private void DogadjajiList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            this.Navigation.PushAsync(new DetaljiDogadjaja((e.Item as Dogadjaj).DogadjajID));
        }
    }
}