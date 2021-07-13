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
        UsuarioRepositorio repository = new UsuarioRepositorio();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Usuario> model = repository.ReadAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Usuario model)
        {
            repository.Create(model);
            return RedirectToAction("List");
        }
        
        public ActionResult Update(int Id)
        {
            Usuario model = repository.ReadById(Id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {

            repository.Update(model);
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("List");
        }
    }

}