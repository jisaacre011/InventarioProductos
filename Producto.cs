using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace EntityFramework
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int id { get; set; }

        [Column("Producto")]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
        public int Stop { get; set; }
    }
}
