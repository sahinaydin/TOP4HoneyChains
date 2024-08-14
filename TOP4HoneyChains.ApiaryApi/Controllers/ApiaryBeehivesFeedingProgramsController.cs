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
    public class ApiaryBeehivesFeedingProgramsController : ApiController
    {
        ApiaryBeehivesFeedingProgramsConcrete bfp = new ApiaryBeehivesFeedingProgramsConcrete();

        public IEnumerable<ApiaryBeehivesFeedingProgram> Get()
        {
            return bfp.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(bfp.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(ApiaryBeehivesFeedingProgram model)
        {
            if (ModelState.IsValid)
            {
                bfp.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        public IHttpActionResult Put(ApiaryBeehivesFeedingProgram model)
        {
            if (ModelState.IsValid)
            {
                bfp.Update(model);
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
                bfp.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
