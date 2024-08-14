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
    public class BeehiveDiseasesController : ApiController
    {
        BeehiveDiseasesConcrete bdc = new BeehiveDiseasesConcrete();

        public IEnumerable<BeehiveDiseas> Get()
        {
            return bdc.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(bdc.GetById((int)id));
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
        public IHttpActionResult Post(BeehiveDiseas model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					bdc.Insert(model);
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
        public IHttpActionResult Put(BeehiveDiseas model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					bdc.Update(model);
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
					bdc.Delete((int)id);
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
