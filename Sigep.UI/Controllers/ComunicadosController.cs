using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class ComunicadosController : Controller
    {
        
        // GET: Estudiante comunicados
        public ActionResult Comunicados()
        {
            if (Session["rol"] == null)
            {
  
                return RedirectToAction("Login", "Home");
            }

            return View();
        }
    }
}
