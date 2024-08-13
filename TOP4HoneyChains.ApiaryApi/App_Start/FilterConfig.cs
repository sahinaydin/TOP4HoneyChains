using System.Web;
using System.Web.Mvc;

namespace TOP4HoneyChains.ApiaryApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
