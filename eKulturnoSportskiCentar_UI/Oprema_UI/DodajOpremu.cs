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
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    public partial class DodajOpremu : Form
    {
        private WebAPIHelper salaServices =
            new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);
        private WebAPIHelper opremaServices =
            new WebAPIHelper("http://localhost:51348/", Global.OpremaRoute);
        private Oprema oprema { get; set; }
        public DodajOpremu()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            oprema = new Oprema();
        }

        private void DodajOpremu_Load(object sender, EventArgs e)
        {
            BindSale();
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

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                oprema.Naziv = Naziv_Input.Text;
                oprema.Kolicina = Convert.ToInt32(Kolicina_Input.Text);
                oprema.SalaID = Convert.ToInt32(Sala_CMB.SelectedValue);

                HttpResponseMessage response = opremaServices.PostResponse(oprema);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Oprema uspješno dodana");
                    this.Close();
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

                }

            }
        }

        private void Naziv_Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Naziv_Input.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(Naziv_Input,Messages.Name_Required);
            }
        }

        private void Sala_CMB_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(Sala_CMB.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(Sala_CMB,Messages.DropDown_NotSelected);
            }
        }
    }
}
