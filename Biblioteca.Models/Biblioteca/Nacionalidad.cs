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
    [Table("Nacionalidad", Schema = "Biblioteca")]
    public class Nacionalidad
    {
        public Nacionalidad()
        { 
            this.Autores = new HashSet<Autor>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Abrevitura")]
        public string Abreviatura{ get; set; }
        [Required]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

      

        public virtual ICollection<Autor> Autores { get; set; }
    }
}
