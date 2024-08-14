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
    public class HoneyTypesController : ApiController
    {
        HoneyTypesConcrete tc = new HoneyTypesConcrete();

        public List<HoneyType> Get()
        {
            return tc.GetAll();
        }
        public IHttpActionResult Get(int? id)
        {
            try
            {
                if (id != null)
                {
                    return Ok(tc.GetById((int)id));
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
        public IHttpActionResult Post(HoneyType model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    tc.Insert(model);
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
        public IHttpActionResult Put(HoneyType model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    tc.Update(model);
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
                    return Ok(tc.GetById((int)id));
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
