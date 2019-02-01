using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
  public  class Dogadjaj
    {
        public int DogadjajID { get; set; }
        public string Naziv { get; set; }
        public Nullable<int> VrstaDogadjajaID { get; set; }
        public Nullable<int> BrojMijesta { get; set; }
        public Nullable<bool> JavniDogadjaj { get; set; }
        public byte[] Plakat { get; set; }
        public byte[] PlakatThumb { get; set; }
        public Nullable<decimal> CijenaUlaza { get; set; }
        public Nullable<int> TerminID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<bool> Odobrena { get; set; }
        public Nullable<bool> Aktivna { get; set; }
        public List<DodatnaOprema>DodatnaOprema { get; set; }
        public  Termin Termin { get; set; }
    }
}
