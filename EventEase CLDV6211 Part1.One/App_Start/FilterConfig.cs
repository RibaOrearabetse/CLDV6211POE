using System.Web;
using System.Web.Mvc;

namespace EventEase_CLDV6211_Part1.One
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
