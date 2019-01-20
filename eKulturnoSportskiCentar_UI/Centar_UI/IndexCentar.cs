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

namespace eKulturnoSportskiCentar_UI.Centar_UI
{
    public partial class IndexCentar : Form
    {

        private WebAPIHelper centarServices = new WebAPIHelper("http://localhost:51348/", Global.CentarRoute);

        public IndexCentar()
        {
            InitializeComponent();
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
        private void DodajKorisnika_BTN_Click(object sender, EventArgs e)
        {
            DodajCentar f = new DodajCentar();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }

        }

        private void UrediCentar_BTN_Click(object sender, EventArgs e)
        {
            int centarId = Convert.ToInt32(Centar_DGV.SelectedRows[0].Cells[0].Value);
            UrediCentar f = new UrediCentar(centarId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            int centarId = Convert.ToInt32(Centar_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = centarServices.DeleteResponse(centarId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Messages.delete_Centar_succes, Messages.msg_succ, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
            }
            else
            {
                MessageBox.Show(Messages.Delete_Centar_Faild, Messages.error, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
