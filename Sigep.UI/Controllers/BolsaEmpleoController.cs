using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sigep.UI.Controllers
{
    public class BolsaEmpleoController : Controller
    {
        // GET: BolsaEmpleo
        public ActionResult Vacantes()
        {
            return View();
        }
    }
}