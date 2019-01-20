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
        public IndexSala()
        {
            InitializeComponent();
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

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
           
            DodajSalu f = new DodajSalu();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Centar_CMB.SelectedValue = 0;
                BindGrid();
            }
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
           
            int salaID = Convert.ToInt32(Sala_DGV.SelectedRows[0].Cells[0].Value);
            UrediSalu f = new UrediSalu(salaID);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Centar_CMB.SelectedValue = 0;
                BindGrid();
            }
        }

        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            int salaId = Convert.ToInt32(Sala_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = salaServices.DeleteResponse(salaId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Obrisano");
                BindGrid();
            }
            else
            {
                MessageBox.Show("Nije obrisano");
            }
        }

        private void Centar_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(brojac!=0)
            BindGrid();
        }
    }
}
