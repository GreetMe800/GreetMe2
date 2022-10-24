﻿using GreetMe_DataAccess.DTO;
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
                Timeout = 100000
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

          
            //vdto.AnniversarysToday = new List<PersonDto>();
            //vdto.BirthdaysToday = new List<PersonDto>();

            var request = new RestRequest("http://localhost:5259/api/View", Method.Post);
            

            request.AddJsonBody(model);
            var response = ApiService.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception();
            }


            ViewData["Message"] = string.Format("View Oprettet");
            return RedirectToAction("Index", "Home");
        }

        //[HttpPut]
        public async Task<IActionResult> Edit(int id) 
        {

            var request = new RestRequest("http://localhost:5259/api/View/" + id, Method.Get);
            var response = await ApiService.ExecuteAsync<ViewDto>(request);
            ViewDto? viewDto = response.Data;


            

            EditViewModel view = new EditViewModel(viewDto);
            
            
            
            

            return View(view);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel editViewModel) 
        {
            var request = new RestRequest("http://localhost:5259/api/View", Method.Post);
            request.AddJsonBody(editViewModel);
            var response = ApiService.Execute(request);
            return RedirectToAction("Index", "Home");
        }

        //[HttpDelete] routingen skal ikk være her eller ved put
        public IActionResult Delete(int id) 
        {
            var requsst = new RestRequest("http://localhost:5259/api/View" + id, Method.Delete);
            var response = ApiService.Execute(requsst);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Detail(int id)
        {


           


            var request = new RestRequest("https://localhost:7259/api/View/" + id, Method.Get);
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
