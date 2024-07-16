using Microsoft.AspNetCore.Mvc;

namespace TercerIntento.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hola Mundo";
            //return View();
        }
    }
}
