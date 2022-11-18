using GreetMe_API.DTO;

namespace GreetMe_MVC.Models
{
    public class PersonViewModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }
    }
}
