using GreetMe_API.DTO;
using GreetMe_MVC.Interfaces;

namespace GreetMe_MVC.Models
{
    public class BirthdayComponent : IComponent
    {
        public List<PersonDto> BirthdayPeople;
        public BirthdayComponent(List<PersonDto> birthdayPeople)
        {
            BirthdayPeople = birthdayPeople;
        }

        public string getData()
        {
            string birthdays = "";
            foreach (PersonDto person in BirthdayPeople)
            {
                birthdays += person.FullName + "har fødselsdag idag ";
            }
            return birthdays;
        }

        public string getDataDouble()
        {
            string birthdays = "";
            foreach (PersonDto person in BirthdayPeople)
            {
                birthdays += person.FullName + "har fødselsdag idag eksta langt";
            }
            return birthdays;
        }
    }
}
