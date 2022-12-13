using GreetMe_API.DTO;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_MVC.Models
{
    public class AnniversaryViewModel : IDisplayItem
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }
        public string DisplayText { get => FullName; set => throw new NotImplementedException(); }
        public string SubText { get => HiringDate.ToString("dd/MM/yyyy"); set => throw new NotImplementedException(); }
    }
}
