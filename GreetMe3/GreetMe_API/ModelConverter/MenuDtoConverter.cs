using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class MenuDtoConverter
    {
        //Convert to MenuDto (convert from database, getdata) /\
        public static MenuDto ConvertToDto(Menu menu)
        {
            MenuDto menuDto = new MenuDto() 
            {
                Id = menu.Id,
                MenuName = menu.MenuName,
                StartDate = menu.StartDate,
                EndDate = menu.EndDate,
                Description = menu.Description
            };
            return menuDto;
        }

        //Convert from MenuDto (convert to database, savedata) \/
        public static Menu ConvertToModel(MenuDto dto)
        {
            Menu menu = new Menu()
            {
                MenuName = dto.MenuName,
                EndDate = dto.EndDate,
                StartDate = dto.StartDate,
                Description = dto.Description
            };
            return menu;
        }
    }
}
