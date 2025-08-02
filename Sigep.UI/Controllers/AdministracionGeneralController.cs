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

        public ActionResult CambiarEstadoUsuario(int id)
        {
            return View();
        }

        // Especialidades
        public ActionResult CrearEspecialidad()
        {
            return View();
        }
        public ActionResult EditarEspecialidad(int id)
        {
            return View();
        }
        public ActionResult EliminarEspecialidad(int id)
        {
            return View();
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
            return View();
        }
        public ActionResult EliminarSeccion(int id)
        {
            return View();
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
