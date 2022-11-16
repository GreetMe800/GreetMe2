using GreetMe_API.Controllers;
using GreetMe_API.ModelConverter;
using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GreetMe_MVC.Controllers
{
    //Will use the folder with the same name as the Controller (./View)
    //To access page with out being the default use route "/localhost:1234/CONTROLLERNAME" - "/localhost:1234/View"
    //To access method within this controller use "/localhost:1234/CONTROLLERNAME/METHODNAME"

    public class ViewController : Controller
    {
        private RestClient ApiService;


        //Will use view that has the same name as the method (./View/Index)

        //View Index Page
        public IActionResult Index()
        {
            ViewViewModel view = new ViewViewModel();
            return View(view);
        }

        //Create View Page
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ViewViewModel model)
        {

            var request = new RestRequest("api/View", Method.Post);
            request.AddJsonBody(model);
            var response = ApiService.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception();
            }


            ViewData["Message"] = string.Format("View Oprettet");
            return RedirectToAction("Index", "Home");
        }
    }
}
