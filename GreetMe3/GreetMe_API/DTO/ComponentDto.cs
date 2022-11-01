using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }

        public virtual ICollection<View> Views { get; set; }

        public ComponentDto()
        {
            
        }
        public ComponentDto(int id, string componentName, ICollection<ComponentPosition> componentPositions, ICollection<View> views)
        {
            Id = id;
            ComponentName = componentName;
            ComponentPositions = componentPositions;
            Views = views;
        }


    }
}
