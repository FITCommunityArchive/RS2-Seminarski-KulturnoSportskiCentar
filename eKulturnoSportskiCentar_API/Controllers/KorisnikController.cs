using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_API.Controllers
{
    public class KorisnikController : ApiController
    {
        eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/Korisnici/5
        [Route("api/korisnik/{id}")]
        public IHttpActionResult GetKorisnik(int id)
        {
            Korisnici_Result1 korisnik = db.esp_Korisnik_SelectById(id).FirstOrDefault();
            if (korisnik == null)
            {
                return NotFound();
            }

            return Ok(korisnik);
        }

        [ResponseType(typeof(Korisnici_Result))]
        [Route("api/korisnik/GetByUsername/{username}")]
        public IHttpActionResult GetByUsername(string username)
        {
            Korisnici_Result1 k = db.esp_Korisnik_SelectByUsername(username).FirstOrDefault();
            if (k == null)
            {
                return NotFound();
            }

            return Ok(k);
        }


        [HttpGet]
        [Route("api/korisnik/SearchByName/{name?}")]
        public List<Korisnici_Result> SearchByName(string name = "")
        {
            return db.esp_Korisnici_SelectByImePrezime(name).ToList();
        }

        // PUT: api/Korisnici/5
        [HttpPut]
        [ResponseType(typeof(void))]
        [Route("api/korisnik/{id}")]
        public IHttpActionResult PutKorisnik(int id, Korisnik K)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != K.KorisnikID)
            {
                return BadRequest();
            }

            try
            {
                db.esp_KorisniciUloge_Delete(id);

                foreach (var x in K.Uloge)
                {
                    db.esp_KorisniciUloge_Insert(K.KorisnikID, x.UlogaID);
                }
                db.esp_Korisnik_Update(K.KorisnikID, K.Ime, K.Prezime, K.Email, K.Telefon, K.KorisnickoIme,
                    K.LozinkaSalt, K.LozinkaHash, K.Status);
            }
            catch (EntityException ex)
            {

                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            throw new HttpResponseException(msg);
        }


        // POST: api/Korisnici
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult PostKorisnik(Korisnik K)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                K.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(K.Ime, K.Prezime, K.Telefon, K.Email, K.KorisnickoIme, K.LozinkaSalt,
                    K.LozinkaHash).FirstOrDefault());
            }
            catch (Exception ex)
            {
                throw;
            }
            if (K.Uloge.Count == 0)
            {
                int ulogaID = db.Uloga.Where(x => x.Naziv == "Korisnik").Select(x => x.UlogaID).FirstOrDefault();
                db.esp_KorisniciUloge_Insert(K.KorisnikID, ulogaID);
            }
            else
            {
                foreach (var x in K.Uloge)
                {
                    db.esp_KorisniciUloge_Insert(K.KorisnikID, x.UlogaID);
                }
            }



            return CreatedAtRoute("DefaultApi", new { id = K.KorisnikID }, K);
        }

        // DELETE: api/Korisnici/5
        [ResponseType(typeof(Korisnik))]
        public IHttpActionResult DeleteKorisnik(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            db.Korisnik.Remove(korisnik);
            db.SaveChanges();

            return Ok(korisnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisnikExists(int id)
        {
            return db.Korisnik.Count(e => e.KorisnikID == id) > 0;
        }
    }
}
