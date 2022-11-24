using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EnsGlobal.DAL;
using System.Web.Http.Description;
using EnsGlobal.API.Attributes;

namespace EnsGlobal.API.Controllers
{
    public class ArabalarController : ApiController
    {
        ArabalarDAL arabaDAL = new ArabalarDAL();
        
        ////////////////////////////// DİPNOT //////////////////////////////////////////////
        
        //[HttpGet] -> Metotun başına yazıldığında metot ismi "Get" içermese dahi Get işlemini gerçekleştirir.
        //[NonAction] -> Metotun başına yazılır ise o metota erişilemez.

        ////////////////////////////// GET METOTLARI //////////////////////////////////////////////

        //public IEnumerable<Arabalar> Get()
        //{
        //    return arabaDAL.GetAllArabalar();
        //}

        //public HttpResponseMessage Get()
        //{
        //    var arabalar = arabaDAL.GetAllArabalar();
        //    return Request.CreateResponse(HttpStatusCode.OK, arabalar);

        //}

        [ResponseType(typeof(IEnumerable<Arabalar>))]
        public IHttpActionResult Get()
        {
            var arabalar = arabaDAL.GetAllArabalar();
            return Ok(arabalar);
        }

        //public Arabalar Get(int id)
        //{
        //    return arabaDAL.GetArabalarById(id);
        //}

        //public HttpResponseMessage Get(int id)
        //{
        //    var arabalar = arabaDAL.GetArabalarById(id);
        //    if(arabalar == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound, "Kayıt bulunamadı.");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, arabalar);
        //}

        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult Get(int id)
        {
            //try //SQL server yada runtime hataları, HttpStatusCode ile sayfa kaynağında görüntülenir.
            //{
            //    var arabalar = arabaDAL.GetArabalarById(id);
            //    if (arabalar == null)
            //    {
            //        return NotFound();
            //    }
            //    return Ok(arabalar);
            //}
            //catch (Exception e)
            //{
            //    HttpResponseMessage errorResponse = new HttpResponseMessage(HttpStatusCode.BadGateway);
            //    errorResponse.ReasonPhrase = e.Message;
            //    throw;
            //}

            var arabalar = arabaDAL.GetArabalarById(id);
            if (arabalar == null)
                return NotFound();
            return Ok(arabalar);
        }

        ////////////////////////////// POST METOTLARI //////////////////////////////////////////////

        //public Arabalar Post(Arabalar araba)
        //{
        //    return arabaDAL.CreateAraba(araba);
        //}

        //public HttpResponseMessage Post(Arabalar araba)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var createdAraba = arabaDAL.CreateAraba(araba);
        //        return Request.CreateResponse(HttpStatusCode.Created, createdAraba);
        //    }
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }
        //}

        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult Post(Arabalar araba)
        {
            if (ModelState.IsValid)
            {
                var createdAraba = arabaDAL.CreateAraba(araba);
                return CreatedAtRoute("DefaultApi", new { id = createdAraba.ArabaID }, createdAraba);
            }
            else
                return BadRequest(ModelState);
        }

        ////////////////////////////// PUT METOTLARI //////////////////////////////////////////////

        //public Arabalar Put(int id, Arabalar araba)
        //{
        //    return arabaDAL.UpdateAraba(id, araba);
        //}

        //public HttpResponseMessage Put(int id, Arabalar araba)
        //{
        //    if (arabaDAL.IsThereAnyAraba(id) == false)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Kayıt bulunamadı.");
        //    }
        //    else if (ModelState.IsValid == false)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, arabaDAL.UpdateAraba(id, araba));
        //    }
        //}

        [ResponseType(typeof(Arabalar))]
        public IHttpActionResult Put(int id, Arabalar araba)
        {
            if (arabaDAL.IsThereAnyAraba(id) == false)
                return NotFound();
            else if (ModelState.IsValid == false)
                return BadRequest();
            else
                return Ok(arabaDAL.UpdateAraba(id, araba));
        }

        ////////////////////////////// DELETE METOTLARI //////////////////////////////////////////////

        //public void Delete(int id)
        //{
        //    arabaDAL.DeleteAraba(id);
        //}

        //public HttpResponseMessage Delete(int id)
        //{
        //    if (arabaDAL.IsThereAnyAraba(id) == false)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Kayıt bulunamadı.");
        //    }
        //    else
        //    {
        //        arabaDAL.DeleteAraba(id);
        //        return Request.CreateResponse(HttpStatusCode.NoContent);
        //    }
        //}

        // TODO: Delete fonksiyonunu düzenle.
        public IHttpActionResult Delete(int id)
        {
            if (arabaDAL.IsThereAnyAraba(id) == false)
                return NotFound();
            else
            {
                arabaDAL.DeleteAraba(id);
                return StatusCode(HttpStatusCode.NoContent);
            }
        }
    }
}
