using Microsoft.AspNetCore.Mvc;

namespace PassingData_ControllerToView__TempData.Controllers
{   
    [Route("[controller]")]
    public class HomeController : Controller
    {   
        [Route("")]
        [Route("~/")]
        [Route("[action]")]

        public IActionResult Index()
        {
            ViewData["varD1"] = "From ViewData";
            ViewBag.varB1 = "From ViewBag";
            TempData["varT1"] = "From TempData";

            string[] myArray = { "Lelin", "Israt", "Jahan" };

            TempData["varArray"] = myArray;

            TempData.Keep("varArray");
            return View();
        }
        [Route("[action]")]
        public IActionResult About()
        {
            TempData.Keep("varT1");
            return View();
        }
        [Route("[action]")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
