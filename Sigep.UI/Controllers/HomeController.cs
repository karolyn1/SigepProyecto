using Sigep.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
     
        [HttpGet]

        public ActionResult Registro() { 
        
            return View();
        }
       
        [HttpGet]

        public ActionResult Login()
        {
            ViewBag.Mensaje = Session["MensajeError"];
            Session["MensajeError"] = null; 
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            var coordinador = "118810955";
            var nombreCoordinador = "Ariana";
            var estudiante = "305550650";
            var nombreEstudiante = "Johnny";
            var egresado = "987654321";
            var nombreEgresado = "Karolyn";
            var profesor = "112233445";
            var nombreProfesor = "Jean Pool";
            var contrasenna = "Hola123456";

            bool credencialesValidas = false;

            if (usuario.cedula == coordinador && contrasenna == usuario.contrasenna)
            {
                Session["rol"] = 1;
                Session["nombre"] = nombreCoordinador;
                credencialesValidas = true;
            }
            else if (usuario.cedula == estudiante && contrasenna == usuario.contrasenna)
            {
                Session["rol"] = 2;
                Session["nombre"] = nombreEstudiante;
                credencialesValidas = true;
            }
            else if (usuario.cedula == egresado && contrasenna == usuario.contrasenna)
            {
                Session["rol"] = 3;
                Session["nombre"] = nombreEgresado;
                credencialesValidas = true;
            }
            else if (usuario.cedula == profesor && contrasenna == usuario.contrasenna)
            {
                Session["rol"] = 4;
                Session["nombre"] = nombreProfesor;
                credencialesValidas = true;
            }

            if (!credencialesValidas)
            {
                TempData["SwalError"] = "Lo sentimos, el usuario no se encuentra registrado. Por favor, crea una cuenta";
                return View("Login", usuario);
            }

          
            return RedirectToAction("Index");
        }
       
        [HttpPost] 
        public ActionResult Registro(Usuario usuario)
        {
            TempData["SwalSuccess"] = "Usuario registrado correctamente";
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }


        [HttpGet]

        public ActionResult RecuperarAcceso()
        {
            return View();
        }

        [HttpPost]

        public ActionResult RecuperarAcceso(Usuario usuario)
        {
            var cedula = "118810955";
            if (usuario.cedula == cedula)
            {
                TempData["SwalSuccess"] = "Hemos enviado un link de recuperación al correo ari*****@gmail.com";
                return RedirectToAction("Login");
            } else
            {
                TempData["SwalError"] = "La cédula proporcionada no se encuentra registrada";
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CerrarSesion()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}