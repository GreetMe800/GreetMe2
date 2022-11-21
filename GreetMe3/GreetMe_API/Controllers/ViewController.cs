using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

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
        /* GetAll / Read                                                             */
        //-----------------------------------------------------------------------------

        //GetAll - api/View
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ViewDto>>> GetAll()
        {
            
            IEnumerable<View> viewList = await _viewRepository.GetAll();
            foreach (View view in viewList)
            {
                ViewDtoConverter.ConvertToDto(view);
            }
            IList<GreetMe_DataAccess.Model.View> viewDtoList = viewList.ToList();

            if (viewDtoList.Count == 0)
            {
                return NotFound();
            }

            return Ok(viewDtoList);
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get - api/View/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ViewDto>> Get(int id)
        {
            View View = await _viewRepository.Get(id);
            ViewDto viewDto = ViewDtoConverter.ConvertToDto(View);

            if (viewDto == null)
            {
                return NotFound();
            }

            return Ok(viewDto);
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //TODO update method
        //Create View - api/View
        [HttpPost]
        public async Task<View> Create([FromBody] ViewDto viewDto)
        {
            if (ModelState.IsValid)
            {
                View view = ViewDtoConverter.ConvertToModel(viewDto);
                return await _viewRepository.Create(view);
            }
            return null;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //TODO update method
        //Update
        [HttpPut]
        public async Task<View> Update([FromBody] ViewDto viewDto)
        {
            if (ModelState.IsValid)
            {
                View view = ViewDtoConverter.ConvertToModel(viewDto);
                return await _viewRepository.Update(view);
            }
            return null;
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        //Delete
        [HttpDelete]
        public async Task Delete(int id)
        {
            bool deleted = await _viewRepository.Delete(id);
           
        }
    }
}
