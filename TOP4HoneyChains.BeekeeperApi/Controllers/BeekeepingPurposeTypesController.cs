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
    public class BeekeepingPurposeTypesController : ApiController
    {
        BeekeepingPurposeTypesConcrete bpt = new BeekeepingPurposeTypesConcrete();

        public IEnumerable<BeekeepingPurposeType> Get()
        {
            return bpt.GetAll();
        }
        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(bpt.GetById((int)id));
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
        public IHttpActionResult Post(BeekeepingPurposeType model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					bpt.Insert(model);
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
        public IHttpActionResult Put(BeekeepingPurposeType model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					bpt.Update(model);
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
        public IHttpActionResult Delete(int?a id)
        {
			try
			{
				if (id != null)
				{
					bpt.Delete((int)id);
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
