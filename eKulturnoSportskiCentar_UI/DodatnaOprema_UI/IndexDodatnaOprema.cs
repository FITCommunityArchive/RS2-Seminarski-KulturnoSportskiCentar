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
    public partial class IndexDodatnaOprema : Form
    {
        private WebAPIHelper dodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DodatnaOpremaRoute);
        private DodatnaOprema dodatnaOprema { get; set; }
        private int dodatnaOpremaId = 0;

        public IndexDodatnaOprema()
        {
            InitializeComponent();
            DodatnaOprema_DGV.AutoGenerateColumns = false;
            BindGrid();
            dodatnaOprema = new DodatnaOprema();
            AutoValidate = AutoValidate.Disable;
        }

        private void BindGrid()
        {

            HttpResponseMessage response = dodatnaOpremaServices.GetResponse();
            List<eKulturnoSportskiCentar_API.Models.DodatnaOprema> dodatnaOprema = response.Content
                .ReadAsAsync<List<eKulturnoSportskiCentar_API.Models.DodatnaOprema>>().Result;

            DodatnaOprema_DGV.DataSource = dodatnaOprema;
            Clear();
            
        }

       
        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            Yes_No f=new Yes_No("Da li želite uklonuti dodatnu opremu?");
            if (f.ShowDialog() == DialogResult.Yes)
            {
                int dodatnaOpremaID = Convert.ToInt32(DodatnaOprema_DGV.SelectedRows[0].Cells[0].Value);
                HttpResponseMessage response = dodatnaOpremaServices.DeleteResponse(dodatnaOpremaID);
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
        }

        private void DodajSliku_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                dodatnaOprema = new DodatnaOprema();
                openFileDialog.ShowDialog();
                Slika_Input.Text = openFileDialog.FileName;

                dodatnaOprema.Slika = File.ReadAllBytes(Slika_Input.Text);
                Image orgImage = Image.FromFile(Slika_Input.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]) + 100;
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]) + 100;
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

        private void Sacuvaj_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                dodatnaOprema.DodatnaOpremaID = dodatnaOpremaId;
                dodatnaOprema.Naziv = Naziv_Input.Text;
                dodatnaOprema.Cijena = Convert.ToDecimal(Cijena_Input.Text);


                HttpResponseMessage response = dodatnaOpremaServices.PostResponse(dodatnaOprema);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Podaci uspješno spremljeni");
                    BindGrid();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);

                }
            }
        }

       private void Clear()
       {
           Slika_PCB.Image = null;
           Naziv_Input.Text = "";
           Cijena_Input.Text = "";
           Slika_Input.Text = "";
           dodatnaOpremaId = 0;
           dodatnaOprema = null;

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

        private void DodatnaOprema_DGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dodatnaOpremaId = Convert.ToInt32(DodatnaOprema_DGV.SelectedRows[0].Cells[0].Value);
            FillForm(dodatnaOpremaId);
        }

        private void FillForm(int dodatnaOpremaId)
        {
            HttpResponseMessage response = dodatnaOpremaServices.GetResponse(dodatnaOpremaId.ToString());
            DodatnaOprema DO = response.Content.ReadAsAsync<DodatnaOprema>().Result;
            dodatnaOprema = DO;
            if (DO != null)
            {
                Naziv_Input.Text = DO.Naziv;

                Cijena_Input.Text = DO.Cijena.ToString();
                if (DO.Slika != null)
                {
                    Image slika = byteArrayToImage(DO.SlikaThumb);
                    Slika_PCB.Image = slika;
                }
            }
        }

        private Image byteArrayToImage(byte[] slikaThumb)
        {
            MemoryStream ms = new MemoryStream(slikaThumb);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
