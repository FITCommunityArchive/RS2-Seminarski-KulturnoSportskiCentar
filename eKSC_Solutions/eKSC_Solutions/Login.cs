using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using eKulturnoSportskiCentar_PCL.Util;
using Xamarin.Forms;
using eKulturnoSportskiCentar_PCL;
using eKulturnoSportskiCentar_PCL.Model;
using Newtonsoft.Json;

namespace eKSC_Solutions
{
	public class Login : ContentPage
	{
        private WebAPIHelper korisnikServices=new WebAPIHelper(Global.apiRoute,Global.KorisnikRoute);
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Global.logiraniKorisnik = null;
            NavigationPage.SetHasNavigationBar(this, false);
          
        }
        public Login ()
		{
            NavigationPage.SetHasBackButton(this,false);
            StackLayout stek = new StackLayout();
            stek.Margin = 30;
            stek.VerticalOptions = LayoutOptions.CenterAndExpand;
            stek.HorizontalOptions=LayoutOptions.CenterAndExpand;
            Label zaglavljeLabel = new Label()
            {
                Text = "Prijava @eKulturnoSportskiCentar",
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.CornflowerBlue
            };

            Entry KorisnickoImeInput = new Entry() { Placeholder = "Korisničko ime" };
            Entry LozinkaInput = new Entry() { Placeholder = "Lozinka", IsPassword = true };

            Button prijavaButton = new Button() { Text = "Prijava",FontSize = 15};
            Button registracijaButton = new Button() { Text = "Registracija" };
            prijavaButton.Clicked += (sender, args) =>
            {
                if (Validacija())
                {
                    HttpResponseMessage response =
                        korisnikServices.GetActionResponse("GetByUsername", KorisnickoImeInput.Text);
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        DisplayAlert("UPOZORENJE!", "Korisničko ime ne postoji!", "OK");

                    }
                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync();
                        Korisnik K = JsonConvert.DeserializeObject<Korisnik>(json.Result);
                        if (K.LozinkaHash == UIHelper.GenerateHash(LozinkaInput.Text, K.LozinkaSalt))
                        {
                            Global.logiraniKorisnik = K;

                            Navigation.PushAsync(new Navigation.MyPage());
                            Navigation.PushModalAsync(new Navigation.MyPage());
                            ////Navigation.PushAsync(new MainPage());

                        }
                        else
                        {
                            DisplayAlert("UPOZORENJE!", "Pogrešna lozinka!", "OK");

                        }
                    }
                }
            };

            bool Validacija()
            {
                if (String.IsNullOrEmpty(KorisnickoImeInput.Text))
                {
                    DisplayAlert("UPOZORENJE", "Molim Vas unesite korisnicko ime", "OK");
                    return false;
                }
                else if (String.IsNullOrEmpty(LozinkaInput.Text))
                {
                    DisplayAlert("UPOZORENJE", "Molim Vas unesite password", "OK");
                    return false;
                }
                else
                {
                    return true;
                }
            }

            stek.Children.Add(zaglavljeLabel);
            stek.Children.Add(KorisnickoImeInput);
            stek.Children.Add(LozinkaInput);

            StackLayout stekButtons = new StackLayout();
            stekButtons.Children.Add(registracijaButton);
            stekButtons.Children.Add(prijavaButton);
            stekButtons.Orientation = StackOrientation.Horizontal;
            stekButtons.HorizontalOptions = LayoutOptions.End;
            stek.Children.Add(stekButtons);

            registracijaButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Registracija());
            };

            Content = stek;
        }
	}
}