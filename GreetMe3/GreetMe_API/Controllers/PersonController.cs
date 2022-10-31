using GreetMe_API.BusinessLogic;
using GreetMe_API.DTO;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;
        [ActivatorUtilitiesConstructor]
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        //-----------------------------------------------------------------------------
        /* GetAll                                                                    */
        //-----------------------------------------------------------------------------

        //GetAll Async
        [HttpGet(Name = "GetAllPeopleAsync")]
        public IEnumerable<Person> GetAllAsync()
        {
            return _personRepository.GetAll();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get By Id
        [HttpGet, Route("id")]
        public ActionResult<PersonDto> GetById(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return Conflict();
            }

            Person? foundPerson = _personRepository.Get(id);

            //if person is found
            if (foundPerson is not null)
            {
                PersonDto personDto = PersonDtoConverter.ConvertToDto(foundPerson);
                return Ok(personDto);
            }

            //if not found
            else
            {
                return Conflict();
            }
        }

        //Get By Email
        [HttpGet, Route("email")]
        public ActionResult<PersonDto> GetByEmail(string email)
        {
            Person? foundPerson = _personRepository.GetByEmail(email);

            //if person is found
            if (foundPerson is not null)
            {
                PersonDto personDto = PersonDtoConverter.ConvertToDto(foundPerson);
                return Ok(personDto);
            }

            //if not found
            else
            {
                return Conflict();
            }
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        [HttpPost]
        public async Task<ActionResult> Create(PersonDto personDto)
        {
            Person person = PersonDtoConverter.ConvertFromDto(personDto);
            bool personSaved = await _personRepository.CreateAsync(person);
            if (personSaved)
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



        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------
    }
}