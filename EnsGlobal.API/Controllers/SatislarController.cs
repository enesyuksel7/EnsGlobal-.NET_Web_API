﻿using EnsGlobal.API.Attribute;
using EnsGlobal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EnsGlobal.API.Controllers
{
    [ApiExceptionAttribute]
    public class SatislarController : ApiController
    {
        SatislarDAL satisDAL = new SatislarDAL();

        [Authorize]
        [ResponseType(typeof(IEnumerable<Satislar>))]
        public IHttpActionResult Get()
        {
            var sorgu = satisDAL.GetAllSatislar();
            return Ok(sorgu);
        }

        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult Get(int id)
        {
            var Satislar = satisDAL.GetSatislarById(id);
            if (Satislar == null)
                return NotFound();
            return Ok(Satislar);
        }

        [Authorize]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult Post(Satislar satis)
        {
            if (ModelState.IsValid)
            {
                var createdAraba = satisDAL.CreateSatis(satis);
                return CreatedAtRoute("DefaultApi", new { id = createdAraba.SatisID }, createdAraba);
            }
            else
                return BadRequest(ModelState);
        }

        [Authorize]
        [HttpPut]
        [ResponseType(typeof(Satislar))]
        public IHttpActionResult Put(int id, Satislar satis)
        {
            if (satisDAL.IsThereAnySatis(id) == false)
                return NotFound();
            else if (ModelState.IsValid == false)
                return BadRequest(ModelState);
            else
                return Ok(satisDAL.UpdateSatis(id, satis));
        }

        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            if (satisDAL.IsThereAnySatis(id) == false)
            {
                return NotFound();
            }
            else
            {
                satisDAL.DeleteSatis(id);
                return StatusCode(HttpStatusCode.NoContent);
            }
        }
    }
}