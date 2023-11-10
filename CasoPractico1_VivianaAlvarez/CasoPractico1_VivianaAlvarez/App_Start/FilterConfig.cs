using System.Web;
using System.Web.Mvc;

namespace CasoPractico1_VivianaAlvarez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
