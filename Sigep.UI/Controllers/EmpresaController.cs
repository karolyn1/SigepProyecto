using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class EmpresaController : Controller
    {
        
        // GET: Empresa/ListaEmpresas
        public ActionResult ListaEmpresas()
        {
            return View(); // Retorna la vista con el listado
        }

        // GET: Empresa/Agregar
        public ActionResult CrearEmpresa()
        {
            return View(); // Retorna el formulario de agregar empresa
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult CrearEmpresa(FormCollection collection)
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

        // GET: Empresa/Edit/5
        public ActionResult EditarEmpresa(int id)
        {
            return View();
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult EditarEmpresa(int id, FormCollection collection)
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

        // GET: Empresa/Delete/5
        public ActionResult EliminarEmpresa(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult EliminarEmpresa(int id, FormCollection collection)
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
