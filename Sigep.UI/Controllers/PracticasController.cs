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
        [HttpGet]
        public ActionResult VacantesEstudiantes()
        {
            return View();
        }


        [HttpGet]

        public ActionResult VisualizacionPostulacion()
        {
            return View();
        }


    }
}