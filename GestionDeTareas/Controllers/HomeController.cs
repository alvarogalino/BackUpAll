using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GestionDeTareas.Controllers
{
    public class HomeController : Controller
    {
        private List<Tareas> _Obligaciones;
        public HomeController()
        {
            _Obligaciones = new List<Tareas>()
            {
                new Tareas() {ID= 1, Name="Recordar cumple"},
                new Tareas() {ID= 2, Name="Comprar comida mascotas"},
                new Tareas() {ID= 3, Name="Ir al super"}
            };


        }

        public ActionResult Index()
        {
            ViewData["Index"] = _Obligaciones;
            return View();
            //StringBuilder content = new StringBuilder();

            //foreach (Tareas tareas in _Obligaciones)
            //{
            //    content.Append(string.Format("ID:{0},Name:{1}", tareas.ID, tareas.Name));
            //}

            //return new ContentResult()
            //{
            //    Content = content.ToString()

            //};
        }
    }
//        public ActionResult Index(Tareas tarea)
//        {


//            //return new JsonResult(tarea);
                
        
           
//            //byte[] b = System.IO.File.ReadAllBytes(@"descarga.jpg");          
//            //return File(b, "image/jpeg");

            
//            //return "<div> Hola tontos</div>";

//            //return new ContentResult()
//            //{
//            //    Content= "Hola Tarado"
//            //};

//            //return new FilePathResult("Aceptación oferta dpto Lavalle 1959.jpg","image/jpeg");

//            //return "Hola TaskManager";

//            //return "Hola Gestion de Tareas";

//            //return View();
//        }
    
}
