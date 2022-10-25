using GreetMe_DataAccess.DTO;
using GreetMe_MVC.Models.View;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace GreetMe_MVC.Controllers
{
    public class ViewController : Controller
    {

        private RestClient ApiService;
        //private HttpClient ApiService;

        public ViewController(IConfiguration configuration)
        {
            //ApiService = new RestClient(configuration.GetConnectionString("api"));

            //for testing
            var options = new RestClientOptions("http://localhost:5259/")
            {
                ThrowOnAnyError = true,
                Timeout = 5000000
            };

            ApiService = new RestClient(options);
            //string conncetionstring = "https://localhost:7259";
            //ApiService = new HttpClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel model) 
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

        [HttpPut]
        public IActionResult Edit(int id) 
        {

            var request = new RestRequest("api/View" + id, Method.Get);
            ViewDto? viewDto = ApiService.Execute<ViewDto>(request).Data;


            ViewDto vdto = new ViewDto()
            {
                HasCurrentDatetime = viewDto.HasCurrentDatetime,
                HasAnniversary = viewDto.HasAnniversary,
                HasBirthday = viewDto.HasBirthday,
                HasMenu = viewDto.HasMenu,
                ViewName = viewDto.ViewName

            };

            EditViewModel view = new EditViewModel(vdto);
            
            
            
            

            return View(view);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel editViewModel) 
        {
            var request = new RestRequest("api/View", Method.Post);
            request.AddJsonBody(editViewModel);
            var response = ApiService.Execute(request);
            return RedirectToAction("Index", "Home");
        }

        [HttpDelete] 
        public IActionResult Delete(int id) 
        {
            var requsst = new RestRequest("api/View" + id, Method.Delete);
            var response = ApiService.Execute(requsst);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Detail(int id)
        {


           


            var request = new RestRequest("https://localhost:7259/api/View/" + 1, Method.Get);
            var response = await ApiService.ExecuteAsync<ViewDto>(request);
            DetailViewModel detailViewModel = new DetailViewModel(response.Data);

            //DetailViewModel detailViewModel1 = new DetailViewModel();
            //detailViewModel1.HasCurrentDatetime = true;
            //detailViewModel1.HasAnniversary = false;
            //detailViewModel1.HasBirthday = false;

            return View(detailViewModel);
        }


    }
}
