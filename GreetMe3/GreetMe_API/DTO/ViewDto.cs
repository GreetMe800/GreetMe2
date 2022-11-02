

using GreetMe_DataAccess.Model;

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
        public virtual Layout? Layout { get; set; }

        public ViewDto()
        {

        }
        public ViewDto(int id, string viewName, Layout layout, ICollection<Component> components)
        {
            Id = id;
            ViewName = viewName;
            Layout = layout;
            Components = components;
        }
    }
}
