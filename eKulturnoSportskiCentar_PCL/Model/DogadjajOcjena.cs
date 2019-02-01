using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
   public class DogadjajOcjena
    {
        public int DogadjajOcjenaID { get; set; }
        public Nullable<int> KorisnikID { get; set; }
        public Nullable<int> OcjenaID { get; set; }
        public Nullable<int> DogadjajID { get; set; }

        public virtual Dogadjaj Dogadjaj { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Ocjena Ocjena { get; set; }
    }
}
