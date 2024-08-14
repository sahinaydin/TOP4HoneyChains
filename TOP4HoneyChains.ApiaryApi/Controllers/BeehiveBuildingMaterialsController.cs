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
	public class BeehiveBuildingMaterialsController : ApiController
	{
		BeehiveBuildingMaterialsConcrete bmc = new BeehiveBuildingMaterialsConcrete();

		public IEnumerable<BeehiveBuildingMaterial> Get()
		{
			return bmc.GetAll();
		}
		public IHttpActionResult Get(int id)
		{
			try
			{
				if (id != null)
				{
					return Ok(bmc.GetById((int)id));
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
		public IHttpActionResult Post(BeehiveBuildingMaterial model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					bmc.Insert(model);
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
		public IHttpActionResult Put(BeehiveBuildingMaterial model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					bmc.Update(model);
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
					bmc.Delete((int)id);
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
