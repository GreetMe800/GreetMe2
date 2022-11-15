using GreetMe_API.DTO;
using GreetMe_API.ModelConverter;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class ViewDtoConverter
    {
        //Convert to ViewDto (convert from database, getdata) /\
        public static ViewDto ConvertToDto(View view)
        {

            ViewDto viewDto = new ViewDto()
            {
                Id = view.Id,
                ViewName = view.ViewName,
                HasBirthday = view.HasBirthday,
                HasAnniversary = view.HasAnniversary
            };
            return viewDto;
        }

        //Convert from ViewDto (convert to database, savedata) \/
        public static View ConvertFromDto(ViewDto viewDto)
        {
            View view = new View()
            {
                ViewName = viewDto.ViewName,
                HasBirthday = viewDto.HasBirthday,
                HasAnniversary = viewDto.HasAnniversary
            };
            return view;
        }
    }
}

