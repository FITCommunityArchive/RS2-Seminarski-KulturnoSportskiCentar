using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
   public partial class Termin
    {
         public int TerminID { get; set; }
        public System.DateTime Datum { get; set; }
        public System.TimeSpan Pocetak { get; set; }
        public System.TimeSpan Kraj { get; set; }
        public int SalaID { get; set; }
        public bool Rezervisan { get; set; }
    }
}
