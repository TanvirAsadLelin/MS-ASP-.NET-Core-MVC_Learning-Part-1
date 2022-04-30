using Microsoft.AspNetCore.Mvc;

namespace ActionMethods_Demo_WebApplication.Controllers
{   
    [Route("[controller]")]
    public class HomeController : Controller
    {   
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("[action]/{msg}")]
        public string Message(string msg)
        {
            return "Hello "+msg;
        }

        [Route("[action]/{id1}/{id2}")]
        public int Id(int id1, int id2)
        {
            return id1 + id2;
        }
    }
}
