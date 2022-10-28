using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ViewController : Controller
    {

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        [HttpGet]
        [Route("get/{id}")]
        public ActionResult GetById(int id)
        {
            //Input Validator, 0 <
            if (id <= 0)
            {
                return new StatusCodeResult(422);
            }
            View? foundView = _viewRepository.GetById(id);

            if (foundView is not null)
            {
                ViewDto viewDto = ViewDTOConverter.ConvertTo(foundView);
                return Ok(viewDto);
            }

            else
            {
                return new StatusCodeResult(404);
            }
        }

        [HttpGet, Route("viewName")]
        public ActionResult<ViewDto> GetByViewName(int id)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ViewDto viewDto)

            //-----------------------------------------------------------------------------
            /* Update                                                                    */
            //-----------------------------------------------------------------------------

            //-----------------------------------------------------------------------------
            /* Delete                                                                    */
            //-----------------------------------------------------------------------------
        }
}
