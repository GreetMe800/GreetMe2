using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class ScreenDTOConverter
    {
        //Convert to ScreenDto
        public static ScreenDto ConvertTo(Screen screen)
        {
            ScreenDto screenDto = new ScreenDto(
                screen.Id,
                screen.ScreenName
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
