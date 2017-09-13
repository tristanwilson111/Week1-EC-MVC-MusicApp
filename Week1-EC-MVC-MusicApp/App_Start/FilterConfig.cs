using System.Web;
using System.Web.Mvc;

namespace Week1_EC_MVC_MusicApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
