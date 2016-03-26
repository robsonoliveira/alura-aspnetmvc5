using System.Web.Mvc;
using alura_aspnetmvc5.DAO;
using alura_aspnetmvc5.Models;

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

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            new CategoriasDAO().Adiciona(categoria);
            return RedirectToAction("Index","Categoria");
        }
    }
}