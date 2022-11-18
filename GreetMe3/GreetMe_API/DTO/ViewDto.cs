

using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
<<<<<<< HEAD

=======
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
>>>>>>> Main_Sprint_3_asp_Spike
        public List<PersonDto> BirthdaysToday { get; set; }
        public List<PersonDto> AnniversariesToday { get; set; }

        public ViewDto()
        {

        }
<<<<<<< HEAD
        public ViewDto(int id, string viewName)
=======
        public ViewDto(int id, string viewName, bool hasBirthday, bool hasAnniversary)
        {
            Id = id;
            ViewName = viewName;
            HasBirthday = hasBirthday;
            HasAnniversary = hasAnniversary;
        }

        public ViewDto(string viewName, bool hasBirthday, bool hasAnniversary)
>>>>>>> Main_Sprint_3_asp_Spike
        {
            ViewName = viewName;
            HasBirthday = hasBirthday;
            HasAnniversary = hasAnniversary;
        }
    }
}
