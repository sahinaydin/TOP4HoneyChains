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
    public class BeekeepingTypesController : ApiController
    {
        BeekeepingTypesConcrete btc = new BeekeepingTypesConcrete();

        public IEnumerable<BeekeepingType> Get()
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
				return BadRequest(e.Message);
			}
		}
        public IHttpActionResult Post(BeekeepingType model)
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
        public IHttpActionResult Put(BeekeepingType model)
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
        public IHttpActionResult Delete(int? id)
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
