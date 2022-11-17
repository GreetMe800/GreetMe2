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

        //GetAll - api/Views
        [HttpGet]
        public async Task<IEnumerable<View>> GetAll()
        {
            return await _viewRepository.GetAllAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get - api/Views/5
        [HttpGet("{id}")]
        public async Task<ViewDto> Get(int id)
        {
            View foundView = _viewRepository.Get(id);
            ViewDto viewDto = ViewDtoConverter.ConvertToDto(foundView);
            return viewDto;
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        //Create View - api/Views
        [HttpPost]
        public async Task<View> Create([FromBody] ViewDto viewDto)
        {
            if (ModelState.IsValid)
            {
                View view = ViewDtoConverter.ConvertFromDto(viewDto);
                return await _viewRepository.CreateAsync(view);
            }
            return null;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        //Update
        [HttpPut]
        public async Task<View> Update([FromBody] ViewDto viewDto)
        {
            if (ModelState.IsValid)
            {
                View view = ViewDtoConverter.ConvertFromDto(viewDto);
                return await _viewRepository.UpdateAsync(view);
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
            bool deleted = await _viewRepository.DeleteAsync(id);
           
        }
    }
}
