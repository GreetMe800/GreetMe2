using GreetMe_API.DTO;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_MVC.Models
{
    public class BirthdayViewModel : IDisplayItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string DisplayText { get => FullName; set => throw new NotImplementedException(); }
        public string SubText { get =>  DateOfBirth.ToString("dd/MM/yyyy"); set => throw new NotImplementedException(); }

    }
}