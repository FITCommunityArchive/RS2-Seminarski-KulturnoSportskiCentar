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
        public ListaPrisutnih(int dogadjajId)
        {
            InitializeComponent();
            BindForm(dogadjajId);
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
    }
}
