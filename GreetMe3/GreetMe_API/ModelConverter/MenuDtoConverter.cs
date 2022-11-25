using GreetMe_API.DTO;
using GreetMe_DataAccess.Model;

namespace GreetMe_API.ModelConverter
{
    public static class MenuDtoConverter
    {
        //Convert to MenuDto (convert from database, getdata) /\
        public static MenuDto ConvertToDto(Menu model)
        {
            MenuDto menuDto = new MenuDto() 
            {
                Id = model.Id,
                MenuName = model.MenuName,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Description = model.Description
            };
            return menuDto;
        }

        //Convert from MenuDto (convert to database, savedata) \/
        public static Menu ConvertToModel(MenuDto dto)
        {
            Menu menu = new Menu()
            {
                Id = dto.Id,
                MenuName = dto.MenuName,
                EndDate = dto.EndDate,
                StartDate = dto.StartDate,
                Description = dto.Description
            };
            return menu;
        }
    }
}
