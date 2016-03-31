using alura_aspnetmvc5.DAO;
using System.Web.Mvc;

namespace alura_aspnetmvc5.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public ActionResult Autentica(string login, string senha) {
            UsuariosDAO dao = new UsuariosDAO();
            var usuario = dao.Busca(login, senha);
            if(usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }

}