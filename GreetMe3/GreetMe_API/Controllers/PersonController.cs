using GreetMe_API;
using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GreetMe_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAll()
        {

            IEnumerable<Person> personList = await _personRepository.GetAllAsync();
            foreach (Person person in personList)
            {
                PersonDtoConverter.ConvertToDto(person);
            }
            IList<Person> personDtoList = personList.ToList();

            if (personDtoList.Count == 0)
            {
                return NotFound();
            }

            return Ok(personDtoList);
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get - api/Persons/5
        [HttpGet("{id}")]
        public async Task<PersonDto> Get(int id)
        {
            Person foundPerson = _personRepository.Get(id);
            PersonDto personDto = PersonDtoConverter.ConvertToDto(foundPerson);
            return personDto;
        }

        //Get By Email
        [HttpGet, Route("{email}")]
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

        //Create Person - api/People
        [HttpPost]
        public async Task<Person> Create([FromBody] PersonDto personDto)
        {
            if (ModelState.IsValid)
            {
                Person person = PersonDtoConverter.ConvertToModel(personDto);
                return await _personRepository.CreateAsync(person);
            }
            return null;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        [HttpPut]
        public async Task<Person> Update([FromBody] PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        [HttpDelete]
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}