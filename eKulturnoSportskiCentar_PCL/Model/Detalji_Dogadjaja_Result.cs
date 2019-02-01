using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
    public class Detalji_Dogadjaja_Result
    {
        public int DogadjajID { get; set; }
        public string Dogadjaj { get; set; }
        public Nullable<decimal> CijenaUlaza { get; set; }
        public Nullable<int> BrojMijesta { get; set; }
        public Nullable<bool> JavniDogadjaj { get; set; }
        public byte[] Plakat { get; set; }
        public string Termin { get; set; }
        public string Vrsta { get; set; }
        public string Sala { get; set; }
        public string Korisnik { get; set; }
        public byte[] PlakatThumb { get; set; }
    }
}
