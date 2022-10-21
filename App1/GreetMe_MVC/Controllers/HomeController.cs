using GreetMe_DataAccess.DTO;
using GreetMe_MVC.Models;
using GreetMe_MVC.Models.Home;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Diagnostics;
using System.Reflection;

namespace GreetMe_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RestClient ApiService;

            public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            ApiService = new RestClient(configuration.GetConnectionString("api"));
        }

        public async Task<IActionResult> Index()
        {

            //var request = new RestRequest("api/View", Method.Get);
            //var response = await ApiService.ExecuteAsync<List<ViewDto>>(request);

            //List<IndexModel> indices = new List<IndexModel>();

           

            //if (response.Data is not null)
            //{
            //    foreach (ViewDto vDto in response.Data)
            //    {
            //        IndexModel index = new IndexModel(vDto);
            //        indices.Add(index);
            //    }

            //}


           

            ViewDto vdto = new ViewDto()
            {
                HasCurrentDatetime = true,
                HasAnniversary = true,
                HasBirthday = true,
                HasMenu = true,
                Id = 1123,
                ViewName = "din nar"

            };
         
            List<ViewDto> views = new List<ViewDto>();
            views.Add(vdto);
            views.Add(vdto);
            views.Add(vdto);

            List<IndexModel> indices = new List<IndexModel>();
            
            foreach (ViewDto vDto in views)
            {
                    IndexModel view = new IndexModel(vDto);
                    indices.Add(view);                    
            }


           





            return View(indices);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}