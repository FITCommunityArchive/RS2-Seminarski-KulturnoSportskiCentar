using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI.Oprema_UI
{
    public partial class UrediOpremu : Form
    {
        private WebAPIHelper salaServices =
            new WebAPIHelper("http://localhost:51348/", Global.SalaRoute);

        private WebAPIHelper opremaServices =
            new WebAPIHelper("http://localhost:51348/", Global.OpremaRoute);

        private Oprema oprema { get; set; }

        public UrediOpremu(int opremaID)
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;

            HttpResponseMessage response = opremaServices.GetResponse(opremaID.ToString());
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                oprema = null;
            }
            else
            {
                oprema = response.Content.ReadAsAsync<Oprema>().Result;
            }
        }


        private void UrediOpremu_Load(object sender, EventArgs e)
        {
            BindSale();
            BindForm();
        }

        private void BindForm()
        {
            Naziv_Input.Text = oprema.Naziv;
            Kolicina_Input.Text = oprema.Kolicina.ToString();

            if (oprema.SlikaThumb != null)
            {
                Image slika = byteArrayToImage(oprema.SlikaThumb);
                Slika_PCB.Image = slika;
            }
        }

        private Image byteArrayToImage(byte[] slikaThumb)
        {
            MemoryStream ms = new MemoryStream(slikaThumb);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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
            Sala_CMB.SelectedValue = oprema.SalaID;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Izmjeni_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (oprema != null)
                {
                    oprema.SalaID = Convert.ToInt32(Sala_CMB.SelectedValue);
                    oprema.Naziv = Naziv_Input.Text;
                    oprema.Kolicina = Convert.ToInt32(Kolicina_Input.Text);
                }
                HttpResponseMessage response = opremaServices.PutResponse(oprema.OpremaID, oprema);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Oprema uspjenšno izmjenjena");
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error Code" +
                                    response.StatusCode + " : Message - " + response.ReasonPhrase);
                }
            }
        }

        private void Naziv_Input_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Naziv_Input.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(Naziv_Input, Messages.Name_Required);
            }
        }

        private void Sala_CMB_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(Sala_CMB.SelectedValue) == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(Sala_CMB, Messages.DropDown_NotSelected);
            }
        }
    }
}
