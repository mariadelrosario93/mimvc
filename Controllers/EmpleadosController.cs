using pruebamvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebamvc.Controllers
{
    public class EmpleadosController : Controller
    {
        Contexto contexto = new Contexto();

        // GET: Empleados
        public ActionResult Index()
        {
            IEnumerable<Empleados> empleados = contexto.empleados.ToList();
            return View(empleados);
            //return Json(empleados, JsonRequestBehavior.AllowGet);
        }
        public ActionResult crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Guardar(Empleados empleados)
        {
            if (ModelState.IsValid)
            {
                var buscar = contexto.empleados.Find(empleados.Id);
                if (buscar == null)
                {
                    contexto.empleados.Add(empleados);
                    contexto.SaveChanges();
                }
                else
                {
                    contexto.Set<Empleados>().AddOrUpdate(empleados);
                    contexto.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
        public ActionResult Editar(int? Id)
        {
            Empleados empleados = new Empleados();
            if (Id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                empleados = contexto.empleados.FirstOrDefault(busqueda => busqueda.Id == Id);
            }
            return View(empleados);
        }
        public ActionResult Eliminar(int? Id)
        {
            Empleados empleados = new Empleados();
            if (Id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                empleados = contexto.empleados.FirstOrDefault(buscar => buscar.Id == Id);
            }
            return View(empleados);
        }
        public ActionResult Confirmareliminacion(int? Id)
        {
            Empleados empleados = new Empleados();
            if (Id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                empleados = contexto.empleados.FirstOrDefault(busca => busca.Id == Id);
                contexto.empleados.Remove(empleados);
                contexto.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}