using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using GreetMe_API.BusinessLogic;
using GreetMe_API.DTO;



namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ViewController : Controller
    {
        private readonly IViewRepository _viewRepository;
        private readonly IPersonRepository _personrepository;

        [ActivatorUtilitiesConstructor]

        public ViewController(IViewRepository viewRepository, IPersonRepository personRepository)
        {
            _viewRepository = viewRepository;
            _personrepository = personRepository;

        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get by ID
        [HttpGet]
        [Route("get/{id}")]
        public ActionResult GetById(int id)
        {
            //Input Validator, 0 <
            if (id <= 0)
            {
                return Conflict();
            }
            View? foundView = _viewRepository.Get(id);

            if (foundView is not null)
            {
                ViewDto viewDto = ViewDtoConverter.ConvertToDto(foundView);
                return Ok(viewDto);
            }

            else
            {
                return Conflict();
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

        //Create View
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ViewDto viewDto)
        {
            View view = ViewDtoConverter.ConvertFromDto(viewDto);
            bool viewCreated = await _viewRepository.CreateAsync(view);
            if (viewCreated)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //Update Async
        [HttpPut]
        public async Task<ActionResult> Update(ViewDto viewDto)
        {
            View view = ViewDtoConverter.ConvertFromDto(viewDto);
            bool viewUpdated = await _viewRepository.UpdateAsync(view);
            if (viewUpdated)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete Async
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            bool viewDeleted = await _viewRepository.DeleteAsync(id);
            if (viewDeleted)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }
    }
}
