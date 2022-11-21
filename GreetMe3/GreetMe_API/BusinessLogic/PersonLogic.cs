using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using GreetMe_DataAccess.Interface;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.BusinessLogic
{
    public static class PersonLogic
    {
        //Birthday component logic
        public async static void GetAllByBirthday(IPersonRepository personRepository, ViewDto viewDto)
        {
            DateTime datetimeToday = DateTime.Now.ToUniversalTime();
            DateTime dateToday = new DateTime(datetimeToday.Year, datetimeToday.Month, datetimeToday.Day);

            IEnumerable<Person> birthdayPeople = await personRepository.GetAllByBirthday(dateToday);
            List<PersonDto> birthdayPeopleDto = new List<PersonDto>();
            foreach (Person p in birthdayPeople)
            {
                birthdayPeopleDto.Add(PersonDtoConverter.ConvertToDto(p));
            }
            viewDto.BirthdaysToday = birthdayPeopleDto;
        }

        //Anniversary component logic
        public async static void GetAllByAnniversary(IPersonRepository personRepository, ViewDto viewDto)
        {
            DateTime datetimeToday = DateTime.Now;
            DateTime dateToday = new DateTime(datetimeToday.Year, datetimeToday.Month, datetimeToday.Day);

            IEnumerable<Person> anniversaryPeople = await personRepository.GetAllByAnniversary(dateToday);
            List<PersonDto> anniversaryPeopleDto = new List<PersonDto>();
            foreach (Person p in anniversaryPeople)
            {
                anniversaryPeopleDto.Add(PersonDtoConverter.ConvertToDto(p));
            }
            viewDto.AnniversariesToday = anniversaryPeopleDto;
        }
    }
}
