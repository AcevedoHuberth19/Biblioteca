using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Biblioteca
{
    public class Libro
    {

        public Libro()
        {
            this.DetalleLibros = new HashSet<DetalleLibro>();
        }
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Código")]
        [Required]
        public string Codigo { get; set; }

        [Display(Name = "Nombre de libro")]
        [Required]
        public string Nombre { get; set; }

        [Required]
        [DisplayName("Fecha de publicación")]
        [DataType(DataType.Date)]
        public DateTime FechaDePublicacion { get; set; }


        public virtual ICollection<DetalleLibro> DetalleLibros { get; set; }

    }
}
