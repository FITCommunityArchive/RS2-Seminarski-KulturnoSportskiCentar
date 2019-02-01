using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using eKulturnoSportskiCentar_PCL.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKulturnoSportskiCentar_PCL;
using eKulturnoSportskiCentar_PCL.Model;
using Newtonsoft.Json;

namespace eKSC_Solutions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Termini : ContentPage
	{
        private WebAPIHelper salaServices=new WebAPIHelper(Global.apiRoute,Global.SalaRoute);
        private WebAPIHelper terminServices = new WebAPIHelper(Global.apiRoute, Global.TerminRoute);

        public Termini ()
		{
			InitializeComponent ();
		}

       protected override void OnAppearing()
       {
           DatumPicker.MinimumDate=DateTime.Today;
           string format = "dd.MM.yyyy";
           DatumPicker.Format = "dd - MM - yyyy";
           HttpResponseMessage response = salaServices.GetResponse();
           if (response.IsSuccessStatusCode)
           {
               var jsonObject = response.Content.ReadAsStringAsync();
               List<SALA> sale = JsonConvert.DeserializeObject<List<SALA>>(jsonObject.Result);
               SalaPicker.ItemsSource = sale;
               SalaPicker.ItemDisplayBinding = new Binding("Sala");
           }
           base.OnAppearing();
       }

       class terminIspis
       {
           public string satnica { get; set; }
           public string sala { get; set; }
           public int TerminID { get; set; }
           public System.DateTime Datum { get; set; }
           public System.TimeSpan Pocetak { get; set; }
           public System.TimeSpan Kraj { get; set; }
           public int SalaID { get; set; }

        }

       private void SalaPicker_OnSelectedIndexChanged(object sender, EventArgs e)
       {
           if (SalaPicker.SelectedItem!=null)
           {
               int salaId = (SalaPicker.SelectedItem as SALA).SalaID;
               string datum = DatumPicker.Date.ToString("MMddyyyy"); //.Value.ToString("MMddyyyy");
               HttpResponseMessage response = terminServices.GetActionResponse(datum, salaId.ToString());

               if (response.IsSuccessStatusCode)
               {
                   var jsonObject = response.Content.ReadAsStringAsync();
                   List<Termin> termini = JsonConvert.DeserializeObject<List<Termin>>(jsonObject.Result);
                   List<terminIspis> ispis = new List<terminIspis>();
                   foreach (var x in termini)
                   {
                       terminIspis T = new terminIspis
                       {
                           sala = (SalaPicker.SelectedItem as SALA).Sala,
                           satnica = "Datum:" +x.Datum.ToString("dd.MM.yyyy") + " Početak: " + x.Pocetak + " Kraj: " +
                                     x.Kraj,
                           Datum = x.Datum,
                           Pocetak = x.Pocetak,
                           Kraj = x.Kraj,
                           SalaID = (SalaPicker.SelectedItem as SALA).SalaID
                       };
                      
                       
                       ispis.Add(T);
                   }

                   terminList.ItemsSource = ispis;
               }
            }
         
        }

       private void DatumPicker_OnDateSelected(object sender, DateChangedEventArgs e)
       {
           if (SalaPicker.SelectedItem != null)
           {
               int salaId = (SalaPicker.SelectedItem as SALA).SalaID;
               string datum = DatumPicker.Date.ToString("MMddyyyy"); //.Value.ToString("MMddyyyy");
               HttpResponseMessage response = terminServices.GetActionResponse(datum, salaId.ToString());

               if (response.IsSuccessStatusCode)
               {
                   var jsonObject = response.Content.ReadAsStringAsync();
                   List<Termin> termini = JsonConvert.DeserializeObject<List<Termin>>(jsonObject.Result);
                   List<terminIspis> ispis = new List<terminIspis>();
                   foreach (var x in termini)
                   {
                       terminIspis T = new terminIspis();
                       T.sala = (SalaPicker.SelectedItem as SALA).Sala;
                       T.satnica = "Datum:" + x.Datum.ToString("dd.MM.yyyy") + " Početak: " + x.Pocetak + " Kraj: " +
                                   x.Kraj;


                       ispis.Add(T);
                   }

                   terminList.ItemsSource = ispis;
               }
           }
           else
           {
               DisplayAlert("Upozorenje!", "Niste odabrali salu", "OK");
           }
       }

       private void TerminList_OnItemTapped(object sender, ItemTappedEventArgs e)
       {
           if (e.Item!=null)
           {
               Termin T = new Termin();
               T.Datum = (e.Item as terminIspis).Datum;
               T.Pocetak = (e.Item as terminIspis).Pocetak;
               T.Kraj = (e.Item as terminIspis).Kraj;
               T.SalaID = (e.Item as terminIspis).SalaID;
               Navigation.PushAsync(new KreirajDogadjaj(T));

           }
        }
    }
}