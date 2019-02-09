using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        private Oprema oprema;
        private int OpremaId = 0;
        public IndexOprema()
        {
            InitializeComponent();
            BindSale();
            AutoValidate = AutoValidate.Disable;
        }

        private void IndexOprema_Load(object sender, EventArgs e)
        {
      
            BindGrid();
           
        }

        private void BindGrid()
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
          sale.Add(new Sala_Result { Sala = "<<<Odaberi Salu>>>", SalaID = 0 });
            sale.AddRange(response.Content.ReadAsAsync<List<Sala_Result>>().Result);
            Sala_CMB.DataSource = sale;
            Sala_CMB.DisplayMember = "Sala";
            Sala_CMB.ValueMember = "SalaID";
        }

        private void Sala_CMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (brojac != 0)
            {
                BindGrid();
            }
           
        }


       

        private void Obrisi_BTN_Click(object sender, EventArgs e)
        {
            Yes_No F=new Yes_No("Da li zelite obrisati opremu?");
            if (F.ShowDialog() == DialogResult.Yes)
            {
                int opremaId = Convert.ToInt32(Oprema_DGV.SelectedRows[0].Cells[0].Value);
                HttpResponseMessage response = opremaServices.DeleteResponse(opremaId);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Obrisano");
                }

                else
                {
                    MessageBox.Show("Nije obrisano");
                }
                BindGrid();
            }
            
        }

        private void Dodaj_BTN_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                oprema.OpremaID = OpremaId;
                oprema.Naziv = Naziv_Input.Text;
                if (Convert.ToInt32(Kolicina_Input.Text) == 0)
                {
                    oprema.Kolicina = 1;
                }
                else
                {
                    oprema.Kolicina = Convert.ToInt32(Kolicina_Input.Text);
                }
                oprema.SalaID = Convert.ToInt32(Sala_CMB.SelectedValue);

                HttpResponseMessage response = opremaServices.PostResponse(oprema);
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

        private void FillForm(int opremaId)
        {
            HttpResponseMessage response = opremaServices.GetResponse(opremaId.ToString());
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                oprema = null;
            }
            else
            {
                oprema = response.Content.ReadAsAsync<Oprema>().Result;
            }

            Naziv_Input.Text = oprema.Naziv;
            Kolicina_Input.Text = oprema.Kolicina.ToString();
            Sala_CMB.SelectedValue = oprema.SalaID;

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


        private void Clear()
        {
            //oprema = null;
            OpremaId = 0;
            Naziv_Input.Text = null;
            Sala_CMB.SelectedIndex = 0;
            Slika_PCB.Image = null;
            Slika_Input = null;
            Kolicina_Input.Text = null;
        }

        private void Oprema_DGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpremaId=Convert.ToInt32(Oprema_DGV.SelectedRows[0].Cells[0].Value);
            FillForm(OpremaId);
        }

        private void DodajSliku_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                oprema = new Oprema();
                openFileDialog.ShowDialog();
                Slika_Input.Text = openFileDialog.FileName;

                oprema.Slika = File.ReadAllBytes(Slika_Input.Text);
                Image orgImage = Image.FromFile(Slika_Input.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
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

                        oprema.SlikaThumb = ms.ToArray();

                    }

                }
                else
                {
                    MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    oprema = null;
                }
            }
            catch (Exception ex)
            {
                //oprema.Slika = null;
                //oprema.SlikaThumb = null;
                Slika_Input.Text = null;
                Slika_PCB.Image = null;
            }
            try
            {
                oprema = new Oprema();
                openFileDialog.ShowDialog();
                Slika_Input.Text = openFileDialog.FileName;

                oprema.Slika = File.ReadAllBytes(Slika_Input.Text);
                Image orgImage = Image.FromFile(Slika_Input.Text);

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
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

                        oprema.SlikaThumb = ms.ToArray();

                    }

                }
                else
                {
                    MessageBox.Show(Messages.picture_war + " " + resizedImgWidth + "x" + resizedImgHeight + ".", Messages.warning,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    oprema = null;
                }
            }
            catch (Exception ex)
            {
                //oprema.Slika = null;
                //oprema.SlikaThumb = null;
                Slika_Input.Text = null;
                Slika_PCB.Image = null;
            }
        }
    }
}
