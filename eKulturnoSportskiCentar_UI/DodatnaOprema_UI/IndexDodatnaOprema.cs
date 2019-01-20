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
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI.DodatnaOprema_UI
{
    public partial class IndexDodatnaOprema : Form
    {
        private WebAPIHelper dodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DodatnaOpremaRoute);

        public IndexDodatnaOprema()
        {
            InitializeComponent();
            DodatnaOprema_DGV.AutoGenerateColumns = false;
            BindForm();
        }

        private void BindForm()
        {

            HttpResponseMessage response = dodatnaOpremaServices.GetResponse();
            List<eKulturnoSportskiCentar_API.Models.DodatnaOprema> dodatnaOprema = response.Content
                .ReadAsAsync<List<eKulturnoSportskiCentar_API.Models.DodatnaOprema>>().Result;

            DodatnaOprema_DGV.DataSource = dodatnaOprema;
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            DodajDodatnaOprema f = new DodajDodatnaOprema();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            int dodatnaOpremaID = Convert.ToInt32(DodatnaOprema_DGV.SelectedRows[0].Cells[0].Value);
            UrediDodatnaOprema f = new UrediDodatnaOprema(dodatnaOpremaID);
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            int dodatnaOpremaID = Convert.ToInt32(DodatnaOprema_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = dodatnaOpremaServices.DeleteResponse(dodatnaOpremaID);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Obrisano");
                BindForm();
            }
            else
            {
                MessageBox.Show("Nije obrisano");
            }
        }
    }
}
