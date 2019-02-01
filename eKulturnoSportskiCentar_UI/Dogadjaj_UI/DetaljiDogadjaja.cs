using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class DetaljiDogadjaja : Form
    {
        
        private WebAPIHelper dogadjajServices =new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper dogadjajDodatnaOpremaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajDodatnaOpremaRoute);

        private int dogadjajID { get; set; }

        public DetaljiDogadjaja(int dogadjajId)
        {
            InitializeComponent();
            DodatnaOprema_DGV.AutoGenerateColumns = false;
            dogadjajID = dogadjajId;
            MojDogadjaj_Statistic.Visible = false;
            ListaPrisutnih_BTN.Visible = false;
            Otkazi_BTN.Visible = false;
        }
        public DetaljiDogadjaja(MojiDogadjaji_Result MDR)
        {
            InitializeComponent();
            DodatnaOprema_DGV.AutoGenerateColumns = false;
            dogadjajID = MDR.DogadjajID;
            ProsjecnaOcjena_INPUT.Text = MDR.ProsjecnaOcjena.ToString();
            BrojPrisutnih_Input.Text = MDR.BrojPrisutnih.ToString();
            Odbij_BTN.Visible = false;
            Odobri_Btn.Visible = false;
        }

        private void Odobri_Btn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
            Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
            D.Odobrena = true;
            HttpResponseMessage putResponse = dogadjajServices.PutResponse(dogadjajID, D);
            if (putResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Dogadjaj odobren");
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void Odbij_BTN_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
            Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
            D.Odobrena = false;
            HttpResponseMessage putResponse = dogadjajServices.PutResponse(dogadjajID, D);
            if (putResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Dogadjaj odbijen");
                DialogResult = DialogResult.No;
                Close();
            }
        }

        private void DetaljiDogadjaja_Load(object sender, EventArgs e)
        {
            BindDodatnaOpremaGrid();
            BindField();

        }

        private void BindField()
        {
            Detalji_Dogadjaja_Result dogadjaj=new Detalji_Dogadjaja_Result();
            HttpResponseMessage response =
                dogadjajServices.GetActionResponse("GetDetaljiDogadjaja", dogadjajID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dogadjaj = response.Content.ReadAsAsync<Detalji_Dogadjaja_Result>().Result;
           

            Naziv_Input.Text = dogadjaj.Dogadjaj;
            Vrsta_Input.Text = dogadjaj.Vrsta;
            SalaInput.Text = dogadjaj.Sala;
            Termin_Input.Text = dogadjaj.Termin;
            KorisnikInput.Text = dogadjaj.Korisnik;
            if (dogadjaj.JavniDogadjaj == true)
            {
                javniDogadjaj_box.Visible = true;
                Da_RDB.Checked = true;
                Cijena_Input.Text = dogadjaj.CijenaUlaza.ToString();
                BrojMijesta_Input.Text = dogadjaj.BrojMijesta.ToString();
                if (dogadjaj.PlakatThumb != null)
                {
                    Plakat_PBX.Image = byteArrayToImage(dogadjaj.PlakatThumb);
                }
            }
            else
            {
                NE_RDB.Checked = true;
            }
            }
        }

        private Image byteArrayToImage(byte[] plakatThumb)
        {
            MemoryStream ms = new MemoryStream(plakatThumb);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void BindDodatnaOpremaGrid()
        {
            List<DodatnaOprema> dogadjajDodatnaOprema =
                new List<DodatnaOprema>();
            HttpResponseMessage response =
                dogadjajDodatnaOpremaServices.GetActionResponse("GetDogadatnaOpremaByDogadjaj", dogadjajID.ToString());
            if (response.IsSuccessStatusCode)
            {
                dogadjajDodatnaOprema = response.Content.ReadAsAsync<List<DodatnaOprema>>().Result;
                DodatnaOprema_DGV.DataSource = dogadjajDodatnaOprema;
            }
        }

        private void Odustani_BTN_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.No;
        }

        private void ListaPrisutnih_BTN_Click(object sender, EventArgs e)
        {
          ListaPrisutnih f = new ListaPrisutnih(dogadjajID);
            f.ShowDialog();
        }

        private void Otkazi_BTN_Click(object sender, EventArgs e)
        {
            Yes_No f = new Yes_No("Jeste li sigurni da želite otkazati događaj?");
            if (f.ShowDialog() == DialogResult.Yes)
            {

                
                HttpResponseMessage response = dogadjajServices.GetResponse(dogadjajID.ToString());
                Dogadjaj D = response.Content.ReadAsAsync<Dogadjaj>().Result;
                D.Aktivna = false;
                HttpResponseMessage responseUpdate = dogadjajServices.PutResponse(D.DogadjajID, D);
                if (responseUpdate.IsSuccessStatusCode)
                {
                    MessageBox.Show("Događaj uspješno otkazan");
                }
            }
        }
    }
}
