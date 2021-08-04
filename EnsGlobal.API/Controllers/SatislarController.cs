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
using EnsGlobal.API.Attribute;
using EnsGlobal.DAL;

namespace EnsGlobal.API.Controllers
{
    [ApiExceptionAttribute]
    public class SatislarController : ApiController
    {
        ConnectionsDAL cncDAL = new ConnectionsDAL();

        // GET: api/Satislar
        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IQueryable GetSatislar()
        {
            cncDAL.cpce();
            var sorguAll = (from x in cncDAL.db.Satislar select new { 
                x.Yetkili, 
                x.Tarih, 
                x.Ucret, 
                x.Vergi 
            });

            return sorguAll;
        }

        // GET: api/Satislar/5
        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult GetSatislar(int id)
        {
            var sorguID = (from x in cncDAL.db.Satislar where x.SatisID == id select new { 
                x.Yetkili, 
                x.Tarih, 
                x.Ucret, 
                x.Vergi
            }).FirstOrDefault();

            cncDAL.cpce();
            if (sorguID == null)
                return NotFound();

            return Ok(sorguID);
        }

        // PUT: api/Satislar/5
        [Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSatislar(int id, Satislar satis)
        {
            cncDAL.cpce();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != satis.SatisID)
                return BadRequest();

            cncDAL.db.Entry(satis).State = EntityState.Modified;

            try
            {
                cncDAL.db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SatislarExists(id))
                    return NotFound();
                else
                    throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Satislar

        /// <summary>
        /// Postmanda POST işlemi yaparken json parametrelerine SatisID ve UrunID ekle!
        /// </summary>
        /// <param name="satis"></param>
        /// <returns></returns>
        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult PostSatislar(Satislar satis)
        {
            cncDAL.cpce();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            cncDAL.db.Satislar.Add(satis);
            cncDAL.db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = satis.SatisID }, satis);
        }

        // DELETE: api/Satislar/5
        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult DeleteSatislar(int id)
        {
            cncDAL.cpce();
            Satislar satislar = cncDAL.db.Satislar.Find(id);
            if (satislar == null)
                return NotFound();

            cncDAL.db.Satislar.Remove(satislar);
            cncDAL.db.SaveChanges();

            return Ok(satislar);
        }

        protected override void Dispose(bool disposing)
        {
            cncDAL.cpce();
            if (disposing)
                cncDAL.db.Dispose();
            base.Dispose(disposing);
        }

        private bool SatislarExists(int id)
        {
            cncDAL.cpce();
            return cncDAL.db.Satislar.Count(e => e.SatisID == id) > 0;
        }
    }
}