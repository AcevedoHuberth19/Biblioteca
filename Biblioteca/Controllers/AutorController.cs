using Biblioteca.BLL.Services;
using Biblioteca.Models.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class AutorController : Controller
    {
        GenericService<Autor> _service = new GenericService<Autor>();
        GenericService<Nacionalidad> _Nacionalidadservice = new GenericService<Nacionalidad>();
        // GET: Autor
        public ActionResult Index()
        {
            return View(_service.Listar());
        }

        // GET: Autor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            ViewBag.Nacionalidad = new SelectList(_Nacionalidadservice.Listar().ToList(), "Id", "Descripcion");
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        public ActionResult Create(Autor autor)
        {
            try
            {
                // TODO: Add insert logic here
                _service.Insertar(autor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autor/Edit/5
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

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autor/Delete/5
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
