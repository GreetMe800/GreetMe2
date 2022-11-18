using GreetMe_API.DTO;

namespace GreetMe_MVC.Models
{
    public class ViewViewModel
    {
        public int Id { get; set; }
        public string ViewName { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
    }
}
