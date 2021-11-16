using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // Default Method 

        public IActionResult Index()
        {
            //Especifica uso de plantilla de vista para presentar info
            //Plantilla predetermina index
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //El ViewDataobjeto de 
            //    diccionario contiene datos que se pasarán a la vista
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default
        //        .Encode($"Hello {name}, ID: {ID}");
        //}
    }
}