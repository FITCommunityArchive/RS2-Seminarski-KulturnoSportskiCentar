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
    public partial class IndexSala : Form
    {
        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);
        private WebAPIHelper salaServices = new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        private int brojac = 0;
        private Sala Sala { get; set; }
        private int SalaId = 0;
        public IndexSala()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }
        private void IndexSala_Load(object sender, EventArgs e)
        {
            BindCentarCMB();
            BindGrid();
        }

       
        private void BindGrid()
        {
            int centarID = Convert.ToInt32(Centar_CMB.SelectedValue);
            HttpResponseMessage response=salaServices.GetActionResponse("GetByCentar", centarID.ToString());
            Sala_DGV.DataSource = response.Content.ReadAsAsync<List<Sala_Result>>().Result;
            brojac++;
        }

        private void BindCentarCMB()
        {
            HttpResponseMessage response = centarServices.GetResponse();
            List<Centar> centri = new List<Centar>();
            centri.Add(new Centar() { Naziv = "<<<SVI CENTRI>>>", CentarID = 0 });
            centri.AddRange(response.Content.ReadAsAsync<List<Centar>>().Result);

            Centar_CMB.DataSource = centri;
            Centar_CMB.ValueMember = "CentarID";
            Centar_CMB.DisplayMember = "Naziv";
        }

  

        

        private void Centar_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(brojac!=0)
            BindGrid();
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

        private void Clear()
        {
            Naziv_Input.Text = null;
            SalaId = 0;
            Centar_CMB.SelectedValue = 0;
            Sala = null;
        }
        private void Sacuvaj_BTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Sala.Naziv = Naziv_Input.Text;
                Sala.SalaID = SalaId;
                Sala.CentarID = Convert.ToInt32(Centar_CMB.SelectedValue);

                HttpResponseMessage response = salaServices.PostResponse(Sala);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(Messages.add_Sala_succ, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                   BindGrid();
                   Clear();

                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
                }
            }
           
        }

        private void Sala_DGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SalaId = Convert.ToInt32(Sala_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = salaServices.GetResponse(SalaId.ToString());
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Sala = null;
            }
            else
            {
                Sala = response.Content.ReadAsAsync<eKulturnoSportskiCentar_API.Models.Sala>().Result;
                FillForm();
            }
        }

        private void FillForm()
        {
            Naziv_Input.Text = Sala.Naziv;
            Centar_CMB.SelectedValue = Sala.CentarID;
        }
    }
}
