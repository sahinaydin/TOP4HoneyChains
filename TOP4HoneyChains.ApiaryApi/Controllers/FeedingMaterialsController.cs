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
    public class FeedingMaterialsController : ApiController
    {
        FeedingMaterialsConcrete fmc = new FeedingMaterialsConcrete();

        public IEnumerable<FeedingMaterial> Get()
        {
            return fmc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(fmc.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(FeedingMaterial model)
        {
            if (ModelState.IsValid)
            {
                fmc.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(FeedingMaterial model)
        {
            if (ModelState.IsValid)
            {
                fmc.Update(model);
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
                fmc.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
