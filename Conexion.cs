using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // <--- OBLIGATORIO: Esto permite usar Entity Framework

namespace EntityFramework.Datos
{
    // 1. Debe ser PUBLIC para que el Formulario la vea
    // 2. Debe heredar de ": DbContext" para que funcione el CRUD
    public class Conexion : DbContext
    {
        // Este constructor busca la cadena de conexión en el archivo App.config
        public Conexion() : base("JREYES\\SQLEXPRESS")
        {
        }

        // Esta línea mapea tu clase "Producto" con la tabla de la base de datos
        public DbSet<Producto> Productos { get; set; }
    }
}