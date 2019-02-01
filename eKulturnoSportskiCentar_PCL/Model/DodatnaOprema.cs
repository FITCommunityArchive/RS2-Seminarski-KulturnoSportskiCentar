using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKulturnoSportskiCentar_PCL.Model
{
  public  class DodatnaOprema
    {
        public int DodatnaOpremaID { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool IsOznacen { get; set; }
    }
}
