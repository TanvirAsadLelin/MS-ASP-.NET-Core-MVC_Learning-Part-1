using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers
{    
    [Route("[controller]")]
    public class HomeController : Controller
    {    
        [Route("")]
        [Route("~/")]
        [Route("[action]")]
        public IActionResult Index()
        {   

            Employee emp1 = new Employee();
            emp1.empName = "Lelin";
            emp1.empGender = "Male";
            emp1.empDesignation = "MD";

            Employee emp2 = new Employee();
            emp2.empName = "Lelin";
            emp2.empGender = "Male";
            emp2.empDesignation = "MD";
            
            
            Employee emp3 = new Employee();
            emp3.empName = "Lelin";
            emp3.empGender = "Male";
            emp3.empDesignation = "MD";  
            
            
            Employee emp4 = new Employee();
            emp4.empName = "Lelin";
            emp4.empGender = "Male";
            emp4.empDesignation = "MD";


            List<Employee> empList = new List<Employee>();

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);


            return View(empList);
        }
    }
}
