using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using GreetMe_DataAccess.DTO;
using GreetMe_API.ModelConversion;
using GreetMe_DataAccess.Interface;
using GreetMe_API.TestClasses;

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ViewController : Controller
    {
        private readonly IViewRepository _viewRepository;

        [ActivatorUtilitiesConstructor]

        public ViewController(IViewRepository viewRepository)
        {
            _viewRepository = viewRepository;
        }

        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        ////GetAll
        //[HttpGet(Name = "GetAllViews")]
        //public IEnumerable<View> GetAll()
        //{
        //    return _viewRepository.GetAll();
        //}

        //GetAll Async
        [HttpGet(Name = "GetAllViewsAsync")]
        public async Task<IEnumerable<View>> GetAllAsync()
        {
            return await _viewRepository.GetAllAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get By Id
        [HttpGet("{id}")]
        public ActionResult<ViewDto> GetById(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return new StatusCodeResult(422);
            }

            View? foundView = _viewRepository.GetById(id);

            //if view is found
            if (foundView is not null)
            {
                ViewDto viewDto = ViewDTOConverter.ConvertTo(foundView);
                return Ok(viewDto);
            }

            //if not found
            else
            {
                return new StatusCodeResult(404);
            }
        }

        [HttpGet("{viewName}")]
        public ActionResult<ViewDto> GetByViewName(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return new StatusCodeResult(422);
            }

            View? foundView = _viewRepository.GetByIdWithDep(id);

            //if view is found
            if (foundView is not null)
            {
                ViewDto viewDto = ViewDTOConverter.ConvertTo(foundView);
                return Ok(viewDto);
            }

            //if not found
            else
            {
                return new StatusCodeResult(404);
            }
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create View
        [HttpPost]
        //public ActionResult Create(View view)
        //{
        //    var viewDto = ViewDTOConverter.ConvertTo(view);
        //    return Ok(view);
        //}

        public ActionResult Create(ViewDto viewDto)
        {
            View view = ViewDTOConverter.ConvertFrom(viewDto);
            _viewRepository.Create(view);
            return Ok();
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------



        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------
    }
}