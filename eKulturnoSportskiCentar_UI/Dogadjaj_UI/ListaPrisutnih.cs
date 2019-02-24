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

namespace eKulturnoSportskiCentar_UI.Dogadjaj_UI
{
    public partial class ListaPrisutnih : Form
    {
        private WebAPIHelper dogadjajaServices = new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private WebAPIHelper korisnikDogadjajServices = new WebAPIHelper("http://localhost:51348", Global.KorisnikDogadjajRoute);
        private WebAPIHelper dogadjajServices =   new WebAPIHelper("http://localhost:51348/", Global.DogadjajRoute);
        private bool IsDetalji { get; set; }
        private int dogadjajID { get; set; }
        public ListaPrisutnih(int dogadjajId, bool isDetalji)
        {
            InitializeComponent();
            BindForm(dogadjajId);
            dogadjajID = dogadjajId;
            IsDetalji = isDetalji;
        }

        private void BindForm(int dogadjajId)
        {
           Dogadjaj D=new Dogadjaj();
          
           HttpResponseMessage response = dogadjajaServices.GetResponse(dogadjajId.ToString());
           if (response.IsSuccessStatusCode)
           {
             
                D = response.Content.ReadAsAsync<Dogadjaj>().Result;
                NazivDogadjaj_INPUT.Text = D.Naziv;
                HttpResponseMessage responsePristuni= korisnikDogadjajServices.GetActionResponse("ListaPrisutnih", dogadjajId.ToString());
               if (responsePristuni.IsSuccessStatusCode)
               {
                   List<Lista_Result> lista = responsePristuni.Content.ReadAsAsync<List<Lista_Result>>().Result;
                   listaPrisutnih_DGV.DataSource = lista;
               }
            }
        }

        private void ListaPrisutnih_Deactivate(object sender, EventArgs e)
        {
            if (IsDetalji)
            {
                HttpResponseMessage response =
              dogadjajServices.GetActionResponse("MojiDogadjaji", Global.logiraniKorisnik.KorisnikID.ToString());
                List<MojiDogadjaji_Result> lista = response.Content.ReadAsAsync<List<MojiDogadjaji_Result>>().Result;

                MojiDogadjaji_Result MDR = lista.Where(x => x.DogadjajID == dogadjajID).FirstOrDefault();
                var parent = MdiParent;
                foreach (var x in MdiParent.MdiChildren)
                {
                    x.Close();
                }
                DetaljiDogadjaja f = new DetaljiDogadjaja(MDR);
                f.MdiParent = parent;
                f.Show();
            }
            else
            {
                var parent = MdiParent;
                foreach (var x in this.MdiChildren)
                {
                    x.Close();
                }
                VlastitiDogadjaji f = new VlastitiDogadjaji();
                f.MdiParent = parent;
                f.Show();

            }
        }
    }
}
