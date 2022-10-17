using GreetMe_DataAccess.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConversion
{
    public static class ScreenDTOConverter
    {
        //Convert to PersonDto
        public static ScreenDto ConvertTo(Screen screen)
        {
            ScreenDto screenDto = new ScreenDto(
                screen.Id,
                screen.ScreenName
                );
            return screenDto;
        }

        //Convert from PersonDto
        public static Screen ConvertFrom(ScreenDto screen)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
