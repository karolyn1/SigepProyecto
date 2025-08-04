using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Services
{
    public class Filters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuario = HttpContext.Current.Session["Nombre"];

            if (usuario == null)
            {
                var controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
                var action = filterContext.ActionDescriptor.ActionName;

                if (!(controller == "Home" && (action == "Login" || action == "Registro")))
                {
                    filterContext.Controller.TempData["MensajeError"] = "Acceso no autorizado. Por favor, inicie sesión.";
                    filterContext.Result = new RedirectResult("~/Home/Login");
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
  
}