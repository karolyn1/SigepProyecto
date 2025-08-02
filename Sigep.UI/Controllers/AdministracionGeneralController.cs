using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class AdministracionGeneralController : Controller
    {
        // GET: AdministracionGeneral
        public ActionResult GestionAdministracion()
        {
            return View();
        }


        // Usuarios
        public ActionResult EditarRolUsuario(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditarRol(int usuarioId, string rol)
        {
            // Aquí haces la actualización del rol...
            // ...

            // Luego rediriges a la pestaña adecuada:
            return RedirectToAction("GestionAdministracion", "AdministracionGeneral", new { tab = "usuarios" });
        }

        //public ActionResult CambiarEstadoUsuario(int id)
        //{
        //    return View();
        //}

        // Especialidades
        public ActionResult CrearEspecialidad()
        {
            return View();
        }
        public ActionResult EditarEspecialidad(int id)
        {
            // Como no tienes BD, mandás datos quemados al ViewBag
            if (id == 1) // ejemplo solo para id = 1
            {
                ViewBag.Id = id;
                ViewBag.Nombre = "Informática";
                ViewBag.Descripcion = "Desarrollo de software y redes";
            }
            else
            {
                ViewBag.Id = id;
                ViewBag.Nombre = "Especialidad";
                ViewBag.Descripcion = "";
            }

            return View();
        }


        // POST: Acción que procesa el formulario y redirige
        [HttpPost]
        public ActionResult EditarEspecialidad(int id, string nombreEspecialidad, string descripcionEspecialidad)
        {
            // Aquí harías la lógica para guardar cambios (ahora no tienes BD, así que no hace nada)

            // Redirigir a GestionAdministracion en la pestaña especialidades
            return RedirectToAction("GestionAdministracion", "AdministracionGeneral", new { tab = "especialidades" });
        }

        public ActionResult EliminarEspecialidad(int id)
        {
            TempData["Mensaje"] = $"Especialidad con ID {id} eliminada (demo).";
            return RedirectToAction("GestionAdministracion", new { tab = "especialidades" });
            return RedirectToAction("Index"); // O la acción que cargue tu panel general
        }


        // GET: AdministracionGeneral/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // Secciones
        public ActionResult CrearSeccion()
        {
            return View();
        }
        public ActionResult EditarSeccion(int id)
        {
            // Simulación de datos quemados para la sección con id = 1
            if (id == 1)
            {
                ViewBag.Id = id;
                ViewBag.Nombre = "SEC-01"; // Código o nombre de la sección
                ViewBag.Descripcion = "Descripción ejemplo para la sección SEC-01";
            }
            else
            {
                ViewBag.Id = id;
                ViewBag.Nombre = "Sección";
                ViewBag.Descripcion = "";
            }

            return View();
        }
        [HttpPost]
        public ActionResult EditarSeccion(int id, string nombreSeccion, string descripcionSeccion)
        {
            // Aquí podrías agregar la lógica para guardar los cambios
            // Como no tienes base de datos, solo simulamos la acción

            // Redirigir a la vista principal con la pestaña "secciones" activa
            return RedirectToAction("GestionAdministracion", "AdministracionGeneral", new { tab = "secciones" });
        }

        public ActionResult EliminarSeccion(int id)
        {
            // Aquí puedes agregar lógica simulada o simplemente redirigir.
            TempData["Mensaje"] = "Sección eliminada correctamente.";
            return RedirectToAction("GestionAdministracion", new { tab = "secciones" });

        }
      


        // GET: AdministracionGeneral/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministracionGeneral/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: AdministracionGeneral/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdministracionGeneral/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: AdministracionGeneral/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdministracionGeneral/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
