using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class PersonDTOConverter
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

        //Convert from PersonDto (convert to database, savedata) \/
        public static Person ConvertFromDto(PersonDto dto)
        {
            Person person = new Person();
            person.FullName = dto.FullName;
            person.DateOfBirth = dto.DateOfBirth;
            person.HiringDate = dto.HiringDate;
            person.Email = dto.Email;
            return person;
        }
    }
}
