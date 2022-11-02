using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class LayoutDto
    {
        public int Id { get; set; }
        public string LayoutName { get; set; } = null!;
        public virtual ICollection<View> Views { get; set; }
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }

        public LayoutDto()
        {

        }

        public LayoutDto(int id, string layoutName, ICollection<View> views, ICollection<ComponentPosition> componentPositions)
        {
            Id = id;
            LayoutName = layoutName;
            Views = views;
            ComponentPositions = componentPositions;
        }
    }
}
