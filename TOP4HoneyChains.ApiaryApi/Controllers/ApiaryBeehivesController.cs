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
    public class ApiaryBeehivesController : ApiController
    {
        ApiaryBeehivesConcrete abc = new ApiaryBeehivesConcrete();

        public IEnumerable<ApiaryBeehive> Get()
        {
            return abc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(abc.GetById((int)id));
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
        public IHttpActionResult Post(ApiaryBeehive model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					abc.Insert(model);
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
        public IHttpActionResult Put(ApiaryBeehive model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					abc.Update(model);
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
					abc.Delete((int)id);
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
