using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppCrudAdo.Datos;
using AppCrudAdo.Models;

namespace AppCrudAdo.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();

        public ActionResult Listar ()
        {
            var resultado = _ContactoDatos.Listar();
            return View(resultado);
        }

        public ActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(Contacto oContacto)
        {
            var resultado = _ContactoDatos.Guardar(oContacto);

            if(resultado)
            {
                return RedirectToAction("Listar");
            } else
            {
                return View();
            }
        }

    }
}