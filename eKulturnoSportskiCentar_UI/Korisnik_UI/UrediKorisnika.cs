using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI.Korisnik_UI
{
    public partial class UrediKorisnika : Form
    {
        private WebAPIHelper korisniciServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikRoute);
        private WebAPIHelper ulogeServices = new WebAPIHelper("http://localhost:51348/", Global.UlogaRoute);
        private WebAPIHelper korisnikUlogaService = new WebAPIHelper("http://localhost:51348/", Global.KorisnikUlogaRoute);
        private Korisnik K { get; set; }
        public UrediKorisnika(int korisnikID)
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = korisniciServices.GetResponse(korisnikID.ToString());

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                K = null;
            }
            else
            {
                K = response.Content.ReadAsAsync<Korisnik>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            ImeInput.Text = K.Ime;
            PrezimeInput.Text = K.Prezime;
            TelefonInput.Text = K.Telefon;
            EmailInput.Text = K.Email;
            KorisnickoImeInput.Text = K.KorisnickoIme;
            status_CHB.Checked =Convert.ToBoolean(K.Status);
            BindUloge();
        }

        private void BindUloge()
        {
            int index = 0;
            HttpResponseMessage response = ulogeServices.GetResponse();
            List<Uloga> uloge = response.Content.ReadAsAsync<List<Uloga>>().Result;
            ulogeLista_CHB.DataSource = uloge;
            ulogeLista_CHB.DisplayMember = "Naziv";
            HttpResponseMessage responseKU = korisnikUlogaService.GetActionResponse("GetByID", K.KorisnikID.ToString());
            List<KorisniciUloge_Result> korisnikUloge = responseKU.Content.ReadAsAsync<List<KorisniciUloge_Result>>().Result;
            foreach (var x in korisnikUloge)
            {
                index = 0;
                foreach (var uloga in uloge)
                {
                    if (x.UlogaID == uloga.UlogaID)
                    {
                        ulogeLista_CHB.SetItemChecked(index, true);
                    }

                    index++;
                }

            }
        }

        private void FillUloge()
        {
            HttpResponseMessage response = ulogeServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Uloga> uloge = response.Content.ReadAsAsync<List<Uloga>>().Result;
                ulogeLista_CHB.DataSource = uloge;
                ulogeLista_CHB.DisplayMember = "Naziv";

            }
        }
        private void UrediKorisnika_Load(object sender, EventArgs e)
        {
            FillUloge();

        }

        #region Validacija
        private void ImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(ImeInput, Messages.Ime_Required);
            }
        }

        private void PrezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PrezimeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(PrezimeInput, Messages.Prezime_Required);
            }

        }

        private void EmailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(EmailInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(EmailInput, Messages.Email_Required);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(EmailInput.Text);
                }
                catch (Exception)
                {

                    e.Cancel = true;
                    errorProvider.SetError(EmailInput, Messages.Email_Error);
                }
            }
        }

        private void KorisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KorisnickoImeInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(KorisnickoImeInput, Messages.KorisnickoIme_Required);
            }

        }

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(LozinkaInput.Text))
            {
                if (LozinkaInput.Text.Length < 8)
                {
                    e.Cancel = true;
                    errorProvider.SetError(LozinkaInput, Messages.Lozinka_Invalid);
                }
            }
        }

        private void ulogeLista_CHB_Validating(object sender, CancelEventArgs e)
        {
            int brojOdabranih = ulogeLista_CHB.CheckedItems.Cast<Uloga>().ToList().Count;
            if (brojOdabranih == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeLista_CHB, Messages.DropDown_NotSelected);
            }
        }
        #endregion

        private void UrediKorisnika_BTN_Click(object sender, EventArgs e)
        {
            if (K != null)
            {

                if (ValidateChildren())
                {
                    K.Ime = ImeInput.Text;
                    K.Prezime = PrezimeInput.Text;
                    K.Telefon = TelefonInput.Text;
                    K.Email = EmailInput.Text;
                    K.KorisnickoIme = KorisnickoImeInput.Text;
                    K.Status = status_CHB.Checked;

                    if (LozinkaInput.Text != string.Empty)
                    {
                        K.LozinkaSalt = UIHelper.GenerateSalt();
                        K.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, K.LozinkaSalt);
                    }

                    K.Uloge = ulogeLista_CHB.CheckedItems.Cast<Uloga>().ToList();

                    HttpResponseMessage response = korisniciServices.PutResponse(K.KorisnikID, K);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Korisnik uspjenšno izmjenjen");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string msg = response.ReasonPhrase;
                        if (!String.IsNullOrEmpty(Messages.ResourceManager.GetString(response.ReasonPhrase)))
                        {
                            msg = Messages.ResourceManager.GetString(response.ReasonPhrase);
                        }

                        MessageBox.Show("Error code: " + response.StatusCode + " Message: " + msg);
                    }
                }


            }
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
