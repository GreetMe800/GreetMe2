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
<<<<<<< HEAD
            };
            return viewDto;
        }

        //Convert to ViewDto with Dep (convert from database, getdata) /\
        public static ViewDto ConvertToDtoWithDep(View view)
        {
            ViewDto viewDto = new ViewDto()
            {
                Id = view.Id,
                ViewName = view.ViewName,
=======
                HasBirthday = view.HasBirthday,
                HasAnniversary = view.HasAnniversary
>>>>>>> Main_Sprint_3_asp_Spike
            };
            return viewDto;
        }

        //Convert from ViewDto (convert to database, savedata) \/
        public static View ConvertToModel(ViewDto viewDto)
        {
            View view = new View()
            {
                ViewName = viewDto.ViewName,
<<<<<<< HEAD
            };
            return view;
        }

        //Convert from ViewDto with Dep (convert to database, savedata) \/
        public static View ConvertFromDtoWithDep(ViewDto viewDto)
        {
            View view = new View()
            {
                ViewName = viewDto.ViewName,
=======
                HasBirthday = viewDto.HasBirthday,
                HasAnniversary = viewDto.HasAnniversary
>>>>>>> Main_Sprint_3_asp_Spike
            };
            return view;
        }
    }
}

