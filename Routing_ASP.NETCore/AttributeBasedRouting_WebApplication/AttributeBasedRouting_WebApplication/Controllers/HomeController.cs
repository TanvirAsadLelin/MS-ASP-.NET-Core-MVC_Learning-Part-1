using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting_WebApplication.Controllers
{   
    //[Route("Home")]

    //Token
    [Route("[controller]")]
    public class HomeController : Controller
    {  
        [Route ("")]
      //  [Route("Index")]
      //Token
        [Route("[action]")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        //For use differnt name of Action method

        //  [Route("About")]
        //Token
        [Route("[action]")]
        public IActionResult About()
        {
            //For specify view file name which i want to disply here
            //return View("~/Views/Home/About.cshtml"); 
            return View();

        }


        [Route("Details/{id}")]  //Id Must be used
        [Route("Details/{id?}")]  //Id Optional
        public int Details(int? id)
        {
            return id??1;
        }
    }
}
