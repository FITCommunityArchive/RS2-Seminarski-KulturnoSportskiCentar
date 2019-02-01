using eKulturnoSportskiCentar_PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eKulturnoSportskiCentar_PCL.Model;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eKulturnoSportskiCentar_PCL;

namespace eKSC_Solutions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPrisutnih : ContentPage
	{
        private WebAPIHelper dogadjajaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper korisnikDogadjajServices = new WebAPIHelper("http://localhost:51348", Global.KorisnikDogadjajRoute);

        public ListaPrisutnih (string dogadjajId)
		{
			InitializeComponent ();
            BindForm(dogadjajId);
        }

        private void BindForm(string dogadjajId)
        {
            Dogadjaj D = new Dogadjaj();

            HttpResponseMessage response = dogadjajaServices.GetResponse(dogadjajId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                D = JsonConvert.DeserializeObject<Dogadjaj>(jsonObject.Result);
                naslovLabel.Text = "eKulturnoSportskiCentar:: Lista prisutnih na "+D.Naziv;
                HttpResponseMessage responsePristuni = korisnikDogadjajServices.GetActionResponse("ListaPrisutnih", dogadjajId);
                if (responsePristuni.IsSuccessStatusCode)
                {
                  jsonObject = responsePristuni.Content.ReadAsStringAsync();

                  List<Lista_Result> lista = JsonConvert.DeserializeObject<List<Lista_Result>>(jsonObject.Result);
                    litaPrisutnihLST.ItemsSource= lista;
                }
            }
        }
    }
}