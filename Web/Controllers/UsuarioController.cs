using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {

        List<Usuario> Usuarios = new List<Usuario>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(Usuarios);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Create(Usuario model)
        {
            Usuarios.Add(model);

            return RedirectToAction("List");
        }
    }

}