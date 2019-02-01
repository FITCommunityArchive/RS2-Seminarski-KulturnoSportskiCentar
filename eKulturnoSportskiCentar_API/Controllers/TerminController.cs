using System;
using System.Collections.Generic;
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
    public class TerminController : ApiController
    {
        private eKulturnoSportskiCentar_Entities db = new eKulturnoSportskiCentar_Entities(false);

        [ResponseType(typeof(List<Termin>))]
        public IHttpActionResult GetTermin()
        {
            List<Termin> povrat = new List<Termin>();
            for (int i = 8; i < 22; i+=2)
            {
                Termin T = new Termin
                {
                    Pocetak = new TimeSpan(i, 0, 0),
                    Kraj = new TimeSpan(2 + i, 0, 0)
                };
                povrat.Add(T);
            }

            return Ok(povrat);
        }

        // GET: api/Termin/5
        [ResponseType(typeof(Termin))]
        public IHttpActionResult GetTermin(int id)
        {
            Termin termin = db.Termin.Include(x => x.Sala).Where(x => x.TerminID == id).FirstOrDefault();
            if (termin == null)
            {
                return NotFound();
            }

            return Ok(termin);
        }

        [ResponseType(typeof(List<Termin_Result>))]
        [Route("api/termin/{datum}/{salaID}")]
        public IHttpActionResult GetTermin(string datum, int salaID)
        {
            bool isValid = true;
            DateTime DATUM = DateTime.ParseExact(datum, "MMddyyyy", System.Globalization.CultureInfo.InvariantCulture);
            List<Termin_Result> termini = db.esp_Termin_Select(DATUM, salaID).ToList();
            List<Termin> povrat=new List<Termin>();
            for (int i = 8; i < 22; i+=2)
            {
                Termin T = new Termin
                {

                    Pocetak = new TimeSpan(i, 0, 0),
                    Kraj = new TimeSpan(2 + i, 0, 0),
                    Datum =DATUM,
                    SalaID = salaID
                    
                };
                if (termini.Count != 0)
                {
                    foreach (var X in termini)
                    {
                        if (T.Pocetak == X.Pocetak && T.Kraj == X.Kraj)
                        {
                            if (X.Rezervisan)
                            {
                                isValid = false;
                            }
                        }
                    }

                    if (isValid)
                    {
                        povrat.Add(T);
                    }
                    isValid = true;
                }
                else
                {
                    povrat.Add(T);
                }
               
                
               
            }

            foreach (var x in povrat)
            {
                x.salaNaziv = db.Sala.Find(x.SalaID).Naziv;
            }
            return Ok(povrat);
        }

        private bool isJednaki(Termin T1, Termin T2)
        {
            if (T1.Datum == T2.Datum&& T1.Pocetak == T2.Pocetak&& T1.Kraj == T2.Kraj&& T1.SalaID == T2.SalaID)
            {
                return false;
            }
           return true;
        }
        // PUT: api/Termin/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTermin(int id, Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termin.TerminID)
            {
                return BadRequest();
            }

            db.Entry(termin).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerminExists(id))
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

        // POST: api/Termin
        [ResponseType(typeof(Termin))]
        public IHttpActionResult PostTermin(Termin termin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!IsValid(termin))
                return BadRequest(ModelState);

            db.Termin.Add(termin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = termin.TerminID }, termin);
        }
        [HttpGet]
        [Route("api/termin/GenerateTermin")]
        public void GenerateTermin()
        {
            List<Termin> termini = new List<Termin>();
            DateTime danas = DateTime.Today;
            if (danas.AddDays(6) == db.esp_GetZadnjiDatumTermina_Select().FirstOrDefault())
                return;
            List<DateTime> datumi = new List<DateTime>();

            for (int i = 1; i < 7; i++)
            {
                DateTime noviDan = danas.AddDays(i);
                datumi.Add(noviDan);
            }
            List<Sala_Result> sale = db.esp_Sala_GetByCentar(0).ToList();
            foreach (var dan in datumi)
            {
                foreach (var S in sale)
                {                   
                    for (int i = 10; i < 23; i++)
                    {
                        Termin T = new Termin();
                        T.SalaID = S.SalaID;
                        T.Datum = dan;
                        T.Pocetak = new TimeSpan(i, 0, 0);
                        T.Kraj = new TimeSpan(1 + i, 0, 0);
                        if (IsValid(T))
                        {
                            db.Termin.Add(T);
                            db.SaveChanges();
                        }
                    }
                }

            }
          
        }


        private bool IsValid(Termin T)
         {
            List<Termin> termini = db.Termin.ToList();
            foreach (var t in termini)
            {
                if (t.Pocetak == T.Pocetak && t.Kraj == T.Kraj && t.Datum == T.Datum && t.SalaID == T.SalaID)
                    return false;
            }
            return true;
        
        }





        // DELETE: api/Termin/5
        [ResponseType(typeof(Termin))]
        public IHttpActionResult DeleteTermin(int id)
        {
            Termin termin = db.Termin.Find(id);
            if (termin == null)
            {
                return NotFound();
            }

            db.Termin.Remove(termin);
            db.SaveChanges();

            return Ok(termin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TerminExists(int id)
        {
            return db.Termin.Count(e => e.TerminID == id) > 0;
        }
    }
}
