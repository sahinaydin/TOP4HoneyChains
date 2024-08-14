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
            if (ModelState.IsValid)
            {
                return Ok(ac.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }

        public IHttpActionResult Post(Apiary model)
        {
            if (!ModelState.IsValid)
            {
                ac.Insert(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public IHttpActionResult Put(Apiary model)
        {
            if (!ModelState.IsValid)
            {
                ac.Update(model);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                ac.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }   
    }
}
