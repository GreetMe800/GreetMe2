using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;

namespace GreetMe_MVC.Controllers
{
    public class CreateViewController : Controller
    {

        private RestClient client;
        

        public CreateViewController()
        {
            client = new RestClient("https://localhost:7259/");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateView(CreateViewModel model) 
        {

            var request = new RestRequest("api/View", Method.Post);
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
