using System;
using System.ComponentModel.DataAnnotations; // <--- NECESARIO PARA [Key]
using System.ComponentModel.DataAnnotations.Schema; // <--- NECESARIO PARA [Table] y [Column]

namespace EntityFramework
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int id { get; set; }

        // CAMBIO IMPORTANTE: 
        // Como la clase se llama "Producto", la propiedad no puede llamarse igual.
        // Le ponemos "Nombre" en C# pero le decimos que en SQL busque la columna "Producto"
        [Column("Producto")]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
        public int Stop { get; set; }
    }
}