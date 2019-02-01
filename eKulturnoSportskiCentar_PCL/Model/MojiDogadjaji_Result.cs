using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
    public class MojiDogadjaji_Result
    {
        public int DogadjajID { get; set; }
        public string Dogadjaj { get; set; }
        public byte[] Plakat { get; set; }
        public Nullable<bool> Odobrena { get; set; }
        public string Vrsta { get; set; }
        public System.DateTime Datum { get; set; }
        public string Satnica { get; set; }
        public string Sala { get; set; }
        public int SalaID { get; set; }
        public int VrstaDogadjajaID { get; set; }
        public Nullable<bool> Aktivna { get; set; }
        public double BrojPrisutnih { get; set; }
        public double ProsjecnaOcjena { get; set; }
        public byte[] PlakatThumb { get; set; }
       
       
       

    }
}
