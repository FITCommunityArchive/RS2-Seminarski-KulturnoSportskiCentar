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
    public class DodatnaOpremaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/DodatnaOprema
        public List<DodatnaOprema> GetDodatnaOprema()
        {
            List<DodatnaOprema> lista = db.DodatnaOprema.ToList();
            return lista;
        }

        // GET: api/DodatnaOprema/5
        [ResponseType(typeof(DodatnaOprema))]
        public IHttpActionResult GetDodatnaOprema(int id)
        {
            DodatnaOprema dodatnaOprema = db.DodatnaOprema.Find(id);
            if (dodatnaOprema == null)
            {
                return NotFound();
            }

            return Ok(dodatnaOprema);
        }

        // PUT: api/DodatnaOprema/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDodatnaOprema(int id, DodatnaOprema dodatnaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dodatnaOprema.DodatnaOpremaID)
            {
                return BadRequest();
            }

            db.Entry(dodatnaOprema).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DodatnaOpremaExists(id))
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

        // POST: api/DodatnaOprema
        [ResponseType(typeof(DodatnaOprema))]
        public IHttpActionResult PostDodatnaOprema(DodatnaOprema dodatnaOprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (dodatnaOprema.DodatnaOpremaID != 0)
            {
                db.Entry(dodatnaOprema).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DodatnaOpremaExists(dodatnaOprema.DodatnaOpremaID))
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

            db.DodatnaOprema.Add(dodatnaOprema);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dodatnaOprema.DodatnaOpremaID }, dodatnaOprema);
        }

        // DELETE: api/DodatnaOprema/5
        [ResponseType(typeof(DodatnaOprema))]
        public IHttpActionResult DeleteDodatnaOprema(int id)
        {
            DodatnaOprema dodatnaOprema = db.DodatnaOprema.Find(id);
            if (dodatnaOprema == null)
            {
                return NotFound();
            }

            db.DodatnaOprema.Remove(dodatnaOprema);
            db.SaveChanges();

            return Ok(dodatnaOprema);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DodatnaOpremaExists(int id)
        {
            return db.DodatnaOprema.Count(e => e.DodatnaOpremaID == id) > 0;
        }
    }
}