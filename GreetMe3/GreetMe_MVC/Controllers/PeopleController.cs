using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public PeopleController()
        {

        }

        //-----------------------------------------------------------------------------
        /* Index Page & Getall                                                       */
        //-----------------------------------------------------------------------------

        //Will use person that has the same name as the method (./Person/Index)
        //Person Index Page

        /* Getall */
        //Index Page / Getall Method 
        //Route: ./People
        public async Task<ActionResult> Index()
        {
            IEnumerable<PersonViewModel> PersonList = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GETALL
            var responseTask = await client.GetAsync("person" + "/getall");
            if (responseTask.IsSuccessStatusCode)
            {
                var personPersonModelList = await responseTask.Content.ReadAsAsync<IList<PersonViewModel>>();
                PersonList = personPersonModelList;
            }
            else // If Error
            {
                PersonList = Enumerable.Empty<PersonViewModel>();
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }

            //Return
            return View(PersonList);
        }

        //-----------------------------------------------------------------------------
        /* Person Page & Get                                                           */
        //-----------------------------------------------------------------------------

        /* Get */
        //Route: ./People/Details/{id}
        public async Task<ActionResult> Details(int id)
        {
            PersonViewModel person = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("person/" + id.ToString());
            if (responseTask.IsSuccessStatusCode)
            {
                var readTask = responseTask.Content.ReadAsAsync<PersonViewModel>();
            }

            return View(person);
        }

        //-----------------------------------------------------------------------------
        /* Create Page & Create                                                      */
        //-----------------------------------------------------------------------------

        //Page
        //Route: ./People/Create
        public ActionResult Create()
        {
            return View();
        }

        //Method
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonViewModel person)
        {
            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP POST
            var postTask = await client.PostAsJsonAsync<PersonViewModel>("person", person);
            if (postTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            //Return
            return View(person);
        }

        //-----------------------------------------------------------------------------
        /* Edit Page/Get & Update                                                      */
        //-----------------------------------------------------------------------------

        //Page
        //Route: ./People/Edit
        public async Task<ActionResult> Edit(int id)
        {
            PersonViewModel person = null;

            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP GET
            var responseTask = await client.GetAsync("person/" + id.ToString());
            if (responseTask.IsSuccessStatusCode)
            {
                person = await responseTask.Content.ReadAsAsync<PersonViewModel>();
            }

            return View(person);
        }

        //Method
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonViewModel person)
        {
            //Establish Connection
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");

            //HTTP PUT
            var putTask = await client.PutAsJsonAsync<PersonViewModel>("person", person);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(person);
        }

        //-----------------------------------------------------------------------------
        /* Delete Page & Create                                                      */
        //-----------------------------------------------------------------------------

        /* Delete */
        //Route: ./People/Delete/{id}
        public /*async*/ Task<ActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}