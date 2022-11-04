using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class PersonDtoConverter
    {
        //Convert to PersonDto (convert from database, getdata) /\
        public static PersonDto ConvertToDto(Person person)
        {
            PersonDto personDto = new PersonDto()
            {
                FullName = person.FullName,
                DateOfBirth =  person.DateOfBirth,
                HiringDate = person.HiringDate,
                Email = person.Email
            };
            return personDto;
        }

        //Convert from PersonDto (convert to database, savedata) \/
        public static Person ConvertFromDto(PersonDto dto)
        {
            Person person = new Person() 
            {
                FullName = dto.FullName,
                DateOfBirth = dto.DateOfBirth,
                HiringDate = dto.HiringDate,
                Email = dto.Email
            };            
            return person;
        }
    }
}
