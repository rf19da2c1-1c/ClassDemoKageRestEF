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
using ClassDemoKageRestEF.Models;

namespace ClassDemoKageRestEF.Controllers
{
    public class KagerController : ApiController
    {
        private KageModel db = new KageModel();
        private NyKageModel db2 = new NyKageModel();
        

        // GET: api/Kager
        public IQueryable<Kage> GetKages()
        {
            return db.Kages;
        }

        // GET: api/KagerForEn
        [Route("api/KagerForEn")]
        public IQueryable<KagerForEn> GetKagerForEn()
        {
            return db2.KagerForEns;
        }



        // GET: api/Kager/5
        [ResponseType(typeof(Kage))]
        public IHttpActionResult GetKage(int id)
        {
            Kage kage = db.Kages.Find(id);
            if (kage == null)
            {
                return NotFound();
            }

            return Ok(kage);
        }

        
        // GET: api/Kager/5
        [Route("api/KagerForEn/{id}")]
        [ResponseType(typeof(KagerForEn))]
        public IHttpActionResult GetKagerForEn(int id)
        {
            IQueryable<KagerForEn> kager = db2.KagerForEns.Where(k => k.Id == id);

            if (!kager.Any())
            {
                return NotFound();
            }

            return Ok(kager.First());
        }
        

        // PUT: api/Kager/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKage(int id, Kage kage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kage.Id)
            {
                return BadRequest();
            }

            db.Entry(kage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KageExists(id))
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

        // POST: api/Kager
        [ResponseType(typeof(Kage))]
        public IHttpActionResult PostKage(Kage kage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kages.Add(kage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kage.Id }, kage);
        }

        // DELETE: api/Kager/5
        [ResponseType(typeof(Kage))]
        public IHttpActionResult DeleteKage(int id)
        {
            Kage kage = db.Kages.Find(id);
            if (kage == null)
            {
                return NotFound();
            }

            db.Kages.Remove(kage);
            db.SaveChanges();

            return Ok(kage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KageExists(int id)
        {
            return db.Kages.Count(e => e.Id == id) > 0;
        }
    }
}