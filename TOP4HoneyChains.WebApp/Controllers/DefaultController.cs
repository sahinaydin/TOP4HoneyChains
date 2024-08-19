using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace TOP4HoneyChains.WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Roles.CreateRole("Administrator");
            Roles.CreateRole("Beekeeper");
            Roles.CreateRole("Packager");
            Roles.CreateRole("HoneyTester");

            MembershipCreateStatus createStatus;
            Membership.CreateUser("admin", "admin123", "admin@top4honeychains.net", "question", "answer", true, null, out createStatus);
            Roles.AddUserToRole("admin", "Administrator");
            return View();
        }
    }
}