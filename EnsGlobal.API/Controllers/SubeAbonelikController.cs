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
using EnsGlobal.DAL;

namespace EnsGlobal.API.Controllers
{
    public class SubeAbonelikController : ApiController
    {
        private OtoGaleriDBEntities db = new OtoGaleriDBEntities();

        public void CPCE()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/SubeAbonelik
        public IQueryable<SubeAbonelik> GetSubeAbonelik()
        {
            CPCE();
            return db.SubeAbonelik;
        }

        // GET: api/SubeAbonelik/5
        [ResponseType(typeof(SubeAbonelik))]
        public IHttpActionResult GetSubeAbonelik(int id)
        {
            CPCE();
            SubeAbonelik subeAbonelik = db.SubeAbonelik.Find(id);
            if (subeAbonelik == null)
            {
                return NotFound();
            }

            return Ok(subeAbonelik);
        }

        // PUT: api/SubeAbonelik/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSubeAbonelik(int id, SubeAbonelik subeAbonelik)
        {
            CPCE();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subeAbonelik.SubeID)
            {
                return BadRequest();
            }

            db.Entry(subeAbonelik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubeAbonelikExists(id))
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

        // POST: api/SubeAbonelik
        [ResponseType(typeof(SubeAbonelik))]
        public IHttpActionResult PostSubeAbonelik(SubeAbonelik subeAbonelik)
        {
            CPCE();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SubeAbonelik.Add(subeAbonelik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = subeAbonelik.SubeID }, subeAbonelik);
        }

        // DELETE: api/SubeAbonelik/5
        [ResponseType(typeof(SubeAbonelik))]
        public IHttpActionResult DeleteSubeAbonelik(int id)
        {
            CPCE();
            SubeAbonelik subeAbonelik = db.SubeAbonelik.Find(id);
            if (subeAbonelik == null)
            {
                return NotFound();
            }

            db.SubeAbonelik.Remove(subeAbonelik);
            db.SaveChanges();

            return Ok(subeAbonelik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SubeAbonelikExists(int id)
        {
            return db.SubeAbonelik.Count(e => e.SubeID == id) > 0;
        }
    }
}