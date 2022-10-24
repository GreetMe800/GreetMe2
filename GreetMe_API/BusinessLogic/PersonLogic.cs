using GreetMe_API.ModelConversion;
using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;
using System;

namespace GreetMe_API.BusinessLogic
{
    public static class PersonLogic
    {
        //Anniversary
        public static IEnumerable<PersonDto> GetAllByAnniversary(IPersonRepository personRepository, DateTime datetime)
        {
            datetime = new DateTime(datetime.Year, datetime.Month, datetime.Day);

            IEnumerable<Person> listPeople = personRepository.GetAllByAnniversary(datetime);
            List<PersonDto> listPeopleDto = new List<PersonDto>();

            foreach (Person person in listPeople)
            {
                listPeopleDto.Add(PersonDTOConverter.ConvertToDto(person));
            }

            return listPeopleDto;
        }

        //Birthday
        public static IEnumerable<PersonDto> GetAllByBirthday(IPersonRepository personRepository, DateTime datetime)
        {
            datetime = new DateTime(datetime.Year, datetime.Month, datetime.Day);

            IEnumerable<Person> listPeople = personRepository.GetAllByBirthday(datetime);
            List<PersonDto> listPeopleDto = new List<PersonDto>();

            foreach (Person person in listPeople)
            {
                listPeopleDto.Add(PersonDTOConverter.ConvertToDto(person));
            }

            return listPeopleDto;
        }
    }
}
