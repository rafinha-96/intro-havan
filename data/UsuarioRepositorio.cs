using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepositorio

    {
        //create
        public void Create(Usuario model)
        {
            using (HavanlabsContext context = new HavanlabsContext())
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
            }
        }
        //read all
        public List<Usuario> ReadAll()
        {
            using (HavanlabsContext context = new HavanlabsContext())
            {
                return context.Usuarios.ToList();
            }

        }
        //ReadById
        public Usuario ReadById(int Id)
        {
            using (HavanlabsContext context = new HavanlabsContext())
            {
                return context.Usuarios.Find(Id);
            }
        }
        //Update
        public void Update(Usuario model)
        {
            using (HavanlabsContext context = new HavanlabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        //delete
        public void Delete(int id)
        {
            using(HavanlabsContext context = new HavanlabsContext())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
        }
    }
}
