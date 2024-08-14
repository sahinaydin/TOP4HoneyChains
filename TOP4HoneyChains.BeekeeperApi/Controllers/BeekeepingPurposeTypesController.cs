using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.BeekeeperApi.Controllers
{
    public class BeekeepingPurposeTypesController : ApiController
    {
        BeekeepingPurposeTypesConcrete bpt = new BeekeepingPurposeTypesConcrete();

        public IEnumerable<BeekeepingPurposeType> Get()
        {
            return bpt.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(bpt.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(BeekeepingPurposeType model)
        {
            if (!ModelState.IsValid)
            {
                bpt.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(BeekeepingPurposeType model)
        {
            if (!ModelState.IsValid)
            {
                bpt.Update(model);
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
                bpt.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
