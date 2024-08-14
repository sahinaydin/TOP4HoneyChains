using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.HoneyProductionApi.Controllers
{
    public class ApiaryHoneyProductionsController : ApiController
    {
        ApiaryHoneyProductionsConcrete hpc = new ApiaryHoneyProductionsConcrete();

        public List<ApiaryHoneyProduction> Get()
        {
            return hpc.GetAll();
        }
        public IHttpActionResult Get(int? id)
        {
            try
            {
                if (id != null)
                {
                    return Ok(hpc.GetById((int)id));
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
        public IHttpActionResult Post(ApiaryHoneyProduction model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hpc.Insert(model);
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
        public IHttpActionResult Put(ApiaryHoneyProduction model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hpc.Update(model);
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
                    hpc.Delete((int)id);
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
