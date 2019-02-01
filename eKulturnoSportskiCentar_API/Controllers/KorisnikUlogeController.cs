using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eKulturnoSportskiCentar_API.Models;

namespace eKulturnoSportskiCentar_API.Controllers
{
    public class KorisnikUlogeController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);
        
        [ResponseType(typeof(KorisnikUloga))]
        public IHttpActionResult GetKorisnikUloge(int id)
        {
            KorisnikUloga KU = db.KorisnikUloga.Find(id);
            if (KU == null)
                return NotFound();
            return Ok(KU);
        }

        [ResponseType(typeof(List<KorisniciUloge_Result>))]
        [Route("api/korisnikuloge/getById/{id}")]

        public IHttpActionResult GetById(int id)
        {
            //List<KorisniciUloge_Result> uloge = db.esp_KorisniciUloge_GetByUserID(id).ToList();
            List<KorisnikUloga> uloge = db.KorisnikUloga.Where(x => x.KorisnikID == id).Include(x => x.Uloga).ToList();
            if (uloge == null)
            {
                return NotFound();
            }

            return Ok(uloge);
        }
    }
}
