using System;
using System.Collections.Generic;
using System.IO;
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
	public partial class DetaljiDogadjaja : ContentPage
    {
        private WebAPIHelper dogadjajServices = new WebAPIHelper(Global.apiRoute, Global.DogadjajRoute);

        public DetaljiDogadjaja (int dogadjajID)
		{
			InitializeComponent ();
            BindField(dogadjajID);
        }

      
        private void BindField(int dogadjajID)
        {
            Detalji_Dogadjaja_Result dogadjaj = new Detalji_Dogadjaja_Result();
            HttpResponseMessage response =
                dogadjajServices.GetActionResponse("GetDetaljiDogadjaja", dogadjajID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();

                dogadjaj = JsonConvert.DeserializeObject<Detalji_Dogadjaja_Result>(jsonObject.Result);


                DogadjajInput.Text = dogadjaj.Dogadjaj;
                VrstaInput.Text = dogadjaj.Vrsta;
                SalaInput.Text = dogadjaj.Sala;
                TerminInput.Text = dogadjaj.Termin;
                KorisikInput.Text = dogadjaj.Korisnik;
               if(dogadjaj.PlakatThumb!=null)
                slika.Source = ImageSource.FromStream(() => new MemoryStream(dogadjaj.PlakatThumb));

            }
            
        }
    }
}