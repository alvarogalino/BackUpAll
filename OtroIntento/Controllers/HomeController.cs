using Microsoft.AspNetCore.Mvc;
using OtroIntento.Models;
using System.Diagnostics;

namespace OtroIntento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cosas()
        {
            return View();
            
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Acceso()
        {
            return View();
        }

        public IActionResult Enter(string user, string password)
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetTime()
        {
            DateTime time= DateTime.Now;
            string response="{\"time\": \""+time+"\"}";
            return Json(response);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}