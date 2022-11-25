using GreetMe_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public PeopleController()
        {

        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BirthdayViewModel> PersonList = null;
            var client = ApiHelper.InitializeClient("http://localhost:5184/api/");
            var responseTask = await client.GetAsync("person");
            if (responseTask.IsSuccessStatusCode)
            {
                var PersonViewModelList = await responseTask.Content.ReadAsAsync<IList<BirthdayViewModel>>();

                PersonList = PersonViewModelList;
            }
            else //web api sent error response 
            {
                //log response status here..

                PersonList = Enumerable.Empty<BirthdayViewModel>();

                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }

            return View(PersonList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
