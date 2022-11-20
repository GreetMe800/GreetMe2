using GreetMe_API.DTO;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_MVC.Models
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = null!;
    }
}
