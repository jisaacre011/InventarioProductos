using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace EntityFramework.Datos
{
  
    public class Conexion : DbContext
    {
       
        public Conexion() : base("JREYES\\SQLEXPRESS")
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
