using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ViewDtoConverter
    {
        //Convert to ViewDto (convert from database, getdata) /\
        public static ViewDto ConvertToDto(View model)
        {

            ViewDto viewDto = new ViewDto()
            {
                Id = model.Id,
                ViewName = model.ViewName,
                HasBirthday = model.HasBirthday,
                HasAnniversary = model.HasAnniversary
            };
            return viewDto;
        }

        //Convert from ViewDto (convert to database, savedata) \/
        public static View ConvertToModel(ViewDto dto)
        {
            View view = new View()
            {
                Id = dto.Id,
                ViewName = dto.ViewName,
                HasBirthday = dto.HasBirthday,
                HasAnniversary = dto.HasAnniversary
            };
            return view;
        }
    }
}

