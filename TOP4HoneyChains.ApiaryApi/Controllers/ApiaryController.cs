using Antlr.Runtime.Tree;
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
    public class ApiaryController : ApiController
    {
        ApiaryConcrete  ac = new ApiaryConcrete();

        public IEnumerable<Apiary> Get()
        {
            return ac.GetAll(); 
        }

        public IHttpActionResult Get(int id)
        {
			try
			{
				if (id != null)
				{
					return Ok(ac.GetById((int)id));
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

        public IHttpActionResult Post(Apiary model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					ac.Insert(model);
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

        public IHttpActionResult Put(Apiary model)
        {
			try
			{
				if (ModelState.IsValid)
				{
					ac.Update(model);
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
					ac.Delete((int)id);
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
