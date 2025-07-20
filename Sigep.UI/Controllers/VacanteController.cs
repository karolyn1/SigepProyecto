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

        // Formulario para crear una nueva vacante
        public ActionResult CrearVacante()
        {
            return View();
        }

        // Formulario para editar una vacante existente
        public ActionResult EditarVacante(int id)
        {
            // Aquí en el futuro se podrá precargar el formulario con los datos de la vacante
            return View();
        }

        // Confirmación o formulario para desactivar vacante
        public ActionResult ConfirmarDesactivacion(int id)
        {
            return View();
        }
    }
}