using GreetMe_API.DTO;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_MVC.Models
{
    public class PersonViewModel : IDisplayItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }
        public string DisplayText { get => FullName; set => throw new NotImplementedException(); }
        public string SubText { get => HiringDate.ToString(); set => throw new NotImplementedException(); }
    }
}
