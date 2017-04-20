using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
