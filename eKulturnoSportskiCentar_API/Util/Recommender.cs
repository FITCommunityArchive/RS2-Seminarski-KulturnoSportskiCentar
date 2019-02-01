using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_API.Util
{
    public class Recommender
    {
        private eKulturnoSportskiCentar_Entities db=new eKulturnoSportskiCentar_Entities(false);


        public List<Dogadjaji_Result> GetSlicniDogadjaji(int KorisnikID)
        {
            List<DogadjajOcjena> ocjenjeniDogadjaji = db.DogadjajOcjena.Where(x => x.KorisnikID == KorisnikID).OrderBy(x => x.KorisnikID).ToList();
            List<KorisnikDogadjaj> korisnikDogadjaji = db.KorisnikDogadjaj.Where(x => x.KorisnikID == KorisnikID).OrderBy(x => x.KorisnikID).ToList();


          
           List<Dogadjaj> Dogadjaji = new List<Dogadjaj>();

                foreach (KorisnikDogadjaj KD in korisnikDogadjaji)
                {
                    foreach (DogadjajOcjena DO in ocjenjeniDogadjaji)
                    {
                        if (KD.DogadjajID == DO.DogadjajID)
                        {
                            if (!PostojiDogadjaj(Convert.ToInt32(DO.DogadjajID), Dogadjaji))
                            {
                                Dogadjaj dogadjaj = db.Dogadjaj.Where(x => x.DogadjajID == DO.DogadjajID)
                                    .Include(x => x.VrstaDogadjaja).FirstOrDefault();
                                Dogadjaji.Add(dogadjaj);
                            }
                        }
                        else
                        {
                            if (!PostojiDogadjaj(Convert.ToInt32(DO.DogadjajID), Dogadjaji))
                            {
                                Dogadjaj dogadjaj = db.Dogadjaj.Where(x => x.DogadjajID == DO.DogadjajID)
                                    .Include(x => x.VrstaDogadjaja).FirstOrDefault();
                                Dogadjaji.Add(dogadjaj);
                            }
                            if (!PostojiDogadjaj(KD.DogadjajID, Dogadjaji))
                            {
                                Dogadjaj dogadjaj = db.Dogadjaj.Where(x => x.DogadjajID == KD.DogadjajID)
                                    .Include(x => x.VrstaDogadjaja).FirstOrDefault();
                                Dogadjaji.Add(dogadjaj);
                            }
                        }
                    }
                }



                List<VrstaDogadjaja> vrste = new List<VrstaDogadjaja>();
                if (vrste.Count > 0)
                {
                }

                foreach (Dogadjaj D in Dogadjaji)
                {
                    if (!PostojiVrsta(Convert.ToInt32(D.VrstaDogadjajaID), vrste))
                    {
                        vrste.Add(db.VrstaDogadjaja.Where(x => x.VrstaDogadjajaID == D.VrstaDogadjajaID).FirstOrDefault());
                    }
                }

                List<Dogadjaj> slicniDogadjaji = new List<Dogadjaj>();
                foreach (VrstaDogadjaja V in vrste)
                {
                    List<Dogadjaj> listaHelper =new List<Dogadjaj>();
                    listaHelper = db.Dogadjaj.Where(x => x.VrstaDogadjajaID == V.VrstaDogadjajaID
                                                                        && x.JavniDogadjaj == true
                                                                        && x.Aktivna == true && x.Odobrena == true
                    ).ToList();
                    slicniDogadjaji.AddRange(listaHelper);
                }


                List<Dogadjaji_Result> povrat = new List<Dogadjaji_Result>();
                foreach (Dogadjaj D in slicniDogadjaji)
                {
                    Dogadjaji_Result dogadjaj=new Dogadjaji_Result();
                    dogadjaj = db.esp_JavniDogadjaj_SelectByDogadjajID(D.DogadjajID).FirstOrDefault();
                    if (dogadjaj != null)
                    {
                        povrat.Add(dogadjaj);
                }
                        
                }



                List<Dogadjaji_Result> javniDogadjajiAll = db.esp_Dogadjaj_JavniDogadjaji_Select().ToList();
                foreach (var JD in javniDogadjajiAll)
                {
                    if (!PostojiJavniDogadjaj(JD.DogadjajID, povrat))
                    {
                        povrat.Add(JD);
                    }
                }
                return povrat; 
            }
          
        


        bool PostojiDogadjaj(int dogadjajID, List<Dogadjaj> lista)
        {
            foreach (Dogadjaj D in lista)
            {
                if (D.DogadjajID == dogadjajID)
                {
                    return true;
                }

            }
            return false;
        }


        bool PostojiJavniDogadjaj(int dogadjajID, List<Dogadjaji_Result> lista)
        {
            foreach (Dogadjaji_Result D in lista)
            {
                if (D.DogadjajID == dogadjajID)
                {
                    return true;
                }

            }
            return false;
        }

        bool PostojiVrsta(int vrstaID, List<VrstaDogadjaja> lista)
        {
            foreach (VrstaDogadjaja VD in lista)
            {
                if (VD.VrstaDogadjajaID == vrstaID)
                {
                    return true;
                }

            }
            return false;
        }
    }
}