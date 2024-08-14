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
    public class BeehiveBuildingMaterialsController : ApiController
    {
        BeehiveBuildingMaterialsConcrete bmc = new BeehiveBuildingMaterialsConcrete();

        public IEnumerable<BeehiveBuildingMaterial> Get()
        {
            return bmc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(bmc.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(BeehiveBuildingMaterial model)
        {
            if (ModelState.IsValid)
            {
                bmc.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(BeehiveBuildingMaterial model)
        {
            if (ModelState.IsValid)
            {
                bmc.Update(model);
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
                bmc.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
