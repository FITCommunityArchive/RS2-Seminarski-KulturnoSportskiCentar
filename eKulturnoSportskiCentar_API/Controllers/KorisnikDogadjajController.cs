using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_API.Controllers
{
    public class KorisnikDogadjajController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

    

        // GET: api/KorisnikDogadjaj/5
        [ResponseType(typeof(KorisnikDogadjaj))]
        public IHttpActionResult GetKorisnikDogadjaj(int id)
        {
            KorisnikDogadjaj korisnikDogadjaj = db.KorisnikDogadjaj.Find(id);
            if (korisnikDogadjaj == null)
            {
                return NotFound();
            }

            return Ok(korisnikDogadjaj);
        }
        [HttpGet]
        [Route("api/korisnikDogadjaj/ListaPrisutnih/{DogadjajID}")]
        [ResponseType(typeof(List<Lista_Result>))]
        public IHttpActionResult ListaPrisutnih(int DogadjajID)
        {
            List<Lista_Result> povrat = new List<Lista_Result>();
            povrat = db.esp_Dogadjaj_SelectListaPrisutnih(DogadjajID).ToList();
            if (povrat.Count == 0)
                return NotFound();
            return Ok(povrat);
        }

        // PUT: api/KorisnikDogadjaj/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnikDogadjaj(int id, KorisnikDogadjaj korisnikDogadjaj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != korisnikDogadjaj.KorisnikDogadjajID)
            {
                return BadRequest();
            }

            db.Entry(korisnikDogadjaj).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisnikDogadjajExists(id))
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

        // POST: api/KorisnikDogadjaj
        [ResponseType(typeof(KorisnikDogadjaj))]
        public IHttpActionResult PostKorisnikDogadjaj(KorisnikDogadjaj korisnikDogadjaj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            KorisnikDogadjaj KD = db.KorisnikDogadjaj.Where(x =>
                    x.DogadjajID == korisnikDogadjaj.DogadjajID && x.KorisnikID == korisnikDogadjaj.KorisnikID)
                .FirstOrDefault();
            if (KD == null)
            {
                db.KorisnikDogadjaj.Add(korisnikDogadjaj);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = korisnikDogadjaj.KorisnikDogadjajID }, korisnikDogadjaj);

            }
            else return Conflict();
            //try
            //{
            //    db.KorisnikDogadjaj.Add(korisnikDogadjaj);
            //    db.SaveChanges();
            //}
            //catch (EntityException ex)
            //{

            //    throw ex;
            //}

            //return CreatedAtRoute("DefaultApi", new { id = korisnikDogadjaj.KorisnikDogadjajID }, korisnikDogadjaj);
        }

        [ResponseType(typeof(KorisnikDogadjaj))]
        [Route("api/KorisnikDogadjaj/{DogadjajID}/{KorisnikID}")]
        [HttpDelete]
        public IHttpActionResult DeleteKorisnikDogadjaj(int DogadjajID, int KorisnikID)
        {
            KorisnikDogadjaj korisnikDogadjaj = db.KorisnikDogadjaj.Where(x => x.DogadjajID == DogadjajID && x.KorisnikID == KorisnikID).FirstOrDefault();
            if (korisnikDogadjaj == null)
            {
                return NotFound();
            }

            db.KorisnikDogadjaj.Remove(korisnikDogadjaj);
            db.SaveChanges();

            return Ok(korisnikDogadjaj);
        }

        // DELETE: api/KorisnikDogadjaj/5
        [ResponseType(typeof(KorisnikDogadjaj))]
        public IHttpActionResult DeleteKorisnikDogadjaj(int id)
        {
            KorisnikDogadjaj korisnikDogadjaj = db.KorisnikDogadjaj.Find(id);
            if (korisnikDogadjaj == null)
            {
                return NotFound();
            }

            db.KorisnikDogadjaj.Remove(korisnikDogadjaj);
            db.SaveChanges();

            return Ok(korisnikDogadjaj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisnikDogadjajExists(int id)
        {
            return db.KorisnikDogadjaj.Count(e => e.KorisnikDogadjajID == id) > 0;
        }
    }
}