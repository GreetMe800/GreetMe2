

using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }

        //public List<PersonDto> BirthdaysToday { get; set; }

        //public List<PersonDto> AnniversariesToday { get; set; }

        public ViewDto()
        {

        }
        public ViewDto(int id, string viewName, bool hasBirthday, bool hasAnniversary)
        {
            Id = id;
            ViewName = viewName;
            HasBirthday = hasBirthday;
            HasAnniversary = hasAnniversary;
        }

        public ViewDto(string viewName, bool hasBirthday, bool hasAnniversary)
        {
            ViewName = viewName;
            HasBirthday = hasBirthday;
            HasAnniversary = hasAnniversary;
        }
    }
}
