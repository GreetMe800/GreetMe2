using GreetMe_API.DTO;

namespace GreetMe_MVC.Models
{
    public class DetailViewModel
    {

        public int Id { get; set; }
        public string ViewName { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public List<PersonDto> BirthdaysToday { get; set; }
        public List<PersonDto> AnniversariesToday { get; set; }

        public DetailViewModel(ViewDto viewDto)
        {
            HasBirthday = viewDto.HasBirthday;
            HasAnniversary = viewDto.HasAnniversary;
            ViewName = viewDto.ViewName;
            BirthdaysToday = viewDto.BirthdaysToday;
            AnniversariesToday = viewDto.AnniversariesToday;
        }
    }
}