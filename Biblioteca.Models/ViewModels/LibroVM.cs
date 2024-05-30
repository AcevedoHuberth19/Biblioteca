using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.ViewModels
{
    public class LibroVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Libro { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaDePublicacion { get; set; }
        public List<DetalleLibroVM> DetalleLibros { get; set; }

        public void Add(LibroVM libro)
        {
            throw new NotImplementedException();
        }
    }
}