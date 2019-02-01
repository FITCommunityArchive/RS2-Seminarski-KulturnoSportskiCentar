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
    public class DogadjajDodatnaOpremaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/DogadjajDodatnaOprema
        public IQueryable<DogadjajDodatnaOprema> GetDogadjajDodatnaOprema()
        {
            return db.DogadjajDodatnaOprema;
        }

        [HttpGet]
        [Route("api/DogadjajDodatnaOprema/GetDogadatnaOpremaByDogadjaj/{dogadjajID}")]
        public IHttpActionResult GetDogadatnaOpremaByDogadjaj(int dogadjajID)
        {
            List<DogadjajDodatnaOprema> dogadjajDodatnaOprema = db.DogadjajDodatnaOprema.Where(x => x.DogadjajID == dogadjajID)
                .ToList();

            List<DodatnaOprema> dodatnaOprema = new List<DodatnaOprema>();
            foreach (var x in dogadjajDodatnaOprema)
            {
                DodatnaOprema DO = db.DodatnaOprema.Find(x.DodatnaOpremaID);
                dodatnaOprema.Add(DO);
            }
            return Ok(dodatnaOprema);
        }

        // GET: api/DogadjajDodatnaOprema/5
        [ResponseType(typeof(DogadjajDodatnaOprema))]
        public IHttpActionResult GetDogadjajDodatnaOprema(int id)
        {
            DogadjajDodatnaOprema dogadjajDodatnaOprema = db.DogadjajDodatnaOprema.Find(id);
            if (dogadjajDodatnaOprema == null)
            {
                return NotFound();
            }

            return Ok(dogadjajDodatnaOprema);
        }

        // PUT: api/DogadjajDodatnaOprema/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDogadjajDodatnaOprema(int id, DogadjajDodatnaOprema dogadjajDodatnaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dogadjajDodatnaOprema.DogadjajDodatnaOpremaID)
            {
                return BadRequest();
            }

            db.Entry(dogadjajDodatnaOprema).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DogadjajDodatnaOpremaExists(id))
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

        // POST: api/DogadjajDodatnaOprema
        [ResponseType(typeof(DogadjajDodatnaOprema))]
        public IHttpActionResult PostDogadjajDodatnaOprema(DogadjajDodatnaOprema dogadjajDodatnaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DogadjajDodatnaOprema.Add(dogadjajDodatnaOprema);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dogadjajDodatnaOprema.DogadjajDodatnaOpremaID }, dogadjajDodatnaOprema);
        }

        // DELETE: api/DogadjajDodatnaOprema/5
        [ResponseType(typeof(DogadjajDodatnaOprema))]
        public IHttpActionResult DeleteDogadjajDodatnaOprema(int id)
        {
            DogadjajDodatnaOprema dogadjajDodatnaOprema = db.DogadjajDodatnaOprema.Find(id);
            if (dogadjajDodatnaOprema == null)
            {
                return NotFound();
            }

            db.DogadjajDodatnaOprema.Remove(dogadjajDodatnaOprema);
            db.SaveChanges();

            return Ok(dogadjajDodatnaOprema);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DogadjajDodatnaOpremaExists(int id)
        {
            return db.DogadjajDodatnaOprema.Count(e => e.DogadjajDodatnaOpremaID == id) > 0;
        }
    }
}