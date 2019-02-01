using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
   public class SALA
    {
        public int SalaID { get; set; }
        public string Sala { get; set; }
        public string Naziv { get; set; }

        public Nullable<int> CentarID { get; set; }
    }
}
