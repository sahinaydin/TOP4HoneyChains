
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TOP4HoneyChains.Domain.Helpers;
using TOP4HoneyChains.Entities;

namespace TOP4HoneyChains.WebApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class BeekeepersController : Controller
    {
        const string baseurl = @"https://beekeepersapi.intalalab.net/";
        const string api = @"api/Beekeepers";

        private string BuildApiUrl(string baseUrl, string api)
        {
            return baseUrl + api;
        }

        // GET: Beekeepers
        public async Task<ActionResult> Index()
        {
            var beekeepers = new List<Beekeeper>();
            beekeepers = await RequestHelper.GetAsync<List<Beekeeper>>(BuildApiUrl(baseurl, api));
            return View(beekeepers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Beekeeper beekeeper)
        {

            return View();
        }

    }
}