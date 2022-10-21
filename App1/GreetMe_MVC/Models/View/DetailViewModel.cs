using GreetMe_DataAccess.DTO;
using System.Drawing;

namespace GreetMe_MVC.Models.View
{
    public class DetailViewModel
    {

        public int Id { get; set; }
        public string ViewName { get; set; }
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

        public List<PersonDto> BirthdaysToday { get; set; }

        public List<PersonDto> AnniversarysToday { get; set; }



        public DetailViewModel(ViewDto viewDto) 
        {
            HasBirthday = viewDto.HasBirthday; 
            HasAnniversary = viewDto.HasAnniversary;
            ViewName = viewDto.ViewName;
            HasCurrentDatetime = viewDto.HasCurrentDatetime;
            BirthdaysToday = viewDto.BirthdaysToday;
            AnniversarysToday = viewDto.AnniversarysToday;
        }



    }
}
