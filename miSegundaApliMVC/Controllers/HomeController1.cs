using Microsoft.AspNetCore.Mvc;

namespace miSegundaApliMVC.Controllers
{
    public class HomeController1 : Controller
    {
        public string Index()
        {
            return "Hola Mundo";
            //return View();
        }
    }
}
