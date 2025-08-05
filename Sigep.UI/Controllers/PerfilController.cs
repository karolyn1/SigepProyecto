using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class PerfilController : Controller
    {

       
        // GET:  mi perfil
        public ActionResult MiPerfil()
        {
            if (Session["rol"] == null)
            {
                // Redirige a login o página principal si no hay sesión de rol
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

    }
}
