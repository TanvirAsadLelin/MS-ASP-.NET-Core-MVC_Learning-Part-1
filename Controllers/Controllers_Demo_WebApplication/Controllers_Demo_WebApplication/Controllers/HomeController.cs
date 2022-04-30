using Microsoft.AspNetCore.Mvc;

namespace Controllers_Demo_WebApplication.Controllers
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
    }
}
