using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class EgresadoController : Controller
    {
        // GET: Egresado
        public ActionResult Index()
        {
            return View();
        }

        // GET: Egresado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Egresado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Egresado/Create
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

        // GET: Egresado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Egresado/Edit/5
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

        // GET: Egresado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Egresado/Delete/5
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
