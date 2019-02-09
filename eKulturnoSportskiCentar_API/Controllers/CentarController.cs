using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using eKulturnoSportskiCentar_API.Models;


namespace eKulturnoSportskiCentar_API.Controllers
{
    public class CentarController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        public List<Centar_Result> GetCentri()
        {
            return db.esp_Centar_SelectAll().ToList();
        }

        public IHttpActionResult GetCentar(int id)
        {
            Centar centar = db.Centar.Find(id);
            if (centar == null)
            {
                return NotFound();
            }
            return Ok(centar);
        }
        public IHttpActionResult PutCentar(int id, Centar C)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != C.CentarID)
            {
                return BadRequest();
            }

            db.esp_Centar_Update(id, C.Naziv, C.Adresa, C.Email, C.Telefon);

            return StatusCode(HttpStatusCode.NoContent);
        }

        public IHttpActionResult PostCentar(Centar centar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (centar.CentarID != 0)
            {
                db.esp_Centar_Update(centar.CentarID, centar.Naziv, centar.Adresa, centar.Email, centar.Telefon);

                return StatusCode(HttpStatusCode.NoContent);
            }

            db.Centar.Add(centar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = centar.CentarID }, centar);
        }
        public IHttpActionResult DeleteCentar(int id)
        {
            Centar centar = db.Centar.Find(id);
            if (centar == null)
            {
                return NotFound();
            }

            List<Sala> sale = db.Sala.Where(x => x.CentarID == centar.CentarID).ToList();
            db.Centar.Remove(centar);
            db.SaveChanges();

            return Ok(centar);
        }
    }
}
