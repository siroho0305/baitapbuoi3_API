using System.Web;
using System.Web.Mvc;

namespace HoNguyenThanhPhong_5951071074
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
