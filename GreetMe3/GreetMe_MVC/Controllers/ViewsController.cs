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

    public class ViewsController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();

        ViewViewModel _viewModel = new ViewViewModel();
        List<ViewViewModel> _viewModels = new List<ViewViewModel>();

        public ViewsController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = (sender ,cert , chain, sslPolicyErrors) => { return true; };
        }

        //Will use view that has the same name as the method (./View/Index)
        //View Index Page
        public async Task<ActionResult> Index()
        {
            GetAll();
            return View();
        }

        //Getall
        [HttpGet]
        public async Task<List<ViewViewModel>> GetAll()
        {
            _viewModels = new List<ViewViewModel>();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:7232/api/view"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _viewModels = JsonConvert.DeserializeObject<List<ViewViewModel>>(apiResponse);
                }

                return _viewModels;
            }
        }

        [HttpGet]
        public async Task<ViewViewModel> Get(int id)
        {
            _viewModel = new ViewViewModel();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:7232/api/view" + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _viewModel = JsonConvert.DeserializeObject<ViewViewModel>(apiResponse);
                }

                return _viewModel;
            }
        }

        [HttpPost]
        public async Task<ViewViewModel> Create(ViewViewModel view)
        {
            _viewModel = new ViewViewModel();

            using (var httpClient = new HttpClient(_clientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(view), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:7232/api/view", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _viewModel = JsonConvert.DeserializeObject<ViewViewModel>(apiResponse);
                }

                return _viewModel;
            }
        }

        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string message = "";

            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:7232/api/view" + "/" + id))
                {
                    message = await response.Content.ReadAsStringAsync();
                }

                return message;
            }
        }
    }
}
