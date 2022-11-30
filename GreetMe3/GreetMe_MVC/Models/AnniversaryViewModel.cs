using GreetMe_API.DTO;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_MVC.Models
{
    public class AnniversaryViewModel : IDisplayItem
    {
        //Lav PersonDto med parametre til anniversary + birthday view model.
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime HiringDate { get; set; }
        public string DisplayText { get => FullName; set => throw new NotImplementedException(); }
        public string SubText { get => HiringDate.ToString(); set => throw new NotImplementedException(); }
    }
}
