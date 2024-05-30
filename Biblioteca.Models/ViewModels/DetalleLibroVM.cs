using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.ViewModels
{
    public class DetalleLibroVM
    {
        public string Nombres {  get; set; }

        public string Apellidos { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaDeNacimiento { get; set; }

        [Display()]
        public string Nacionalidad { get; set; }
    }
}