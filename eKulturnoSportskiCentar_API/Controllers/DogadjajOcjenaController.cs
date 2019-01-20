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
    public class DogadjajOcjenaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities();

        // GET: api/DogadjajOcjena
        public List<DogadjajOcjena> GetDogadjajOcjena()
        {
            return db.DogadjajOcjena.ToList();
        }

        // GET: api/DogadjajOcjena/5
        [ResponseType(typeof(DogadjajOcjena))]
        public IHttpActionResult GetDogadjajOcjena(int id)
        {
            DogadjajOcjena dogadjajOcjena = db.DogadjajOcjena.Find(id);
            if (dogadjajOcjena == null)
            {
                return NotFound();
            }

            return Ok(dogadjajOcjena);
        }

        [ResponseType(typeof(void))]
        [HttpPost]
        [Route("api/DogadjajOcjena/IsOcjenjen")]
        public int IsOcjenjen(DogadjajOcjena DO)
        {
            List<DogadjajOcjena> lista = db.DogadjajOcjena.ToList();
            int povrat = 0;
            foreach (DogadjajOcjena X in lista)
            {
                if (X.DogadjajID == DO.DogadjajID && X.KorisnikID == DO.KorisnikID)
                {
                    povrat = X.DogadjajOcjenaID;
                }
            }

            return povrat;
        }

        // PUT: api/DogadjajOcjena/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDogadjajOcjena(int id, DogadjajOcjena dogadjajOcjena)
        {
            if (id == 0)
            {
                db.DogadjajOcjena.Add(dogadjajOcjena);
                db.SaveChanges();

                return CreatedAtRoute("DefaultApi", new { id = dogadjajOcjena.DogadjajOcjenaID }, dogadjajOcjena);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dogadjajOcjena.DogadjajOcjenaID)
            {
                return BadRequest();
            }

            db.Entry(dogadjajOcjena).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogadjajOcjenaExists(id))
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

        // POST: api/DogadjajOcjena
        [ResponseType(typeof(DogadjajOcjena))]
        public IHttpActionResult PostDogadjajOcjena(DogadjajOcjena dogadjajOcjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DogadjajOcjena.Add(dogadjajOcjena);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dogadjajOcjena.DogadjajOcjenaID }, dogadjajOcjena);
        }

        // DELETE: api/DogadjajOcjena/5
        [ResponseType(typeof(DogadjajOcjena))]
        public IHttpActionResult DeleteDogadjajOcjena(int id)
        {
            DogadjajOcjena dogadjajOcjena = db.DogadjajOcjena.Find(id);
            if (dogadjajOcjena == null)
            {
                return NotFound();
            }

            db.DogadjajOcjena.Remove(dogadjajOcjena);
            db.SaveChanges();

            return Ok(dogadjajOcjena);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DogadjajOcjenaExists(int id)
        {
            return db.DogadjajOcjena.Count(e => e.DogadjajOcjenaID == id) > 0;
        }
    }
}