using System.Web;
using System.Web.Mvc;

namespace ITMO._124_16.Leontev.ASP.NET.ExamStudentsAPP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
