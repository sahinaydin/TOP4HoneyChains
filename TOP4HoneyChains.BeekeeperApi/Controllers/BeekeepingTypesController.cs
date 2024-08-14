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
    public class BeekeepingTypesController : ApiController
    {
        BeekeepingTypesConcrete btc = new BeekeepingTypesConcrete();

        public IEnumerable<BeekeepingType> Get()
        {
            return btc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(btc.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(BeekeepingType model)
        {
            if (ModelState.IsValid)
            {
                btc.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(BeekeepingType model)
        {
            if (ModelState.IsValid)
            {
                btc.Update(model);
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
                btc.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
