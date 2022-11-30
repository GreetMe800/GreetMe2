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
using NuGet.Packaging;

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

        //-----------------------------------------------------------------------------
        /* Index Page & Getall                                                       */
        //-----------------------------------------------------------------------------

        //Will use view that has the same name as the method (./View/Index)
        //View Index Page

        /* Getall */
        //Index Page / Getall Method 
        //Route: ./Views
        public async Task<ActionResult> Index()
        {
            IEnumerable<ViewViewModel> ViewList = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GETALL
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

        //-----------------------------------------------------------------------------
        /* View Page & Get                                                           */
        //-----------------------------------------------------------------------------

        /* Get */
        //Route: ./Views/Details/{id}
        public async Task<ActionResult> Details(int id)
        {
            ViewViewModel view = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("view/" + id.ToString());
            if (responseTask.IsSuccessStatusCode)
            {
                var readTask = responseTask.Content.ReadAsAsync<ViewViewModel>();
            }

            return View(view);
        }

        /* Get */
        //Route: ./Views/Display/{id}
        public async Task<ActionResult> Display(int id)
        {
            IList<IDisplayItem> result = new List<IDisplayItem>();

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("view/" + id.ToString());
            if (responseTask.IsSuccessStatusCode)
            {
                var readTask = responseTask.Content.ReadAsAsync<ViewViewModel>();
                if (readTask.Result.HasBirthday)
                {
                    //Skal erstattes med et kald til Databasen
                    List<PersonViewModel> birthdayList = new List<PersonViewModel>();
                    birthdayList.Add(new PersonViewModel() { FullName = "Thomas", DateOfBirth = DateTime.Now, Id = 1 });
                    //Her starter korrekt kode, ovenstående er testkode for at fremvise funktionalitet.
                    result.AddRange<IDisplayItem>(birthdayList);
                }

                if (readTask.Result.HasAnniversary)
                {
                    //Skal erstattes med et kald til Databasen
                    List<PersonViewModel> anniversaryList = new List<PersonViewModel>();
                    anniversaryList.Add(new PersonViewModel() { FullName = "Peter", HiringDate = DateTime.Now, Id = 1 });
                    //Her starter korrekt kode, ovenstående er testkode for at fremvise funktionalitet.
                    result.AddRange<IDisplayItem>(anniversaryList);
                }

            }

            return View(result);
        }


        //-----------------------------------------------------------------------------
        /* Create Page & Create                                                      */
        //-----------------------------------------------------------------------------

        //Page
        //Route: ./Views/Create
        public ActionResult Create()
        {
            return View();
        }

        //Method
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ViewViewModel view)
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

        //-----------------------------------------------------------------------------
        /* Edit Page/Get & Update                                                      */
        //-----------------------------------------------------------------------------

        //Page
        //Route: ./Views/Edit
        public async Task<ActionResult> Edit(int id)
        {
            ViewViewModel view = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("view/" + id.ToString());
            if (responseTask.IsSuccessStatusCode)
            {
                view = await responseTask.Content.ReadAsAsync<ViewViewModel>();
            }

            return View(view);
        }

        //Method
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ViewViewModel view)
        {
            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP PUT
            var putTask = await client.PutAsJsonAsync<ViewViewModel>("view", view);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(view);
        }

        //-----------------------------------------------------------------------------
        /* Delete Page & Create                                                      */
        //-----------------------------------------------------------------------------

        /* Delete */
        //Route: ./Views/Delete/{id}
        public /*async*/ Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}