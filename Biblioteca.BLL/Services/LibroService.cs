using Biblioteca.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL.Services
{
    internal class LibroService<T> : GenericRepository<T> where T : class
    {
        public LibroService() { }
        //public IQueryable ListadoDetalles()
        //{

        //}
    }
}
