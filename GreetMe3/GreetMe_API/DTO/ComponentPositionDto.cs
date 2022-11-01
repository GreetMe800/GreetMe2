using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentPositionDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public virtual Component Component { get; set; } = null!;

        public ComponentPositionDto()
        {

        }

        public ComponentPositionDto(int id, string componentName, Component component)
        {
            Id = id;
            ComponentName = componentName;
            Component = component;
        }
    }

}
