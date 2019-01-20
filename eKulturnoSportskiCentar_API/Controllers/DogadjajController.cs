using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_API.Controllers
{
    public class DogadjajController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);



        [ResponseType(typeof(List<DogadjajiZaAdministraciju_Result>))]
        [Route("api/Dogadjaj/GetDogadjajiZaAdministraciju")]
        public IHttpActionResult GetDogadjajiZaAdministraciju()
        {
            List<DogadjajiZaAdministraciju_Result> lista = db.esp_DogadjajiZaAdministraciju_Select().ToList();
            return Ok(lista);
        }


        //Get: api/Dogadjaj/GetDogadjajiZaPrisustvovati
        [HttpGet]
        [ResponseType(typeof(List<DogadjajiZaPrisustvovati_Result>))]
        [Route("api/Dogadjaj/GetDogadjajiZaPrisustvovati/{KorisnikId}")]
        public IHttpActionResult GetDogadjajiZaPrisustvovati(int KorisnikId)
        {
            List<DogadjajiZaPrisustvovati_Result> result = db.esp_DogadjajiZaPrisustvovati_SelectByKorisnik(KorisnikId).ToList();
            return Ok(result);
        }

        // GET: api/Dogadjaj
        [ResponseType(typeof(List<Dogadjaji_Result>))]
        public IHttpActionResult GetDogadjaj()
        {
            List<Dogadjaji_Result> lista = db.esp_Dogadjaj_JavniDogadjaji_Select().ToList();
            foreach (var X in lista)
            {
                List<KorisnikDogadjaj> ListaPrisutnih = db.KorisnikDogadjaj.Where(s => s.DogadjajID == X.DogadjajID).ToList();
                List<DogadjajOcjena> DogadjajOcjena = db.DogadjajOcjena.Where(o => o.DogadjajID == X.DogadjajID).ToList();
                X.BrojPrisutnih = ListaPrisutnih.Count;
                double suma = 0;
                foreach (var O in DogadjajOcjena)
                {
                    suma += Double.Parse(O.Ocjena.OcjenaBroj.ToString());
                }
                if (X.BrojPrisutnih == 0)
                {
                    X.ProsjecnaOcjena = 0;
                }
                else
                {
                    X.ProsjecnaOcjena = suma / X.BrojPrisutnih;
                }
            }
            return Ok(lista);
        }

        //GET: api/Dogadjaj/MojiDogadjaji/{koriskikID}
        [HttpGet]
        [Route("api/Dogadjaj/MojiDogadjaji/{korisnikID}")]
        public IHttpActionResult GetMojiDogadjaji(int korisnikID)
        {
            List<MojiDogadjaji_Result> povrat = db.esp_MojiDogadjaji_SelectByKorisnik(korisnikID)
                .OrderByDescending(x => x.Datum).ToList();
            foreach (var X in povrat)
            {
                List<KorisnikDogadjaj> ListaPrisutnih = db.KorisnikDogadjaj.Where(s => s.DogadjajID == X.DogadjajID).ToList();
                List<DogadjajOcjena> DogadjajOcjena = db.DogadjajOcjena.Where(o => o.DogadjajID == X.DogadjajID).ToList();
                X.BrojPrisutnih = ListaPrisutnih.Count;
                double suma = 0;
                foreach (var O in DogadjajOcjena)
                {
                    suma += Double.Parse(O.Ocjena.OcjenaBroj.ToString());
                }
                if (X.BrojPrisutnih == 0)
                {
                    X.ProsjecnaOcjena = 0;
                }
                else
                {
                    X.ProsjecnaOcjena = suma / X.BrojPrisutnih;
                }
            }
            return Ok(povrat);
        }

    // GET: api/Dogadjaj/5
        [ResponseType(typeof(Dogadjaj))]
        public IHttpActionResult GetDogadjaj(int id)
        {
            Dogadjaj dogadjaj = db.Dogadjaj.Include(x => x.Termin).Where(x => x.DogadjajID == id).FirstOrDefault();
            if (dogadjaj == null)
            {
                return NotFound();
            }

            return Ok(dogadjaj);
        }

        // PUT: api/Dogadjaj/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDogadjaj(int id, Dogadjaj dogadjaj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dogadjaj.DogadjajID)
            {
                return BadRequest();
            }

            if (dogadjaj.Odobrena == true)
            {
                Termin T = db.Termin.Find(dogadjaj.TerminID);
                T.Rezervisan = true;
            }
            db.Entry(dogadjaj).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogadjajExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Dogadjaj
        [ResponseType(typeof(Dogadjaj))]
        public IHttpActionResult PostDogadjaj(Dogadjaj dogadjaj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dogadjaj.Add(dogadjaj);
            db.SaveChanges();
            foreach (DodatnaOprema x in dogadjaj.DodatnaOprema)
            {
                db.esp_DogadjajDodatnaOprema_Insert(dogadjaj.DogadjajID, x.DodatnaOpremaID);
            }
            return CreatedAtRoute("DefaultApi", new { id = dogadjaj.DogadjajID }, dogadjaj);
        }

        // DELETE: api/Dogadjaj/5
        [ResponseType(typeof(Dogadjaj))]
        public IHttpActionResult DeleteDogadjaj(int id)
        {
            Dogadjaj dogadjaj = db.Dogadjaj.Find(id);
            if (dogadjaj == null)
            {
                return NotFound();
            }

            db.Dogadjaj.Remove(dogadjaj);
            db.SaveChanges();

            return Ok(dogadjaj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DogadjajExists(int id)
        {
            return db.Dogadjaj.Count(e => e.DogadjajID == id) > 0;
        }
    }
}