using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class PersonDTOConverter
    {
        //Convert to PersonDto (convert from database, getdata)
        public static PersonDto ConvertToDto(Person person)
        {
            PersonDto personDto = new PersonDto(
                person.Id,
                person.FullName,
                person.DateOfBirth,
                person.HiringDate
                );
            return personDto;
        }

        //Convert from PersonDto (convert to database, savedata)
        public static Person ConvertFromDto(PersonDto dto)
        {
            Person person = new Person();
            person.FullName = dto.FullName;
            person.DateOfBirth = dto.DateOfBirth;
            person.HiringDate = dto.HiringDate;
            return person;
        }
    }
}
