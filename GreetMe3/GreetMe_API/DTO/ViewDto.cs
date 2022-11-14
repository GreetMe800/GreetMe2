

using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; } = null!;

        public List<PersonDto> BirthdaysToday { get; set; }

        public List<PersonDto> AnniversariesToday { get; set; }

        public ViewDto()
        {

        }
        public ViewDto(int id, string viewName)
        {
            Id = id;
            ViewName = viewName;
        }
    }
}
