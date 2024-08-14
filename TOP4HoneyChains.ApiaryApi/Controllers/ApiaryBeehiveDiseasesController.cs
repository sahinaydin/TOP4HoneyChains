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
    public class ApiaryBeehiveDiseasesController : ApiController
    {
        ApiaryBeehiveDiseasesConcrete dc = new ApiaryBeehiveDiseasesConcrete();

        public IEnumerable<ApiaryBeehiveDiseas> Get()
        {
            return dc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(dc.GetById((int)id));
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
        public IHttpActionResult Post(ApiaryBeehiveDiseas model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					dc.Insert(model);
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
        public IHttpActionResult Put(ApiaryBeehiveDiseas model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					dc.Update(model);
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
					dc.Delete((int)id);
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
