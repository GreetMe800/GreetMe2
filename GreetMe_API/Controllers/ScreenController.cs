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

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ScreenController : Controller
    {
        private readonly IScreenRepository _screenRepository;

        [ActivatorUtilitiesConstructor]

        public ScreenController(IScreenRepository screenRepository)
        {
            _screenRepository = screenRepository;
        }

        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        ////GetAll
        //[HttpGet(Name = "GetAllScreens")]
        //public IEnumerable<Screen> GetAll()
        //{
        //    return _screenRepository.GetAll();
        //}

        //GetAll Async
        [HttpGet(Name = "GetAllScreensAsync")]
        public async Task<IEnumerable<Screen>> GetAllAsync()
        {
            return await _screenRepository.GetAllAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get By Id
        [HttpGet("{id}")]
        public ActionResult<ScreenDto> GetById(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return new StatusCodeResult(422);
            }

            Screen? foundScreen = _screenRepository.GetById(id);

            //if screen is found
            if (foundScreen is not null)
            {
                ScreenDto screenDto = ScreenDTOConverter.ConvertTo(foundScreen);
                return Ok(screenDto);
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



        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------



        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------
    }
}