using Microsoft.AspNetCore.Mvc;
using PassingData_ControllerToView__ViewBag.Models;

namespace PassingData_ControllerToView__ViewBag.Controllers
{   
    [Route("[controller]")]
    public class HomeController : Controller
    {   
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            ViewBag.var1 = "Data from ViewBag";
            ViewBag.var2 =DateTime.Now.ToLongDateString();

            string[] myArray = { "Lelin", "Israt", "Jahan" };
            ViewBag.var3 = myArray;

            ViewBag.var4 = new List<string>()
            { "I am Lelin", "My 1/3 heart name Israt", "Jahan is the second part of her name" };


            Employees emp1 = new Employees();
            emp1.EmpID = 1;
            emp1.EmpName = "Lelin";
            emp1.EmpGender = "Male";

            ViewBag.var5 = emp1;    

            return View();
        }
    }
}
