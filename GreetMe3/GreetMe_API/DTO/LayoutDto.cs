using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class LayoutDto
    {
        public int ViewId { get; set; }
        public string LayoutName { get; set; } = null!;
        public virtual List<ComponentPositionDto> ComponentPositionDtos { get; set; }


        public LayoutDto()
        {
            ComponentPositionDtos = new List<ComponentPositionDto>();
        }

        public LayoutDto(int id, string layoutName, List<ComponentPositionDto> componentPositionDtos)
        {
            ViewId = id;
            LayoutName = layoutName;
            ComponentPositionDtos = componentPositionDtos;
        }
    }
}
