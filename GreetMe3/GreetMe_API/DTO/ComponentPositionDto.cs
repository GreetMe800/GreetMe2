using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentPositionDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }
        public virtual ICollection<View> Views { get; set; }

        public ComponentPositionDto()
        {

        }
        public ComponentPositionDto(int id, string componentName, ICollection<ComponentPosition> componentPositions, ICollection<View> views)
        {
            Id = id;
            ComponentName = componentName;
            ComponentPositions = componentPositions;
            Views = views;
        }


    }
}
