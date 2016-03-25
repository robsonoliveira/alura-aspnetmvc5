using System.Web.Mvc;
using alura_aspnetmvc5.DAO;
using alura_aspnetmvc5.Models;
using System;
namespace alura_aspnetmvc5.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var dao = new ProdutosDAO();
            var produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Categorias = new CategoriasDAO().Lista();
            return View();
        }
        
        [HttpPost]
        public ActionResult Adiciona(Produto produto) {
             new ProdutosDAO().Adiciona(produto);
            return RedirectToAction("Index", "Produto");
        }
    }
}