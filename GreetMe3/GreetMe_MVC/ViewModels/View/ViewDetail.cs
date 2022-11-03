using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;
using GreetMe_MVC.Models;

namespace GreetMe_MVC.ViewModels.View
{
    public class ViewDetail
    {
        public List<IComponent> components { get; set; }

        public string[,] Style { get; set; }

        public int CurrentLocation { get; set; }    

        public ViewDetail(ViewDto viewDto) 
        {
            CurrentLocation = 0;
            components = new List<IComponent>();
            foreach(ComponentDto cDto in viewDto.ComponentDtos) 
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

                if (cDto.ComponentName == "birthday")
                
                {
                    components.Add(new BirthdayComponent(viewDto.BirthdaysToday));
                } 
                else if (cDto.ComponentName == "anniversary")
                {
                    components.Add(new BirthdayComponent(viewDto.AnniversarysToday));
                }
                else if (cDto.ComponentName == "Menu") 
                {
                    components.Add(new MenuComponent(viewDto.Menu));
                }     
            }
        }
    }
}
