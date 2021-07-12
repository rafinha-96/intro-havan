using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using System.Data.Entity;

namespace Data
{
    public class HavanlabsContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public HavanlabsContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=HavanLabs;Integrated Security=True")
        {

        }
    }
}
