using Biblioteca.BLL.Services;
using Biblioteca.Models.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Utilidades;
using System.IO;

namespace Biblioteca.Controllers
{
    public class NacionalidadController : Controller
    {
        GenericService<Nacionalidad> _service = new GenericService<Nacionalidad>();
        // GET: Nacionalidad
        public ActionResult Index()
        {
            return View(_service.Listar());
        }

        // GET: Nacionalidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nacionalidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nacionalidad/Create
        [HttpPost]
        public JsonResult Create(Nacionalidad nacionalidad)
        {
            string vista = "";

            try
            {
               _service.Insertar(nacionalidad);
                vista = this.RenderizarVistaAString("~/Views/Nacionalidad/Create.cshtml",new Nacionalidad());
            }
            catch
            {
                vista = this.RenderizarVistaAString("~/Views/Nacionalidad/Create.cshtml", nacionalidad);
            }


            return Json(new { vista = vista }, JsonRequestBehavior.AllowGet);
        }

        // GET: Nacionalidad/Edit/5
        public ActionResult Edit(int id)
        {
            Nacionalidad nacionalidad = new Nacionalidad();
            nacionalidad = _service.Listar().Where(x => x.Id == id).FirstOrDefault();
            return View(nacionalidad);
        }

        // POST: Nacionalidad/Edit/5
        [HttpPost]
        public ActionResult Edit(Nacionalidad nacionalidad)
        {
            try
            {
                _service.Actualizar(nacionalidad);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nacionalidad/Delete/5
        public ActionResult Delete(int id)
        {
            Nacionalidad nacionalidad = new Nacionalidad();
            nacionalidad = _service.Listar().Where(x => x.Id == id).FirstOrDefault();
            return View(nacionalidad);
        }

        // POST: Nacionalidad/Delete/5
        [HttpPost]
        public ActionResult Delete(Nacionalidad nacionalidad)
        {
            try
            {
                // TODO: Add delete logic here
                if (_service.Eliminar(nacionalidad.Id))
                {
                    return RedirectToAction("Index");
                }
                else 
                {
                    return View(nacionalidad);
                }
            }
            catch
            {
                return View(nacionalidad);
            }
        }


      
    }
}
