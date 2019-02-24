using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using eKulturnoSportskiCentar_PCL;
using Xamarin.Forms;

namespace eKSC_Solutions
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
           
        }

        private void JavniDogadjaji_BTN_OnClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new eKSC_Solutions.JavniDogadjaji());
        }



        private void Profil_BTN_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profil());

        }

        private async void  Odjava_BTN_OnClicked(object sender, EventArgs e)
        {
           
            var odgovor= await DisplayAlert("Upozorenje", "Da li se odjavljijete", "DA", "NE");
            if (odgovor)
            {
                
                Navigation.PushAsync(new Login());
            }
           
        }

        private void Termin_BTN_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Termini());

        }

        private void VlastitiDogadjaji_BTN_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VlastitiDogadjaji(Global.logiraniKorisnik.KorisnikID));

        }

        private void DogadjiZaPristuvovati_BTN_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DogadjajiZaPrisustvovati());
        }
    }
}
