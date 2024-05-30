using Biblioteca.BLL.IServices;
using Biblioteca.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL.Services
{
    public class GenericService<T> : GenericRepository<T>, IGenericService<T> where T : class  
    {
    }
}
