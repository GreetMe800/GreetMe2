using GreetMe_DataAccess.DTO;

namespace GreetMe_MVC.Models.Home
{
    public class IndexModel
    {
        public IndexModel()
        {
            //Screens = new HashSet<Screen>();
        }

        public IndexModel(ViewDto viewDto)
        {
            ViewName = viewDto.ViewName;
            HasCurrentDatetime = viewDto.HasCurrentDatetime;
            HasBirthday = viewDto.HasBirthday;
            HasAnniversary = viewDto.HasAnniversary;
            HasMenu = viewDto.HasMenu;
        }

        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

        //public virtual ICollection<Screen> Screens { get; set; }
    }
}
