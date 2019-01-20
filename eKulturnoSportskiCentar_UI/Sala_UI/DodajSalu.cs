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
    public partial class DodajSalu : Form
    {

        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);
        private WebAPIHelper salaServices = new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        public DodajSalu()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
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

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Sala s = new Sala();
                s.Naziv = Naziv_Input.Text;
                s.CentarID = Convert.ToInt32(Centar_CMB.SelectedValue);

                HttpResponseMessage response = salaServices.PostResponse(s);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_Sala_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
        }

        private void DodajSalu_Load(object sender, EventArgs e)
        {
            BindCentar_CMD();
        }

        private void BindCentar_CMD()
        {
            HttpResponseMessage response = centarServices.GetResponse();
            List<Centar> centri = new List<Centar>();
            centri.Add(new Centar() { Naziv = "Odaberi centar", CentarID = 0 });
            centri.AddRange(response.Content.ReadAsAsync<List<Centar>>().Result);
            Centar_CMB.DataSource = centri;
            Centar_CMB.DisplayMember = "Naziv";
            Centar_CMB.ValueMember = "CentarID";
        }
    }
}
