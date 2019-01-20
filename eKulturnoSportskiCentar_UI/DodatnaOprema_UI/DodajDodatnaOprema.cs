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
using eKulturnoSportskiCentar_UI.Util;

namespace eKulturnoSportskiCentar_UI.DodatnaOprema_UI
{
    public partial class DodajDodatnaOprema : Form
    {
        private WebAPIHelper DodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DodatnaOpremaRoute);
        private DodatnaOprema dodatnaOprema { get; set; }
        public DodajDodatnaOprema()
        {
            InitializeComponent();
            dodatnaOprema = new DodatnaOprema();
            AutoValidate = AutoValidate.Disable;
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                dodatnaOprema.Naziv = Naziv_Input.Text;
                dodatnaOprema.Cijena = Convert.ToDecimal(Cijena_Input.Text);


                HttpResponseMessage response = DodatnaOpremaServices.PostResponse(dodatnaOprema);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Oprema uspješno dodana");

                    this.Close();
                    DialogResult = DialogResult.OK;
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
        #endregion
    }
}
