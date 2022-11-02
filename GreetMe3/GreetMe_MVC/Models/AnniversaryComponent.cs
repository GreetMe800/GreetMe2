using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;

namespace GreetMe_MVC.Models
{
    public class AnniversaryComponent : IComponent
    {
        public List<PersonDto> AnniversaryPeople;
        public AnniversaryComponent(List<PersonDto> anniversaryPeople)
        {
            AnniversaryPeople = anniversaryPeople;
        }

        public string getData()
        {
            string birthdays = "";
            foreach (PersonDto person in AnniversaryPeople)
            {
                birthdays += person.FullName + "har fødselsdag idag";
            }
            return birthdays;
        }

        public string getDataDouble()
        {
            string birthdays = "";
            foreach (PersonDto person in AnniversaryPeople)
            {
                birthdays += person.FullName + "har fødselsdag idag extra langt";
            }
            return birthdays;
        }
    }
}
