using System;
using Proyecto4_Diplomado_Web_MVC_UASD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4_Diplomado_Web_MVC_UASD.Controllers
{
    public class HomeController : Controller
    {
        private string cedula;
        private string telefono;
        private string correo;

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioPersona()
        {
            return View();
        }

        public ActionResult CargarDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();
            LibroPersonas libro = new LibroPersonas();
            libro.Grabar(nombre, cedula, telefono, correo);

            return View();
        }
        public ActionResult ListadoPersonas()
        {
            LibroPersonas libro = new LibroPersonas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;

            return View();
        }
    }
}