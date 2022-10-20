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

        ////GetAll
        //[HttpGet(Name = "GetAllPeople")]
        //public IEnumerable<Person> GetAll()
        //{
        //    return _personRepository.GetAll();
        //}

        //GetAll Async
        [HttpGet(Name = "GetAllPeopleAsync")]
        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        //-----------------------------------------------------------------------------
        /* Get / Read                                                                */
        //-----------------------------------------------------------------------------

        //Get By Id
        [HttpGet("{id}")]
        public ActionResult<PersonDto> GetById(int id)
        {
            //Input validator, 0 <
            if (id <= 0)
            {
                return new StatusCodeResult(422);
            }

            Person? foundPerson = _personRepository.GetById(id);

            //if person is found
            if (foundPerson is not null)
            {
                PersonDto personDto = PersonDTOConverter.ConvertTo(foundPerson);
                return Ok(personDto);
            }

            //if not found
            else
            {
                return new StatusCodeResult(404);
            }
        }

        //getall by birthday async
        [HttpGet("{dateofbirth}")]
        public IEnumerable<PersonDto> GetAllByBirthdayAsync(DateTime datetime)
        {

            IEnumerable<Person> listPeople = _personRepository.GetAllByBirthday(datetime);
            List<PersonDto> listPeopleDto = new List<PersonDto>();
            foreach (Person person in listPeople)
            {
                listPeopleDto.Add(PersonDTOConverter.ConvertTo(person));
            }


            return listPeopleDto;
        }

        //-----------------------------------------------------------------------------
        /* Create / Post                                                              */
        //-----------------------------------------------------------------------------

        [HttpPost]
        public async Task<ActionResult> Create(PersonDto personDto)
        {
            Person person = PersonDTOConverter.ConvertFrom(personDto);
            Person personSaved = await _personRepository.CreateAsync(person);          
            if (personSaved is not null)
            {
                return Ok();
            }
            else
            {
                return new StatusCodeResult(304);
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