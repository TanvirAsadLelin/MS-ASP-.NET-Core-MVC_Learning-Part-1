using Microsoft.AspNetCore.Mvc;

namespace LayoutView_MasterPage__WebApplication.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("")]
        //  [Route("Index")]
        //Token
        [Route("[action]")]
        [Route("~/")]
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
