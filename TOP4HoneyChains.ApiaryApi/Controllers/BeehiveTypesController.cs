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
	public class BeehiveTypesController : ApiController
	{
		BeehiveTypesConcrete btc = new BeehiveTypesConcrete();

		public IEnumerable<BeehiveType> Get()
		{
			return btc.GetAll();
		}
		public IHttpActionResult Get(int id)
		{
			try
			{
				if (id != null)
				{
					return Ok(btc.GetById((int)id));
				}
				else
				{
					return NotFound();
				}
			}
			catch (Exception e)
			{
				return BadRequest(ModelState);
			}
		}
		public IHttpActionResult Post(BeehiveType model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					btc.Insert(model);
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
		public IHttpActionResult Put(BeehiveType model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					btc.Update(model);
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
					btc.Delete((int)id);
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
