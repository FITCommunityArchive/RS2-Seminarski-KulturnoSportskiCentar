using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
     public class DogadjajiZaPrisustvovati_Result
    {
        public int DogadjajID { get; set; }
        public string Naziv { get; set; }
        public Nullable<int> TerminId { get; set; }
        public System.DateTime Datum { get; set; }
        public Nullable<bool> Aktivna { get; set; }
    }
}
