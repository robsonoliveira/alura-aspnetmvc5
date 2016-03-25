using System.Web.Mvc;
using alura_aspnetmvc5.DAO;

namespace alura_aspnetmvc5.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            ViewBag.Categorias = new CategoriasDAO().Lista();

            return View();
        }
    }
}