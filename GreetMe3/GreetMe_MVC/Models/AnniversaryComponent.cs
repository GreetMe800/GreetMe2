using GreetMe_API.DTO;

namespace GreetMe_MVC.Models
{
    public class AnniversaryComponent
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
    }
}
