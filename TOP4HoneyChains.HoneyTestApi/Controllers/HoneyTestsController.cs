using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.HoneyTestApi.Controllers
{
    public class HoneyTestsController : ApiController
    {
        HoneyTestsConcrete htc = new HoneyTestsConcrete();

        public List<HoneyTest> Get()
        {
            return htc.GetAll();
        }
        public IHttpActionResult Get(int? id)
        {
            try
            {
                if (id != null)
                {
                    return Ok(htc.GetById((int)id));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        public IHttpActionResult Post(HoneyTest model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    htc.Insert(model);
                    return Ok();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        public IHttpActionResult Put(HoneyTest model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    htc.Update(model);
                    return Ok();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        public IHttpActionResult Delete(int? id)
        {
            try
            {
                if (id != null)
                {
                    htc.Delete((int)id);
                    return Ok();
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
