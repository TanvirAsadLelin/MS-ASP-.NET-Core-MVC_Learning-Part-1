using Microsoft.AspNetCore.Mvc;

namespace BootstrapJQueryInstall_WebApplication.Controllers
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

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}
