using Microsoft.AspNetCore.Mvc;
using ViewImports_Demo_WebApplication.Models;

namespace ViewImports_Demo_WebApplication.Controllers
{   
    [Route("[controller]")]
    public class HomeController : Controller
    {   

        [Route("")]
        [Route("~/")]
        [Route("action")]
        public IActionResult Index()
        {
            Students std1 = new Students()
            {
                 StudentId = 1,
                 StudentName= "Lelin",
                 StudentAge = 26
            };

            Students std2 = new Students()
            {
                StudentId = 2,
                StudentName = "Israt",
                StudentAge = 26
            };

            Students std3 = new Students()
            {
                StudentId = 3,
                StudentName = "Jahan",
                StudentAge = 26
            };

            Students std4 = new Students()
            {
                StudentId = 4,
                StudentName = "Asad",
                StudentAge = 26
            };

            List<Students> std_list = new List<Students>();
            std_list.Add(std1);
            std_list.Add(std2);    
            std_list.Add(std3);
            std_list.Add(std4);


            return View(std_list);
        }

        [Route("[action]/{id}")]
        public IActionResult Details(int id)
        {
            Students std4 = new Students()
            {
                StudentId = id,
                StudentName = "Asad",
                StudentAge = 26
            };

            return View(std4);
        }
    }
}
