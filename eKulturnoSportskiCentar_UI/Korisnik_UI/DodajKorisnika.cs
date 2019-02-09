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
    public partial class DodajKorisnika : Form
    {
        private WebAPIHelper korisniciServices = new WebAPIHelper("http://localhost:51348/", Global.KorisnikRoute);
        private WebAPIHelper ulogeServices = new WebAPIHelper("http://localhost:51348/", Global.UlogaRoute);

        public DodajKorisnika()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;

        }


        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
            IndexKorisnici f=new IndexKorisnici();
            f.MdiParent = MdiParent;
            Close();
            f.Show();
        }

        private void DodajKorisnika_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Korisnik K = new Korisnik();
                K.Ime = ImeInput.Text;
                K.Prezime = PrezimeInput.Text;
                K.Telefon = TelefonInput.Text;
                K.Email = EmailInput.Text;
                K.Status = true;
                K.KorisnickoIme = KorisnickoImeInput.Text;
                K.LozinkaSalt = UIHelper.GenerateSalt();
                K.LozinkaHash = UIHelper.GenerateHash(LozinkaInput.Text, K.LozinkaSalt);

                K.Uloge = ulogeLista_CHB.CheckedItems.Cast<Uloga>().ToList();

                HttpResponseMessage response = korisniciServices.PostResponse(K);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_usr_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                    IndexKorisnici f = new IndexKorisnici();
                    f.MdiParent = MdiParent;
                    Close();
                    f.Show();
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

        public void BindUloge()
        {
            HttpResponseMessage response = ulogeServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                ulogeLista_CHB.DataSource = response.Content.ReadAsAsync<List<Uloga>>().Result;
                ulogeLista_CHB.DisplayMember = "Naziv";
                ulogeLista_CHB.ClearSelected();
            }
        }
        private void DodajKorisnika_Load(object sender, EventArgs e)
        {
            BindUloge();
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

        private void TelefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TelefonInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(TelefonInput, "Telefon je obavezno polje!");
            }
            else
            {
                if (TelefonInput.Text.Length != 10 && TelefonInput.Text.Length != 9)
                {
                    e.Cancel = true;
                    errorProvider.SetError(TelefonInput, "Telefon nije u ispravnom formatu!");
                }
            }
        }

        private void LozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LozinkaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.Lozinka_Required);
            }
            if (LozinkaInput.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider.SetError(LozinkaInput, Messages.Lozinka_Invalid);
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

        
    }
}
