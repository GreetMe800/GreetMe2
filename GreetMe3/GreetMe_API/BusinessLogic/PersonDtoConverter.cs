using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.BusinessLogic
{
    public static class PersonDtoConverter
    {
        //Convert to PersonDto (convert from database, getdata) /\
        public static PersonDto ConvertToDto(Person person)
        {
            PersonDto personDto = new PersonDto(
            person.Id,
            person.FullName,
            person.DateOfBirth,
            person.HiringDate,
            person.Email
            );
            return personDto;
        }
        //Convert to PersonDto with parameters (convert from database, getdata) /\
        public static PersonDto ConvertToDtoNameBirthdayOnly(Person person)
        {
            PersonDto personDto = new PersonDto(
            person.FullName,
            person.DateOfBirth
                );
            return personDto;
        }
        //Convert from PersonDto (convert to database, savedata) \/
        public static Person ConvertFromDto(PersonDto personDto)
        {
            Person person = new Person();
            person.FullName = personDto.FullName;
            person.DateOfBirth = personDto.DateOfBirth;
            person.HiringDate = personDto.HiringDate;
            person.Email = personDto.Email;
            return person;
        }

    }
}
