using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Biblioteca
{
    [Table("DetalleLibro", Schema = "Biblioteca")]
    public class DetalleLibro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LibroId { get; set; }
        [Required]
        public string AutorId { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Libro Libro { get; set; }
    }
}
