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
    public class HoneyDistributionTypesController : ApiController
    {
        HoneyDistributionTypesConcrete dtc = new HoneyDistributionTypesConcrete();

        public List<HoneyDistributionType> Get()
        {
            return dtc.GetAll();
        }
        public IHttpActionResult Get(int? id)
        {
            try
            {
                if (id != null)
                {
                    return Ok(dtc.GetById((int)id));
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
        public IHttpActionResult Post (HoneyDistributionType model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dtc.Insert(model);
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
        public IHttpActionResult Put(HoneyDistributionType model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dtc.Update(model);
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
                    return Ok(dtc.GetById((int)id));
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
