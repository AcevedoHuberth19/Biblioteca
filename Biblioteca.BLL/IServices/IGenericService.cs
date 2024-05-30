﻿using Biblioteca.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.BLL.IServices
{
    public interface IGenericService<T> : IGenericRepository <T> where T : class
    {
    }
}
