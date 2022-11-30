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

        //GetAll
        //TODO ROute
        [HttpGet, Route("GetAll")]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAll()
        {

            IEnumerable<Person> personList = await _personRepository.GetAll();
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

        //GetAll Birthdays Today
        [HttpGet, Route("GetallBirthdaysToday")]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllBirthdaysToday()
        {

            IEnumerable<Person> personList = await _personRepository.GetAllBirthdaysToday();
            foreach (Person person in personList)
            {
                PersonDtoConverter.ConvertToDto_Birthday(person);
            }
            IList<Person> personDtoList = personList.ToList();

            if (personDtoList.Count == 0)
            {
                return NotFound();
            }

            return Ok(personDtoList);
        }

        //GetAll Anniversarys Today
        [HttpGet, Route("GetallAnniversarysToday")]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllAnniversarysToday()
        {

            IEnumerable<Person> personList = await _personRepository.GetAllAnniversarysToday();
            foreach (Person person in personList)
            {
                PersonDtoConverter.ConvertToDto_Anniversary(person);
            }
            IList<Person> personDtoList = personList.ToList();

            if (personDtoList.Count == 0)
            {
                return NotFound();
            }

            return Ok(personDtoList);
        }

        //GetAll Birthdays
        [HttpGet, Route("GetallBirthdays")]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllBirthdays(DateOnly date)
        {

            IEnumerable<Person> personList = await _personRepository.GetAllBirthdays(date);
            foreach (Person person in personList)
            {
                PersonDtoConverter.ConvertToDto_Birthday(person);
            }
            IList<Person> personDtoList = personList.ToList();

            if (personDtoList.Count == 0)
            {
                return NotFound();
            }

            return Ok(personDtoList);
        }

        //GetAll Anniverserys
        [HttpGet, Route("GetallAnniversary")]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllAnniversarys(DateOnly date)
        {

            IEnumerable<Person> personList = await _personRepository.GetAllAnniversarys(date);
            foreach (Person person in personList)
            {
                PersonDtoConverter.ConvertToDto_Anniversary(person);
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
        //TODO ROute
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonDto>> Get(int id)
        {
            Person Person = await _personRepository.Get(id);
            PersonDto personDto = PersonDtoConverter.ConvertToDto(Person);

            if (personDto == null)
            {
                return NotFound();
            }

            return Ok(personDto);
        }

        //Get By Email
        [HttpGet("{email}")]
        public async Task<ActionResult<PersonDto>> GetByEmail(string email)
        {
            Person Person = await _personRepository.GetByEmail(email);
            PersonDto PersonDto = PersonDtoConverter.ConvertToDto(Person);

            if (PersonDto == null)
            {
                return NotFound();
            }

            return Ok(PersonDto);
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
                return await _personRepository.Create(person);
            }
            return null;
        }

        //-----------------------------------------------------------------------------
        /* Update                                                                    */
        //-----------------------------------------------------------------------------

        [HttpPut]
        public /*async*/ Task<Person> Update([FromBody] PersonDto personDto)
        {
            throw new NotImplementedException();
        }

        //-----------------------------------------------------------------------------
        /* Delete                                                                    */
        //-----------------------------------------------------------------------------

        [HttpDelete]
        public /*async*/ Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}