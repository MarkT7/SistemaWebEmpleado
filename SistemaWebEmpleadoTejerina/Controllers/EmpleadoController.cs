using SistemaWebEmpleadoTejerina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using SistemaWebEmpleadoTejerina.Models;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace SistemaWebEmpleadoTejerina.Controllers
{
    public class EmpleadoController:Controller
    {
        private EmpleadoDBContext context = new EmpleadoDBContext();

        public ActionResult Index()
        {
            List<Empleado> lista = context.Empleados.ToList();
            return View(lista);
        }

        public ActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View(empleado);
        }

        [HttpPost]
        public ActionResult Insert(Empleado empleado) 
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(empleado);
            }
        }

        public ActionResult ViewTitle(int id)
        {
            Empleado empleado = context.Empleados.Find(id);

            if(empleado==null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(empleado.Titulo);
            }
        }
    }
}