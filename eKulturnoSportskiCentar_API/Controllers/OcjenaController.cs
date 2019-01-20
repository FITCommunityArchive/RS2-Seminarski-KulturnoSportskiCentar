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
    public class OcjenaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/Ocjena
        public IQueryable<Ocjena> GetOcjena()
        {
            return db.Ocjena;
        }

        // GET: api/Ocjena/5
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult GetOcjena(int id)
        {
            Ocjena ocjena = db.Ocjena.Find(id);
            if (ocjena == null)
            {
                return NotFound();
            }

            return Ok(ocjena);
        }

        // PUT: api/Ocjena/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjena(int id, Ocjena ocjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjena.OcjenaID)
            {
                return BadRequest();
            }

            db.Entry(ocjena).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjenaExists(id))
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

        // POST: api/Ocjena
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult PostOcjena(Ocjena ocjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ocjena.Add(ocjena);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjena.OcjenaID }, ocjena);
        }

        // DELETE: api/Ocjena/5
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult DeleteOcjena(int id)
        {
            Ocjena ocjena = db.Ocjena.Find(id);
            if (ocjena == null)
            {
                return NotFound();
            }

            db.Ocjena.Remove(ocjena);
            db.SaveChanges();

            return Ok(ocjena);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjenaExists(int id)
        {
            return db.Ocjena.Count(e => e.OcjenaID == id) > 0;
        }
    }
}