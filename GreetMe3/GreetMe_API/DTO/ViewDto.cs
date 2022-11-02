

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; }
        public List<ComponentDto> Components { get; set; }
        public List<PersonDto>? BirthdaysToday { get; set; }
        public List<PersonDto>? AnniversarysToday { get; set; }
        public MenuDto Menu { get; set; }


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
