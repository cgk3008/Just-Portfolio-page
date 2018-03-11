using System.Web;
using System.Web.Mvc;

namespace Cliff_Single_Portfolio_Page
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
