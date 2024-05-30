using Biblioteca.Models.Biblioteca;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAL.Context
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
        public DbSet<Autor> Autores { get; set; }

        public System.Data.Entity.DbSet<Biblioteca.Models.Biblioteca.Libro> Libroes { get; set; }
    }
}
