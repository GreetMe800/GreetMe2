﻿using GreetMe_DataAccess.DTO;
using GreetMe_MVC.Models.View;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;

namespace GreetMe_MVC.Controllers
{
    public class ViewController : Controller
    {

        private RestClient ApiService;
        

        public ViewController(IConfiguration configuration)
        {
            ApiService = new RestClient(configuration["Api"]);
            //"https://localhost:7259/"
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

        //[HttpPut]
        public IActionResult Edit(int id) 
        {

            //var request = new RestRequest("api/View" + id, Method.Get);
            //ViewDto? viewDto = ApiService.Execute<ViewDto>(request).Data;


            ViewDto vdto = new ViewDto()
            {
                HasCurrentDatetime = true,
                HasAnniversary = true,
                HasBirthday = true,
                HasMenu = true,
                Id = 1123,
                ViewName = "din nar"

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

        //[HttpDelete] routingen skal ikk være her eller ved put
        public IActionResult Delete(int id) 
        {
            var requsst = new RestRequest("api/View" + id, Method.Delete);
            var response = ApiService.Execute(requsst);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Detail(int id)
        {

            var request = new RestRequest("api/View" + id, Method.Get);
            var response = await ApiService.ExecuteAsync<ViewDto>(request);
            DetailViewModel detailViewModel = new DetailViewModel(response.Data);

            return View(detailViewModel);
        }


    }
}
