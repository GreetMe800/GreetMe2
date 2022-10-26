using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class ViewDTOConverter
    {
        //Convert to ViewDto
        public static ViewDto ConvertTo(View view)
        {
            ViewDto viewDto = new ViewDto();
            viewDto.Id = view.Id;
            viewDto.ViewName = view.ViewName;
            viewDto.HasCurrentDatetime = view.HasCurrentDatetime;
            viewDto.HasBirthday = view.HasBirthday;
            viewDto.HasAnniversary = view.HasAnniversary;
            viewDto.HasMenu = view.HasMenu;
            return viewDto;
        }

        //Convert from ViewDto
        public static View ConvertFrom(ViewDto dto)
        {
            View view = new View();
            view.ViewName = dto.ViewName;
            view.HasCurrentDatetime = dto.HasCurrentDatetime;
            view.HasBirthday = dto.HasBirthday;
            view.HasAnniversary = dto.HasAnniversary;
            view.HasMenu = dto.HasMenu;
            return view;
        }
    }
}
