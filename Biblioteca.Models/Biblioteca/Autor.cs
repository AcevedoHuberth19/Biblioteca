using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models.Biblioteca
{
    [Table("Autor", Schema = "Biblioteca")]
    public class Autor
    {

        public Autor() 
        {
            this.DetalleLibros = new HashSet<DetalleLibro>();
        }  
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nombres")]
        public string Nombres { get; set; }
        [Required]
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [DisplayName("Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime FechaDeNacimiento { get; set; }
        public int NacionalidadId { get; set; }

        public virtual Nacionalidad Nacionalidad { get; set; }

        public virtual ICollection<DetalleLibro> DetalleLibros { get; set; }
    }
}
