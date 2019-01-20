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

    public partial class DodajCentar : Form
    {
        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);

        public DodajCentar()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {


                Centar C = new Centar();
                C.Naziv = NazivInput.Text;
                C.Adresa = AdresaInput.Text;
                C.Email = EmailInput.Text;
                C.Telefon = TelefonInput.Text;


                HttpResponseMessage response = centarServices.PostResponse(C);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_centar_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

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
