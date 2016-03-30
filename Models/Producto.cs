using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTransacciones.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
