using GreetMe_API.DTO;
using GreetMe_MVC.Stylesheet;
using GreetMe_MVC.ViewModels.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using RestSharp;

namespace GreetMe_MVC.Controllers
{
    public class ViewController : Controller
    {

        private RestClient ApiService;

        public ViewController(IConfiguration configuration)
        {
            ApiService = new RestClient(configuration.GetConnectionString("api"));
        }

        // GET: ViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ViewController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            throw new NotImplementedException();
            //(Brians example kode, slet ikke selvom ikke fungere)
            /*
            var view = Database.getView(id);
            if(view.Type = "birthday")
            {
                
                //bygge viewmodel til birthday, med dens data 
                var birthdayViewModel = new BirthdayViewModel();
                birthdayViewModel.AllBirthdays = Database.LoadAllBirthday();
                return View(birthdayViewModel);
            }
            


            ViewDto viewDto = new ViewDto();
            LayoutDto layoutDto = new LayoutDto();
            ComponentPositionDto componentPositionDto = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "birthday"
                },

                Position = 1
            };
            ComponentPositionDto componentPositionDto1 = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "birthday"
                },

                Position = 2
            };
            ComponentPositionDto componentPositionDto2 = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "birthday"
                },

                Position = 3
            };
            ComponentPositionDto componentPositionDto3 = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "birthday"
                },

                Position = 4
            };
            ComponentPositionDto componentPositionDto4 = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "anniversary"
                },

                Position = 5
            };
            ComponentPositionDto componentPositionDto5 = new ComponentPositionDto()
            {
                ComponentDto = new ComponentDto()
                {
                    ComponentName = "birthday"
                },

                Position = 6
            };
            layoutDto.ComponentPositionDtos.Add(componentPositionDto);
            layoutDto.ComponentPositionDtos.Add(componentPositionDto1);
            layoutDto.ComponentPositionDtos.Add(componentPositionDto2);
            layoutDto.ComponentPositionDtos.Add(componentPositionDto3);
            layoutDto.ComponentPositionDtos.Add(componentPositionDto4);
            layoutDto.ComponentPositionDtos.Add(componentPositionDto5);
            viewDto.LayoutDto = layoutDto;
            ViewDetail viewDetail = new ViewDetail(viewDto);
            viewDetail.Style = StyleLogic.getStyle();


            return View(viewDetail);
            */
        }
            

        // GET: ViewController/Create
        public ActionResult CreateView()
        {
            return View();
        }

        // POST: ViewController/Create // Rename enten den her eller andet
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
