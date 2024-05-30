using Biblioteca.BLL.Services;
using Biblioteca.Models.Biblioteca;
using Biblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers

{
    
    public class LibroController : Controller
    {
        GenericService<LibroVM> _service = new GenericService<LibroVM>();
        GenericService<DetalleLibroVM> _Detalleservice = new GenericService<DetalleLibroVM>();
        GenericService<Libro> _libroservice = new GenericService<Libro>();
        // GET: Libro
        public ActionResult Index()
        {
           
          
            
            List<LibroVM> libros = new List<LibroVM>();
            List<Libro> list = _libroservice.Listar().ToList();

            foreach (var item in list)
            {
                LibroVM libro = new LibroVM();
                libro.Id = item.Id;
                libro.Libro = item.Nombre;
                libro.FechaDePublicacion = item.FechaDePublicacion;

                string Proc = "[Biblioteca].[ListadoDetallesDeLibroVM]";
                var parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("LibroId", item.Id));

                libro.DetalleLibros = _Detalleservice.ListarProc(Proc, parametros).ToList();
                libro.Add(libro);
            }


            return View(libros);
        }

        // GET: Libro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
