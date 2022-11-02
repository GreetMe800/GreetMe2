using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public virtual ICollection<ComponentPositionDto> ComponentPositionDtos { get; set; }
        public virtual ICollection<ViewDto> ViewDtos { get; set; }

        public ComponentDto()
        {
            
        }
        


    }
}
