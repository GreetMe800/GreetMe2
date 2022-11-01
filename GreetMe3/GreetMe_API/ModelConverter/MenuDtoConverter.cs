using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class MenuDtoConverter
    {
        //Convert to MenuDto (convert from database, getdata) /\
        public static MenuDto ConvertToDto(Menu menu)
        {
            MenuDto menuDto = new MenuDto(
                menu.Id,
                menu.MenuName,
                menu.StartDate,
                menu.EndDate,
                menu.Description
                );
            return menuDto;
        }

        //Convert from MenuDto (convert to database, savedata) \/
        public static Menu ConvertFromDto(MenuDto dto)
        {
            Menu menu = new Menu();
            menu.MenuName = dto.MenuName;
            menu.StartDate = dto.StartDate;
            menu.EndDate = dto.EndDate;
            menu.Description = dto.Descriptionn;
            return menu;
        }
    }
}
