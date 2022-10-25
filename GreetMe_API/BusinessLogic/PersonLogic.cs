using GreetMe_API.ModelConversion;
using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using GreetMe_DataAccess.Repository;
using System;

namespace GreetMe_API.BusinessLogic
{
    
        public static class PersonLogic
        {
            //Birthday
            public static void GetAllByBirthday(IPersonRepository personRepository, ViewDto viewDto)
            {
                DateTime datetimeToday = DateTime.Now.ToUniversalTime();
                DateTime dateToday = new DateTime(datetimeToday.Year, datetimeToday.Month, datetimeToday.Day);

                IEnumerable<Person> birthPeople = personRepository.GetAllByBirthday(dateToday);
                List<PersonDto> birthPeopleDto = new List<PersonDto>();
                foreach (Person p in birthPeople)
                {
                    birthPeopleDto.Add(PersonDTOConverter.ConvertToDto(p));
                }
                viewDto.BirthdaysToday = birthPeopleDto;
            }

            //Anniversary
            public static void GetAllByAnniversary(IPersonRepository personRepository, ViewDto viewDto)
            {
                DateTime datetimeToday = DateTime.Now;
                DateTime dateToday = new DateTime(datetimeToday.Year, datetimeToday.Month, datetimeToday.Day);

                IEnumerable<Person> anniversaryPeople = personRepository.GetAllByAnniversary(dateToday);
                List<PersonDto> anniversaryPeopleDto = new List<PersonDto>();
                foreach (Person p in anniversaryPeople)
                {
                    anniversaryPeopleDto.Add(PersonDTOConverter.ConvertToDto(p));
                }
                viewDto.AnniversarysToday = anniversaryPeopleDto;
            }
        }
    
}
