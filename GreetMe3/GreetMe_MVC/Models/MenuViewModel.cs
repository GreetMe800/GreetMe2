using GreetMe_API.DTO;

namespace GreetMe_MVC.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = null!;
    }
}
