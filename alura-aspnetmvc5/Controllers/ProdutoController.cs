using System.Web.Mvc;
using alura_aspnetmvc5.DAO;
using alura_aspnetmvc5.Models;
using System;
namespace alura_aspnetmvc5.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        [Route("produtos", Name = "ListaProdutos")]
        public ActionResult Index()
        {
            var dao = new ProdutosDAO();
            var produtos = dao.Lista();
            return View(produtos);
        }

        public ActionResult Form()
        {
            ViewBag.Categorias = new CategoriasDAO().Lista();
            ViewBag.Produto = new Produto();

            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {

            // CUSTOMIZANDO REGRAS DE VALIDAÇÃO
            var IdComRegraDeValorMinimo = 1;

            if (produto.CategoriaId.Equals(IdComRegraDeValorMinimo) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.ValorMinimo", "Produto de Categoria " + IdComRegraDeValorMinimo + " com valor abaixo de 100,00.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Categorias = new CategoriasDAO().Lista();
                ViewBag.Produto = produto;
                return View("Form");

            }
            new ProdutosDAO().Adiciona(produto);
            return RedirectToAction("Index", "Produto");
        }

        [Route("produtos/{id}", Name ="VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            var produto = new ProdutosDAO().BuscaPorId(id);
            ViewBag.Produto = produto;
            return View();
        }
    }
}