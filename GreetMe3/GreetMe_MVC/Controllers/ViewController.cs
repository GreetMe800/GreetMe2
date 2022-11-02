using GreetMe_API.DTO;
using GreetMe_MVC.Stylesheet;
using GreetMe_MVC.ViewModels.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace GreetMe_MVC.Controllers
{
    public class ViewController : Controller
    {

        private RestClient ApiService;

        public ViewController( IConfiguration configuration)
        {
            ApiService = new RestClient(configuration.GetConnectionString("api"));
        }

        // GET: ViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ViewController/Details/5
        public ActionResult Details(/*int id*/)
        {

            ViewDto viewDto = new ViewDto();
            ComponentDto componentDto = new ComponentDto() 
            {
                ComponentName = "birthday"
            };
            viewDto.Components = new List<ComponentDto>();
            viewDto.Components.Add(componentDto);
            viewDto.Components.Add(componentDto);
            viewDto.Components.Add(componentDto);
            viewDto.Components.Add(componentDto);



            ViewDetail detailView = new ViewDetail(viewDto);
            detailView.Style = StyleLogic.getStyle("style1");


            return View(detailView);
        }

        // GET: ViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
