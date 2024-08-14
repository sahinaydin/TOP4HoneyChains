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
			try
			{
				if (id != null)
				{
					return Ok(bfp.GetById((int)id));
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
        public IHttpActionResult Post(ApiaryBeehivesFeedingProgram model)
        {
			try
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
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
        public IHttpActionResult Put(ApiaryBeehivesFeedingProgram model)
        {
			try
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
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
        public IHttpActionResult Delete(int id)
        {
			try
			{
				if (id != null)
				{
					bfp.Delete((int)id);
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
