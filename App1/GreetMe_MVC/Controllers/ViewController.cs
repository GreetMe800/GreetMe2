using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;

namespace GreetMe_MVC.Controllers
{
    public class ViewController : Controller
    {

        private RestClient client;
        

        public ViewController()
        {
            client = new RestClient("https://localhost:7259/");
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel model) 
        {

            var request = new RestRequest("https://localhost:7259/api/View", Method.Post);
            request.AddJsonBody(model);
            var response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception();
            }


            ViewData["Message"] = string.Format("View Oprettet");
            return Index();
        }
    }
}
