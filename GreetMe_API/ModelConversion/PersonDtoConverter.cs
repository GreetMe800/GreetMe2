using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class PersonDTOConverter
    {
        //Convert to PersonDto
        public static PersonDto ConvertTo(Person person)
        {
            PersonDto personDto = new PersonDto(
                person.Id,
                person.FullName,
                person.DateOfBirth,
                person.HiringDate
                );
            return personDto;
        }

        //Convert from PersonDto
        public static Person ConvertFrom(PersonDto dto)
        {
            Person person = new Person();
            person.Id = dto.Id;
            person.FullName = dto.FullName;
            person.DateOfBirth = dto.DateOfBirth;
            person.HiringDate = dto.HiringDate;
            return person;
        }
    }
}
