using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;
using GreetMe_MVC.Models;
using GreetMe_MVC.Stylesheet;

namespace GreetMe_MVC.ViewModels.View
{
    public class ViewDetail
    {
        public List<IComponent> Components { get; set; }

        public List<int> Style { get; set; }

        public int CurrentLocation { get; set; }    

        public ViewDetail(ViewDto viewDto) 
        {
            CurrentLocation = 0;
            Components = new List<IComponent>();
            foreach(ComponentPositionDto cDto in viewDto.LayoutDto.ComponentPositionDtos) 
            {

                ////testCode
                PersonDto personDto = new PersonDto() 
                {
                    DateOfBirth = DateTime.Now,
                    FullName = "testperson1"
                };
                List<PersonDto> personDtos = new List<PersonDto>();
                personDtos.Add(personDto);
                viewDto.BirthdaysToday = personDtos;
                viewDto.AnniversariesToday = personDtos;

                if (cDto.ComponentDto.ComponentName == "birthday")               
                {
                    Components.Add(new BirthdayComponent(viewDto.BirthdaysToday, cDto));
                } 
                else if (cDto.ComponentDto.ComponentName == "anniversary")
                {
                    Components.Add(new AnniversaryComponent(viewDto.AnniversariesToday, cDto));
                }
                else if (cDto.ComponentDto.ComponentName == "Menu") 
                {
                    //Components.Add(new MenuComponent(viewDto.Menu, cDto));
                }     
            }
        }
    }
}
