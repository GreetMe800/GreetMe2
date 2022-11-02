using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class LayoutDto
    {
        public int ViewId { get; set; }
        public string LayoutName { get; set; } = null!;
        public virtual ICollection<ComponentPositionDto> ComponentPositionDtos { get; set; }

        public LayoutDto()
        {

        }

        public LayoutDto(int id, string layoutName, ICollection<ComponentPositionDto> componentPositionDtos)
        {
            ViewId = id;
            LayoutName = layoutName;
            ComponentPositionDtos = componentPositionDtos;
        }
    }
}
