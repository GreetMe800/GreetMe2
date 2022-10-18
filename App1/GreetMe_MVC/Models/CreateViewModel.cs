namespace GreetMe_MVC.Models
{
    public class CreateViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }


    }
}
