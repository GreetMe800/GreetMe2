

using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
        public virtual Layout Layout { get; set; } = null!;
        public virtual ICollection<Component> Components { get; set; }

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
