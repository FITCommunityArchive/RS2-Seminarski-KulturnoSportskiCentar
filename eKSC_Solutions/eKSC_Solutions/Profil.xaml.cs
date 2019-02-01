using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Profil : ContentPage
    {
        private WebAPIHelper korisnikServices = new WebAPIHelper(Global.apiRoute, Global.KorisnikRoute);
        private Korisnik K { get; set; }
        public Profil()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
             K= new Korisnik();
            HttpResponseMessage response = korisnikServices.GetResponse(Global.logiraniKorisnik.KorisnikID.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonObject = response.Content.ReadAsStringAsync();
                 K = JsonConvert.DeserializeObject<Korisnik>(jsonObject.Result);
                BindForm(K);
            }
        }

        private void BindForm(Korisnik K)
        {
            imeInput.Text = K.Ime;
            prezimeInput.Text = K.Prezime;
            korisnickoImeInput.Text = K.Prezime;
            emailInput.Text = K.Email;
            telefonInput.Text = K.Telefon;

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
            else if (string.IsNullOrEmpty(lozinkaInput.Text) == false)
            {
                if (lozinkaInput.Text.Length < 8)
                {
                    DisplayAlert("UPOZORENJE", "Lozinka je mora imati minimalno 8 karaktera", "OK");
                    return false;
                }

                return true;
            }
            else
            {
                return true;
            }
        }
   

    private void IzmjeniButton_OnClicked(object sender, EventArgs e)
        {
            if (Validacija())
            {
                K.Ime = imeInput.Text;
                K.Prezime = prezimeInput.Text;
                K.Telefon = telefonInput.Text;
                K.KorisnickoIme = korisnickoImeInput.Text;
                K.Email = emailInput.Text;
                if (String.IsNullOrEmpty(lozinkaInput.Text) == false)
                {
                    K.LozinkaSalt = UIHelper.GenerateSalt();
                    K.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, K.LozinkaSalt);
                }

                HttpResponseMessage response = korisnikServices.PostResponse(K);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Uspjeh", "Uspješno ste izmjenili stavke vašeg profila", "OK");
                    
                }
            }
           
        }
    }
}