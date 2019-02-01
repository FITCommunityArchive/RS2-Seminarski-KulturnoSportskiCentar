using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eKulturnoSportskiCentar_PCL.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eKulturnoSportskiCentar_PCL;
using System.Net.Http;
using eKulturnoSportskiCentar_PCL.Model;
using Newtonsoft.Json;

namespace eKSC_Solutions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registracija : ContentPage
	{
        private WebAPIHelper korisnikService=new WebAPIHelper(Global.apiRoute,Global.KorisnikRoute);
		public Registracija ()
		{
			InitializeComponent ();
		}

        private void RegistracijaButton_OnClicked(object sender, EventArgs e)
        {
            if (Validacija())
            {
                Korisnik K=new Korisnik();
                K.Ime = imeInput.Text;
                K.Prezime = prezimeInput.Text;
                K.Telefon = telefonInput.Text;
                K.KorisnickoIme = korisnickoImeInput.Text;
                K.Email = emailInput.Text;
                K.LozinkaSalt = UIHelper.GenerateSalt();
                K.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, K.LozinkaSalt);
                K.Uloge = new List<Uloga>();
                korisnikService.PostResponse(K);

                DisplayAlert("Uspjeh", "Uspješno ste se registrovali na sistem", "OK");
                Navigation.PushAsync(new Login());

            }
      
    }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(imeInput.Text))
            {
                DisplayAlert("UPOZORENJE!", "Ime je obavezno polje", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                DisplayAlert("UPOZORENJE!", "Prezime je obavezno polje", "OK");
                return false;

            }
            else if (String.IsNullOrEmpty(telefonInput.Text))
            {
                DisplayAlert("UPOZORENJE!", "Telefon je obavezno polje", "OK");
                return false;
            }
            else if (Convert.ToInt32(IsPhoneNumber(telefonInput.Text)) == 0)
            {
                DisplayAlert("UPOZORENJE!", "Telefon nije u ispravnom formatu", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(emailInput.Text))
            {
                DisplayAlert("UPOZORENJE!", "Email je obavezno polje", "OK");
                return false;
            }

            else if (Convert.ToInt32(IsValid(emailInput.Text)) == 0)
            {
                DisplayAlert("UPOZORENJE!", "Email nije u ispravnom formatu", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                DisplayAlert("UPOZORENJE", "Korisničko ime je obavezno polje", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(lozinkaInput.Text))
            {
                DisplayAlert("UPOZORENJE", "Lozinka je obavezno polje", "OK");
                return false;
            }
            else if (lozinkaInput.Text.Length < 8)
            {
                DisplayAlert("UPOZORENJE", "Lozinka je mora imati minimalno 8 karaktera", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsPhoneNumber(string phone)
        {
            return Regex.Match(phone, @"^([0-9]{9,10})$").Success;
        }
        public bool IsValid(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}