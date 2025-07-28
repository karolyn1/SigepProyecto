using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult ListarEstudiante()
        {
            return View();
        }

        // GET: Estudiante/Details/5
        public ActionResult DetallesEstudiante(int id)
        {
            return View();
        }

        // GET: Estudiante/Create
        public ActionResult CrearEstudiante()
        {
            return View();
        }

        // POST: Estudiante/Create
        [HttpPost]
        public ActionResult CrearEstudiante(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Edit/5
        public ActionResult EditarEstudiante(int id)
        {
            return View();
        }

        // POST: Estudiante/Edit/5
        [HttpPost]
        public ActionResult EditarEstudiante(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante/Delete/5
        public ActionResult EliminarEstudiante(int id)
        {
            return View();
        }

        // POST: Estudiante/Delete/5
        [HttpPost]
        public ActionResult EliminarEstudiante(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiante mi perfil
        public ActionResult PerfilEstudiante()
        {
            return View();
        }

        // GET: Estudiante comunicados
        public ActionResult ComunicadosEstudiante()
        {
            return View();
        }
    }
}
