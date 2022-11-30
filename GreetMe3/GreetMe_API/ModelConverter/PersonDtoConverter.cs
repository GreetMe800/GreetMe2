using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class PersonDtoConverter
    {
        //Convert to PersonDto for BirthdayComponent (convert from database, getdata) /\
        public static PersonDto ConvertToDto_Birthday(Person model)
        {
            PersonDto personDto = new PersonDto()
            {
                Id = model.Id,
                FullName = model.FullName,
                DateOfBirth =  model.DateOfBirth,
            };
            return personDto;
        }

        //Convert to PersonDto for AnniversaryyComponent (convert from database, getdata) /\
        public static PersonDto ConvertToDto_Anniversary(Person model)
        {
            PersonDto personDto = new PersonDto()
            {
                Id = model.Id,
                FullName = model.FullName,
                HiringDate = model.HiringDate,
            };
            return personDto;
        }

        //Convert to PersonDto (convert from database, getdata) /\
        public static PersonDto ConvertToDto(Person model)
        {
            PersonDto personDto = new PersonDto()
            {
                Id = model.Id,
                FullName = model.FullName,
                DateOfBirth = model.DateOfBirth,
                HiringDate = model.HiringDate,
                Email = model.Email
            };
            return personDto;
        }

        //Convert from PersonDto (convert to database, savedata) \/
        public static Person ConvertToModel(PersonDto dto)
        {
            Person person = new Person() 
            {
                Id = dto.Id,
                FullName = dto.FullName,
                DateOfBirth = dto.DateOfBirth,
                HiringDate = dto.HiringDate,
                Email = dto.Email
            };            
            return person;
        }
    }
}
