using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI.Sala_UI
{
    public partial class UrediSalu : Form
    {
        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);
        private WebAPIHelper salaServices = new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        public Sala S { get; set; }
        public UrediSalu(int salaID)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            HttpResponseMessage response = salaServices.GetResponse(salaID.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                S = null;
            }
            else
            {
                S = response.Content.ReadAsAsync<eKulturnoSportskiCentar_API.Models.Sala>().Result;
                FillForm();
            }    
        }
        private void FillForm()
        {
            BindCentar_CMD();
            Naziv_Input.Text = S.Naziv;
        }
        private void BindCentar_CMD()
        {
            HttpResponseMessage response = centarServices.GetResponse();
            List<Centar> centri = new List<Centar>();
            centri.Add(new Centar() { Naziv = "Odaberi centar" });
            centri.AddRange(response.Content.ReadAsAsync<List<Centar>>().Result);
            Centar_CMB.DataSource = centri;
            Centar_CMB.DisplayMember = "Naziv";
            Centar_CMB.ValueMember = "CentarID";
            Centar_CMB.SelectedValue = S.CentarID;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (S != null)
                {
                    S.Naziv = Naziv_Input.Text;
                    S.CentarID = Convert.ToInt32(Centar_CMB.SelectedValue);
                   
                }

                HttpResponseMessage response = salaServices.PutResponse(S.SalaID, S);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sala uspjenšno izmjenjena");
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
        private void Naziv_Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Naziv_Input.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(Naziv_Input, Messages.Name_Required);
            }
        }

        private void Centar_CMB_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(Centar_CMB.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(Centar_CMB, Messages.DropDown_NotSelected);
            }
        }
        #endregion
    }
}
