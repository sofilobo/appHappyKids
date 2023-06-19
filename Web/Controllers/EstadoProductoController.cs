using Application_Core.Services;
using Infraestructure.Models;
using Infraestructure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class EstadoProductoController : Controller
    {
        // GET: EstadoProducto
        public ActionResult Index()
        {

            IEnumerable<EstadoProducto> lista = null;
            try
            {
                IServiceEstadoProducto _ServiceEstadoProducto = new ServiceEstadoProducto();
                lista = _ServiceEstadoProducto.GetEstadoProductos();
            }
            catch (Exception ex)
            {
                Log.Error(ex, MethodBase.GetCurrentMethod());
                TempData["Message"] = "Error al procesar los datos!" + ex.Message;
                return RedirectToAction("Default", "Error");
            }
            return View(lista);
        }



// GET: EstadoProducto/Details/5
public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstadoProducto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstadoProducto/Create
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

        // GET: EstadoProducto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstadoProducto/Edit/5
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

        // GET: EstadoProducto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstadoProducto/Delete/5
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
