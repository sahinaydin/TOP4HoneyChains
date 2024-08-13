using System.Web;
using System.Web.Mvc;

namespace TOP4HoneyChains.HoneyTestApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
