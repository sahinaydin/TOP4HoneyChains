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
    public class BeehiveLocationTypesController : ApiController
    {
        BeehiveLocationTypesConcrete blt = new BeehiveLocationTypesConcrete();

        public IEnumerable<BeehiveLocationType> Get()
        {
            return blt.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(blt.GetById((int)id));
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
        public IHttpActionResult Post(BeehiveLocationType model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					blt.Insert(model);
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
        public IHttpActionResult Put(BeehiveLocationType model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					blt.Update(model);
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
					blt.Delete((int)id);
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
