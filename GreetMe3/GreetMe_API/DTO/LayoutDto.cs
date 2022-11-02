using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class LayoutDto
    {
        public int ViewId { get; set; }
        public string LayoutName { get; set; } = null!;
        public virtual View View { get; set; } = null!;
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }

        public LayoutDto()
        {

        }

        public LayoutDto(int id, string layoutName, View view, ICollection<ComponentPosition> componentPositions)
        {
            ViewId = id;
            LayoutName = layoutName;
            View = view;
            ComponentPositions = componentPositions;
        }
    }
}
