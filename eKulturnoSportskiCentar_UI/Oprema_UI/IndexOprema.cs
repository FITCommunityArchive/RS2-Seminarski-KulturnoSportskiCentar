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

namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    public partial class IndexOprema : Form
    {
        private WebAPIHelper salaServices =
            new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        private WebAPIHelper opremaServices =
            new WebAPIHelper("http://localhost:51348/", Global.OpremaRoute);
        private int brojac = 0;
        public IndexOprema()
        {
            InitializeComponent();
            BindSale();
        }

        private void IndexOprema_Load(object sender, EventArgs e)
        {
      
            BindForm();
           
        }

        private void BindForm()
        {

            int salaId = Convert.ToInt32(Sala_CMB.SelectedValue);
            HttpResponseMessage response = opremaServices.GetActionResponse("GetOpremaBySala", salaId.ToString());
            if (response.IsSuccessStatusCode)
            {
                List<Oprema_Result> oprema = response.Content.ReadAsAsync<List<Oprema_Result>>().Result;
                Oprema_DGV.DataSource = oprema;
                brojac++;

            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

            }
        }

        private void BindSale()
        {
            HttpResponseMessage response = salaServices.GetResponse();
            List<Sala_Result> sale = new List<Sala_Result>();
          sale.Add(new Sala_Result { Sala = "Odaberi Salu", SalaID = 0 });
            sale.AddRange(response.Content.ReadAsAsync<List<Sala_Result>>().Result);
            Sala_CMB.DataSource = sale;
            Sala_CMB.DisplayMember = "Sala";
            Sala_CMB.ValueMember = "SalaID";
        }

        private void Sala_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brojac != 0)
            {
                BindForm();
            }
           
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            DodajOpremu f = new DodajOpremu();
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            int opremaId = Convert.ToInt32(Oprema_DGV.SelectedRows[0].Cells[0].Value);
            UrediOpremu f = new UrediOpremu(opremaId);
            if (f.ShowDialog() == DialogResult.OK)
            {
                BindForm();
            }
        }

        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            int opremaId = Convert.ToInt32(Oprema_DGV.SelectedRows[0].Cells[0].Value);
            HttpResponseMessage response = opremaServices.DeleteResponse(opremaId);

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
