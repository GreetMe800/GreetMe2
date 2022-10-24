using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class ViewDTOConverter
    {
        //Convert to ViewDto
        public static ViewDto ConvertTo(View view)
        {
            ViewDto viewDto = new ViewDto(
                view.ViewName,
                view.HasCurrentDatetime,
                view.HasBirthday,
                view.HasAnniversary,
                view.HasMenu
                );
            return viewDto;
        }

        //Convert from ViewDto
        public static View ConvertFrom(ViewDto dto)
        {
            View view = new View();
            view.Id = dto.Id;
            view.ViewName = dto.ViewName;
            view.HasCurrentDatetime = dto.HasCurrentDatetime;
            view.HasBirthday = dto.HasBirthday;
            view.HasAnniversary = dto.HasAnniversary;
            view.HasMenu = dto.HasMenu;
            return view;
        }
    }
}
