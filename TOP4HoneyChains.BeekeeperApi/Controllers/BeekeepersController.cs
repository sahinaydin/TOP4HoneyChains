﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Concrete;

namespace TOP4HoneyChains.BeekeeperApi.Controllers
{
    public class BeekeepersController : ApiController
    {
        BeekeepersConcrete bc = new BeekeepersConcrete();

        public IEnumerable<Beekeeper> Get()
        {
            return bc.GetAll();
        }
        public IHttpActionResult Get(string identitynumber)
        {
			try
			{
				if (identitynumber != null)
				{
					return Ok(bc.GetByIdentityNumber(identitynumber));
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

		public IHttpActionResult Post(Beekeeper model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					bc.Insert(model);
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
		public IHttpActionResult Put(Beekeeper model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					bc.Update(model);
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
					bc.Delete((int)id);
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
