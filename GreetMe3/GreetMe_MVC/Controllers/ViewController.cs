using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_MVC.Controllers
{
    //Will use the folder with the same name as the Controller (./View)
    //To access page with out being the default use route "/localhost:1234/CONTROLLERNAME" - "/localhost:1234/View"
    //To access method within this controller use "/localhost:1234/CONTROLLERNAME/METHODNAME"

    public class ViewController : Controller
    {
        //Will use view that has the same name as the method (./View/Index)
        public IActionResult Index()
        {
            ViewViewModel view = new ViewViewModel()
            //test code
            { ViewName = "Awesome View1", ViewName2 = "Awesome View2"};
            return View(view);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
