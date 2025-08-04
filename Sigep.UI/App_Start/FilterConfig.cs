using Sigep.UI.Services;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Filters());
            filters.Add(new HandleErrorAttribute());
          
        }
    }
}
