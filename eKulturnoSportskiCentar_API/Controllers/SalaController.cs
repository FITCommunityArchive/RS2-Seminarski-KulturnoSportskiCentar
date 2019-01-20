using eKulturnoSportskiCentar_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace eKulturnoSportskiCentar_API.Controllers
{
    public class SalaController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        public List<Sala_Result> GetSala()
        {
            List<Sala_Result> S = db.esp_Sala_GetByCentar(0).ToList();
            return S;

        }


        //Get sala by Id
        [ResponseType(typeof(Sala))]
        [Route("api/sala/{id}")]
        public IHttpActionResult GetSala(int id)
        {
            Sala S = db.Sala.Find(id);
            if (S == null)
                return NotFound();
            return Ok(S);

        }


        //Get sala by Centar
        [Route("api/sala/GetByCentar/{centarID?}")]
        public IHttpActionResult GetByCentar(int centarID = 0)
        {
            List<Sala_Result> S = db.esp_Sala_GetByCentar(centarID).ToList();
            if (S == null)
                return NotFound();
            return Ok(S);

        }


        public IHttpActionResult PostSala(Sala s)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            db.Sala.Add(s);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = s.SalaID }, s);
        }


        [Route("api/sala/{id}")]
        [HttpPut]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSala(int id, Sala S)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (id != S.SalaID)
                return BadRequest();
            db.esp_Sala_Update(S.SalaID, S.Naziv,  S.CentarID);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        [Route("api/sala/{salaId}")]
        public IHttpActionResult DeleteSala(int salaId)
        {
            Sala S = db.Sala.Find(salaId);
            if (S == null)
                return NotFound();
            List<Oprema> oprema = db.Oprema.Where(x => x.SalaID == S.SalaID).ToList();
            foreach (var O in oprema)
            {
                db.Oprema.Remove(O);
            }
            db.Sala.Remove(S);
            db.SaveChanges();

            return Ok(S);
        }
    }
}
