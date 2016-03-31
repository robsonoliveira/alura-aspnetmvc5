using alura_aspnetmvc5.Filtros;
using System.Web;
using System.Web.Mvc;

namespace alura_aspnetmvc5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AutorizacaoFilterAttribute());
        }
    }
}
