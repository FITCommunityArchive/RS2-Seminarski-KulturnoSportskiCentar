using eKulturnoSportskiCentar_API.Models;
using eKulturnoSportskiCentar_UI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKulturnoSportskiCentar_UI
{
    public class Global
    {
        public static Korisnik logiraniKorisnik { get; set; }
        public const string CentarRoute = "api/Centar";
        public const string DodatnaOpremaRoute = "api/DodatnaOprema";
        public const string SalaRoute = "api/Sala";
        public const string TerminRoute = "api/Termin";
        public const string RezervacijaRoute = "api/Rezervacija";
        public const string DogadjajRoute = "api/Dogadjaj";
        public const string KorisnikDogadjajRoute = "api/korisnikDogadjaj";
        public const string OcjenaRoute = "api/Ocjena";
        public const string KorisnikRoute = "api/korisnik";
        public const string DogadjajOcjenaRoute = "api/dogadjajOcjena";
        public const string UlogaRoute = "api/Uloga";
        public const string KorisnikUlogaRoute = "api/korisnikUloge";
        public const string OpremaRoute = "api/oprema";
        public const string VrstaDogadjajaRoute = "api/vrstaDogadjaja";
        public const string DogadjajDodatnaOpremaRoute = "api/DogadjajDodatnaOprema";
    }

}
