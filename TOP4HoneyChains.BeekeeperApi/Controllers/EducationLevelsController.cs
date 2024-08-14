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
            if (ModelState.IsValid)
            {
                return Ok(elc.GetById(id));
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult Post(EducationLevel model)
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
        public IHttpActionResult Put(EducationLevel model)
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
        public IHttpActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                elc.Delete(id);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
