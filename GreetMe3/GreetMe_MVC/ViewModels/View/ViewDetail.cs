using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;
using GreetMe_MVC.Models;
using GreetMe_MVC.Stylesheet;

namespace GreetMe_MVC.ViewModels.View
{
    public class ViewDetail
    {

        public List<int> Style { get; set; }

        public int CurrentLocation { get; set; }    

        public ViewDetail(ViewDto viewDto) 
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
                {
                    //Components.Add(new MenuComponent(viewDto.Menu, cDto));
                }     
            }
        }
    }

