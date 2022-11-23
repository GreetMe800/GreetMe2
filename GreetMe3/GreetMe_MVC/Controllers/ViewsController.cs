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

        /* Getall */
        //Page / Getall Method 
        public async Task<IActionResult> Index()
        {
            IEnumerable<ViewViewModel> ViewList = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("view");
            if (responseTask.IsSuccessStatusCode)
            {
                var viewViewModelList = await responseTask.Content.ReadAsAsync<IList<ViewViewModel>>();
                ViewList = viewViewModelList;
            }
            else // If Error
            {
                ViewList = Enumerable.Empty<ViewViewModel>();
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }

            //Return
            return View(ViewList);
        }

        /* Get */
        public /*async*/ Task<IActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        /* Create */

        //Page
        public ActionResult Create()
        {
            return View();
        }

        //Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ViewViewModel view)
        {
            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP POST
            var postTask = await client.PostAsJsonAsync<ViewViewModel>("view", view);
            if (postTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            //Return
            return View(view);
        }

        /* Delete */
        public /*async*/ Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            throw new NotImplementedException();
        }
    }
}