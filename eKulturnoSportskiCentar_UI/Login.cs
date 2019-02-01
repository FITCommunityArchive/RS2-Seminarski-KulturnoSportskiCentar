using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_UI
{
    public partial class Login : Form
    {
        private WebAPIHelper korisniciServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikRoute);

        public Login()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Prijava_BTN_Click(object sender, EventArgs e)
        {
            Prijava();

        }

        private void Prijava()
        {
            if (ValidateChildren())
            {
                HttpResponseMessage response =
                        korisniciServices.GetActionResponse("GetByUsername", KorisnickoImeInput.Text.ToString());
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show(Messages.login_user_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response.IsSuccessStatusCode)
                {
                    Korisnici_Result1 K = response.Content.ReadAsAsync<Korisnici_Result1>().Result;
                    if (UIHelper.GenerateHash(LozinkaInput.Text, K.LozinkaSalt) == K.LozinkaHash)
                    {
                        this.DialogResult = DialogResult.OK;
                        Korisnik korisnik = new Korisnik
                        {
                            KorisnikID = K.KorisnikID,
                            KorisnickoIme = K.KorisnickoIme,
                            LozinkaHash = K.LozinkaHash,
                            LozinkaSalt = K.LozinkaSalt,
                            Email = K.Email,
                            Telefon = K.Telefon,
                            Ime = K.Ime,
                            Prezime = K.Prezime,
                            Status = K.Status
                        };
                        Global.logiraniKorisnik = korisnik;
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show(Messages.login_pass_err, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LozinkaInput.Text = String.Empty;
                    }
                } 
            }
        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KorisnickoImeInput.Text))
            {
                errorProvider.SetError(KorisnickoImeInput,Messages.KorisnickoIme_Required);
            }
        }

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LozinkaInput.Text))
            {
                errorProvider.SetError(LozinkaInput, Messages.Lozinka_Required);
            }
        }
    }
}
