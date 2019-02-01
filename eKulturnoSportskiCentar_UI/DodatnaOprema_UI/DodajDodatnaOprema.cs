using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void DodajSliku_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                dodatnaOprema = new DodatnaOprema();
                openFileDialog.ShowDialog();
                Slika_Input.Text = openFileDialog.FileName;

                dodatnaOprema.Slika = File.ReadAllBytes(Slika_Input.Text);
                Image orgImage = Image.FromFile(Slika_Input.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"])+100;
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"])+100;
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);


                if (orgImage.Width > resizedImgWidth)
                {
                    Image resizedImg = UIHelper.ResizeImage(orgImage, new Size(resizedImgWidth, resizedImgHeight));
                    if (resizedImg.Width > croppedImgWidth && resizedImg.Height > croppedImgHeight)
                    {
                        int croppedXPosition = (resizedImg.Width - croppedImgWidth) / 2;
                        int croppedYPosition = (resizedImg.Height - croppedImgHeight) / 2;

                        Image croppedImg = UIHelper.CropImage(resizedImg, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        Slika_PCB.Image = croppedImg;

                        MemoryStream ms = new MemoryStream();
                        croppedImg.Save(ms, orgImage.RawFormat);

                        dodatnaOprema.SlikaThumb = ms.ToArray();

                    }
                    
                }
                else
                {
                    MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dodatnaOprema = null;
                }
            }
            catch
            {
                
                Slika_Input.Text = null;
                Slika_PCB.Image = null;
            }
        }
    }
}
