﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class CoordinadorController : Controller
    {
        // GET: Coordinador
        public ActionResult Index()
        {
            return View();
        }

        // GET: Coordinador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coordinador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coordinador/Create
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

        // GET: Coordinador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coordinador/Edit/5
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

        // GET: Coordinador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coordinador/Delete/5
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


        // Vista con la lista de egresados para el coordinador (con acciones de editar/desactivar)
        public ActionResult ListaEgresados()
        {
            return View();
        }

      
     
    }
}
