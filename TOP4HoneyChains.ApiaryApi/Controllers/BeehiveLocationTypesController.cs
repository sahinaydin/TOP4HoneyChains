using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.ApiaryApi.Controllers
{
    public class BeehiveLocationTypesController : ApiController
    {
        BeehiveLocationTypesConcrete blt = new BeehiveLocationTypesConcrete();

        public IEnumerable<BeehiveLocationType> Get()
        {
            return blt.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(blt.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(BeehiveLocationType model)
        {
            if (ModelState.IsValid)
            {
                blt.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(BeehiveLocationType model)
        {
            if (ModelState.IsValid)
            {
                blt.Update(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                blt.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
