using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.BeekeeperApi.Controllers
{
	public class EducationLevelsController : ApiController
	{
		EducationLevelsConcrete elc = new EducationLevelsConcrete();

		public IEnumerable<EducationLevel> Get()
		{
			return elc.GetAll();
		}
		public IHttpActionResult Get(int id)
		{
			try
			{
				if (id != null)
				{
					return Ok(elc.GetById((int)id));
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
		public IHttpActionResult Post(EducationLevel model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					elc.Insert(model);
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
		public IHttpActionResult Put(EducationLevel model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					elc.Update(model);
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
					elc.Delete((int)id);
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
