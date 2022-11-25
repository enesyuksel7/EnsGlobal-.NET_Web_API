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
using EnsGlobalAPIEF;

namespace EnsGlobalAPIEF.Controllers
{
    public class ArabalarController : ApiController
    {
        public OtoGaleriDBEntities db = new OtoGaleriDBEntities();
        public void cp()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Arabalar
        public IQueryable<Arabalar> GetArabalar()
        {
            cp();
            return db.Arabalar;
        }

        // GET: api/Arabalar/5
        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult GetArabalar(int id)
        {
            cp();
            Arabalar arabalar = db.Arabalar.Find(id);
            if (arabalar == null)
            {cp();
            
                return NotFound();
            }

            return Ok(arabalar);
        }

        // PUT: api/Arabalar/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArabalar(int id, Arabalar arabalar)
        {
            cp();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != arabalar.ArabaID)
            {
                return BadRequest();
            }

            db.Entry(arabalar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArabalarExists(id))
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

        // POST: api/Arabalar
        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult PostArabalar(Arabalar arabalar)
        {
            cp();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Arabalar.Add(arabalar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = arabalar.ArabaID }, arabalar);
        }

        // DELETE: api/Arabalar/5
        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult DeleteArabalar(int id)
        {
            cp();
            Arabalar arabalar = db.Arabalar.Find(id);
            if (arabalar == null)
            {
                return NotFound();
            }

            db.Arabalar.Remove(arabalar);
            db.SaveChanges();

            return Ok(arabalar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArabalarExists(int id)
        {
            return db.Arabalar.Count(e => e.ArabaID == id) > 0;
        }
    }
}