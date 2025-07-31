using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class PracticasController : Controller
    {
        // GET: Practicas
        public ActionResult VacantesEstudiantes()
        {
            return View();
        }
    }
}