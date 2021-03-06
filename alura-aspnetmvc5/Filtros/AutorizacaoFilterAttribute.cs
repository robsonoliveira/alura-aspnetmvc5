﻿using System.Web.Mvc;
using System.Web.Routing;

namespace alura_aspnetmvc5.Filtros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["usuarioLogado"];

            if(usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index" }));
            }
            //base.OnActionExecuting(filterContext);
        }
    }
}