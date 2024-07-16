
using Microsoft.AspNetCore.Mvc;
using PaginaWeb1.Lista_de_Tareas;
using PaginaWeb1.ViewModels;
using System.Diagnostics;
using System.Text;
using WebApplication1.Models;

namespace PaginaWeb1.Controllers
{
    public class HomeController : Controller
    {
        
             
       
        private List<ListadeTareas> _listadeTareas;

        public HomeController()
        {
            _listadeTareas = new List<ListadeTareas>()
            {
                new ListadeTareas() {ID=1,Name="matar al perro"},
                new ListadeTareas() { ID = 2, Name = "enterrar al perro" },
                new ListadeTareas() { ID = 3, Name = "brindar con un vino" },
            };
        }
        public IActionResult Index()
        {
            /*ViewBag.ListadeTareas = _listadeTareas;*/

            ViewModelListadeTareas modeloTarea = new ViewModelListadeTareas()
            {
                ListofTask = _listadeTareas

            };
            return View("Index",modeloTarea);
                    
        }

        public IActionResult Privacy()
        {
            StringBuilder content = new StringBuilder();
            foreach (ListadeTareas tareas in _listadeTareas)
            {
                content.Append(tareas.ToString());
            }

            return View(content);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Task()
        {
            ViewBag.TestDiv = "<div> Hola soy test div </div>";
            return View();

        }
    }
}