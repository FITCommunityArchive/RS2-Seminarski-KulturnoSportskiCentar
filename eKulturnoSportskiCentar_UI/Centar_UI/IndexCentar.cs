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
    public partial class IndexCentar : Form
    {

        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);
        private Centar Centar{ get; set; }
        private int CentarId = 0;
        public IndexCentar()
        {
            InitializeComponent();
            Centar = new Centar();
            AutoValidate = AutoValidate.Disable;
        }

        public void BindGrid()
        {
            HttpResponseMessage response = centarServices.GetResponse();
            if (response.IsSuccessStatusCode)
            {
                List<Centar_Result> centri = response.Content.ReadAsAsync<List<Centar_Result>>().Result;
                Centar_DGV.DataSource = centri;
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

            }
        }
        private void IndexCentar_Load(object sender, EventArgs e)
        {
            BindGrid();
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

        private void TelefonInput_Validating_1(object sender, CancelEventArgs e)
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
        #endregion

        private void Clear()
        {
            Centar = null;
            CentarId = 0;
            NazivInput.Text = null;
            AdresaInput.Text = null;
            TelefonInput.Text = null;
            EmailInput.Text = null;
        }

        private void Sacuvaj_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Centar.CentarID = CentarId;
                Centar.Naziv = NazivInput.Text;
                Centar.Adresa = AdresaInput.Text;
                Centar.Email = EmailInput.Text;
                Centar.Telefon = TelefonInput.Text;


                HttpResponseMessage response = centarServices.PostResponse(Centar);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_centar_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                    BindGrid();
                    Clear();
                            
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

     
      

        private void BindForm(int centarId)
        {
            HttpResponseMessage response = centarServices.GetResponse(centarId.ToString());
            if (response.IsSuccessStatusCode)
            {
                Centar C = response.Content.ReadAsAsync<Centar>().Result;
                NazivInput.Text = C.Naziv;
                AdresaInput.Text = C.Adresa;
                TelefonInput.Text = C.Telefon;
                EmailInput.Text = C.Email;
            }
          
        }

        private void Centar_DGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CentarId = Convert.ToInt32(Centar_DGV.SelectedRows[0].Cells[0].Value);
            BindForm(CentarId);
        }
    }
}
