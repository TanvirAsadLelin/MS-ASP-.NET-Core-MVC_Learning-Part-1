using Microsoft.AspNetCore.Mvc;
using PassingData_ControllerToView__ViewData.Models;

namespace PassingData_ControllerToView__ViewData.Controllers
{    
    [Route("[controller]")]
    public class HomeController : Controller
    {   
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            ViewData["var1"] = "Hello from ViewData.";
            ViewData["var2"] = DateTime.Now.ToLongDateString();

            string[] myArray = { "Lelin", "Israt", "Jahan" };
            ViewData["var3"] = myArray;
            ViewData["var4"] = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
                "Bolly"
            };


            // Use Students Class From Models

            Students std1 = new Students();
            std1.stdName = "Tanvir";
            std1.stdGender = "Male";
            std1.stdClass = 12;

            ViewData["var5"] = std1;
            
            return View();
        }
    }
}
