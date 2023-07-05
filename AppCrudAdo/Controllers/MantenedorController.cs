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
        // GET: Mantenedor
        public ActionResult Listar()
        {
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }
    }
}