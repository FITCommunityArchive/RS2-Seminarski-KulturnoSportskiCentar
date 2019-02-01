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

namespace eKulturnoSportskiCentar_UI.Centar_UI
{
    public partial class UrediCentar : Form
    {

        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);
        private Centar C { get; set; }

        public UrediCentar(int centarId)
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = centarServices.GetResponse(centarId.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                C = null;
            }
            else
            {
                C = response.Content.ReadAsAsync<Centar>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            NazivInput.Text = C.Naziv;
            AdresaInput.Text = C.Adresa;
            TelefonInput.Text = C.Telefon;
            EmailInput.Text = C.Email;

        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Uredi_BTN_Click(object sender, EventArgs e)
        {

            if (C != null)
            {
                C.Naziv = NazivInput.Text;
                C.Adresa = AdresaInput.Text;
                C.Telefon = TelefonInput.Text;
                C.Email = EmailInput.Text;
            }
            if (this.ValidateChildren())
            {

                HttpResponseMessage response = centarServices.PutResponse(C.CentarID, C);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_edit_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Code" +
                                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        #region Validacija  
        private void NazivInput_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(NazivInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(NazivInput, Messages.Name_Required);
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
        private void AdresaInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AdresaInput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(AdresaInput, Messages.Adresa_Required);
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
        #endregion

      
    }
}
