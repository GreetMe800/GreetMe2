using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_MVC.Controllers
{
    public class PersonController : Controller
    {
        //Will use view that has the same name as the method (./View/Index)
        public IActionResult Index()
        {
            PersonViewModel person = new PersonViewModel();
            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
