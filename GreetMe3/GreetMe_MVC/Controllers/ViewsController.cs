using GreetMe_API.Controllers;
using GreetMe_API.ModelConverter;
using GreetMe_MVC.Models;
using GreetMe_API.DTO;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Security;
using System.Text;

namespace GreetMe_MVC.Controllers
{
    //Will use the folder with the same name as the Controller (./View)
    //To access page with out being the default use route "/localhost:1234/CONTROLLERNAME" - "/localhost:1234/View"
    //To access method within this controller use "/localhost:1234/CONTROLLERNAME/METHODNAME"
    //localhost allan - https://localhost:7232/

    public class ViewsController : Controller
    {

        public ViewsController()
        {
            
        }

        //Will use view that has the same name as the method (./View/Index)
        //View Index Page

        //View Main Page - GetAll
        public async Task<IActionResult> Index()
        {
            IEnumerable<ViewViewModel> ViewList = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5184/api/");
                //HTTP GET
                var responseTask = client.GetAsync("view");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ViewViewModel>>();
                    readTask.Wait();

                    ViewList = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    ViewList = Enumerable.Empty<ViewViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(ViewList);
        }

        //Get
        public async Task<IActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        //Create
        public async Task<IActionResult> Create(ViewViewModel view)
        {
            throw new NotImplementedException();
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
