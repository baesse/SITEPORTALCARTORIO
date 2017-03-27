using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalDesktop.Controllers
{
    public class JustificativaController : Controller
    {
        // GET: Justificativa
        public ActionResult Redirecionar()
        {
            return View("Justificativa");
        }
    }
}