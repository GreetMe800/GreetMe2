using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GreetMe_API.ModelConversion
{
    public static class ScreenDTOConverter
    {
        //Convert to ScreenDto
        public static ScreenDto ConvertTo(Screen screen)
        {
            ViewDto viewDto = new ViewDto(
                screen.View.Id,
                screen.View.ViewName,
                screen.View.HasCurrentDatetime,
                screen.View.HasBirthday,
                screen.View.HasAnniversary,
                screen.View.HasMenu
                );
            ScreenDto screenDto = new ScreenDto(
                screen.Id,
                screen.ScreenName,
                viewDto
                );
            return screenDto;
        }

        //Convert from ScreenDto
        public static Screen ConvertFrom(ScreenDto dto)
        {
            Screen screen = new Screen();
            screen.Id = dto.Id;
            screen.ScreenName = dto.ScreenName;
            return screen;
        }
    }
}
