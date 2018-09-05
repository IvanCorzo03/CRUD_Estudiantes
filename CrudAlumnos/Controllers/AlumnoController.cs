using CrudAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            AlumnoContext db = new AlumnoContext();

            //Esta Condicion Me Trae La Lista De Alumnos Mayores A 18 (LinQ) 
            //List<Alumno> lista = db.Alumno.Where(a => a.Edad > 18).ToList();

            return View(db.Alumno.ToList());
        }
        //Encargado de llamar a la vista
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Alumno a)
        {
            if (!ModelState.IsValid)
                return View();

            return View();

        }
    }
}