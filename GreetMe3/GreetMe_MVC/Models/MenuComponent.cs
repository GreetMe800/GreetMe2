using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace GreetMe_MVC.Models
{
    public class MenuComponent : IComponent
    {

        public MenuDto MenuDto { get; set; }

        MenuComponent(MenuDto menuDto) 
        {
            MenuDto = menuDto;
        }

        public string getData()
        {
            string Menu = MenuDto.MenuName + "\n" + "Menuen fra d. " + MenuDto.StartDate + " til d." + MenuDto.EndDate + "\n" + MenuDto.Descriptionn;
            return Menu;
        }
    }
}
