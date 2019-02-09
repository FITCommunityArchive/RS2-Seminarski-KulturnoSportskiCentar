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
    public class OpremaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        // GET: api/Oprema
      

        [ResponseType(typeof(List<Oprema_Result>))]
        [Route("api/oprema/GetOpremaBySala/{salaId?}")]
        public IHttpActionResult GetOpremaBySala(int salaId = 0)
        {
            List<Oprema_Result> oprema = db.esp_Oprema_Select(salaId).ToList();
            if (oprema == null)
                return BadRequest();
            return Ok(oprema);

        }

        // GET: api/Oprema/5
        [HttpGet]
        [Route("api/oprema/{opremaId}")]
        [ResponseType(typeof(Oprema))]
        public IHttpActionResult GetOprema(int opremaId)
        {
            Oprema oprema = db.Oprema.Find(opremaId);
            if (oprema == null)
            {
                return NotFound();
            }

            return Ok(oprema);
        }

        // PUT: api/Oprema/5
        [Route("api/oprema/{opremaId}")]
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOprema(int opremaId, Oprema O)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (opremaId != O.OpremaID)
            {
                return BadRequest();
            }

            db.esp_Oprema_Update(opremaId, O.Naziv, O.Kolicina, O.SalaID, O.Slika,
                O.SlikaThumb);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Oprema
        [ResponseType(typeof(Oprema))]
        public IHttpActionResult PostOprema(Oprema oprema)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (oprema.OpremaID != 0)
            {
                db.esp_Oprema_Update(oprema.OpremaID, oprema.Naziv, oprema.Kolicina,
                    oprema.SalaID, oprema.Slika, oprema.SlikaThumb);
                return StatusCode(HttpStatusCode.NoContent);
            }

        db.Oprema.Add(oprema);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oprema.OpremaID }, oprema);
        }

        // DELETE: api/Oprema/5
        [HttpDelete]
        [Route("api/oprema/{opremaId}")]
        [ResponseType(typeof(Oprema))]
        public IHttpActionResult DeleteOprema(int opremaId)
        {
            Oprema oprema = db.Oprema.Find(opremaId);
            if (oprema == null)
            {
                return NotFound();
            }

            db.Oprema.Remove(oprema);
            db.SaveChanges();

            return Ok(oprema);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OpremaExists(int id)
        {
            return db.Oprema.Count(e => e.OpremaID == id) > 0;
        }
    }
}