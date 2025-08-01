﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class PerfilController : Controller
    {

        // GET: Formulario para los usuarios para completar perfil
        public ActionResult CompletarPerfil()
        {
            return View();
        }

        // GET: editar perfil de usuario
        public ActionResult ActualizarPerfil(int id)
        {
            return View();
        }


        // GET: Formulario para los los encargados de los estudiantes
        public ActionResult FormularioEncargado()
        {
            return View();
        }

        // GET: Perfil
        public ActionResult Index()
        {
            return View();
        }

        // GET: Perfil/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perfil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfil/Create
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

        // GET: Perfil/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Perfil/Edit/5
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

        // GET: Perfil/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perfil/Delete/5
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
        // GET:  mi perfil
        public ActionResult MiPerfil()
        {
            if (Session["rol"] == null)
            {
                // Redirige a login o página principal si no hay sesión de rol
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

    }
}
