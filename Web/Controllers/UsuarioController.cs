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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Usuario> model = new List<Usuario>();
            using (var context = new HavanlabsContext())
            {
                model = context.Usuarios.ToList();
            }
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Usuario model)
        {
            using (var context = new HavanlabsContext())
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
        
        public ActionResult Update(int Id)
        {
            Usuario model = new Usuario();
            using (var context = new HavanlabsContext())
            {
                model = context.Usuarios.Find(Id);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Usuario model)
        {
            using (var context = new HavanlabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            using (var context = new HavanlabsContext())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }

}