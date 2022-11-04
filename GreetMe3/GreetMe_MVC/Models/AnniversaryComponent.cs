using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;

namespace GreetMe_MVC.Models
{
    public class AnniversaryComponent : IComponent
    {

    
        public int Position { get; set; }

        public List<PersonDto> AnniversaryPeople;
        public AnniversaryComponent(List<PersonDto> anniversaryPeople, ComponentPositionDto componentPositionDto)
        {
            AnniversaryPeople = anniversaryPeople;
            Position = componentPositionDto.Position;
        }

        public string getData()
        {
            string birthdays = "";
            foreach (PersonDto person in AnniversaryPeople)
            {
                birthdays += person.FullName + "har jubilæum";
            }
            return birthdays;
        }

        public string getDataDouble()
        {
            string birthdays = "";
            foreach (PersonDto person in AnniversaryPeople)
            {
                birthdays += person.FullName + "har jubilæum idag";
            }
            return birthdays;
        }
    }
}
