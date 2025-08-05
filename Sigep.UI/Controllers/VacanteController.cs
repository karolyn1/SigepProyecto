using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class VacanteController : Controller
    {
        // GET: Lista de Vacantes para los egresados
        public ActionResult ListaVacantesEgresado()
        {
            return View();
        }

        //detalle de la vacante para los egresados
        public ActionResult DetalleVacanteEgresado()
        {
            return View();
        }

      

        // Vista con la lista de vacantes para el coordinador (con acciones de editar/desactivar)
        public ActionResult ListaVacanteCoordinador()
        {
            return View();
        }

    }
}