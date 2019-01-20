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
    public class VrstaDogadjajaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/VrstaDogadjaja
        [ResponseType(typeof(List<VrstaDogadjaja>))]
       // [Route("api/vrstaDogadjaj")]
        public IHttpActionResult GetVrstaDogadjaja()
        {
            List<VrstaDogadjaja> vrstaDogadjaja = db.VrstaDogadjaja.ToList();
            if (vrstaDogadjaja == null)
            {
                return NotFound();
            }

            return Ok(vrstaDogadjaja);
        }

        // GET: api/VrstaDogadjaja/5
        [ResponseType(typeof(VrstaDogadjaja))]
        public IHttpActionResult GetVrstaDogadjaja(int id)
        {
            VrstaDogadjaja vrstaDogadjaja = db.VrstaDogadjaja.Find(id);
            if (vrstaDogadjaja == null)
            {
                return NotFound();
            }

            return Ok(vrstaDogadjaja);
        }

        // PUT: api/VrstaDogadjaja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVrstaDogadjaja(int id, VrstaDogadjaja vrstaDogadjaja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vrstaDogadjaja.VrstaDogadjajaID)
            {
                return BadRequest();
            }

            db.Entry(vrstaDogadjaja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VrstaDogadjajaExists(id))
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

        // POST: api/VrstaDogadjaja
        [ResponseType(typeof(VrstaDogadjaja))]
        public IHttpActionResult PostVrstaDogadjaja(VrstaDogadjaja vrstaDogadjaja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.VrstaDogadjaja.Add(vrstaDogadjaja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vrstaDogadjaja.VrstaDogadjajaID }, vrstaDogadjaja);
        }

        // DELETE: api/VrstaDogadjaja/5
        [ResponseType(typeof(VrstaDogadjaja))]
        public IHttpActionResult DeleteVrstaDogadjaja(int id)
        {
            VrstaDogadjaja vrstaDogadjaja = db.VrstaDogadjaja.Find(id);
            if (vrstaDogadjaja == null)
            {
                return NotFound();
            }

            db.VrstaDogadjaja.Remove(vrstaDogadjaja);
            db.SaveChanges();

            return Ok(vrstaDogadjaja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VrstaDogadjajaExists(int id)
        {
            return db.VrstaDogadjaja.Count(e => e.VrstaDogadjajaID == id) > 0;
        }
    }
}