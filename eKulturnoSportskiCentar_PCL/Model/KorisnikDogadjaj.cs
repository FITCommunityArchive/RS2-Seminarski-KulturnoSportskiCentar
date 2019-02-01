using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
   public class KorisnikDogadjaj
    {
        public int KorisnikDogadjajID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public int DogadjajID { get; set; }
    }
}
