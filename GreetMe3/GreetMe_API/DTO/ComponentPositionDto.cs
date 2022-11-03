using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentPositionDto
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public int ComponentId { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public virtual ComponentDto? ComponentDto { get; set; } 


        public ComponentPositionDto()
        {

        }
        public ComponentPositionDto(int id, int position, int width, int height, ComponentDto componentDto)
        {
            Id = id;
            Position = position;
            Width = width;
            Height = height;
            ComponentDto = componentDto;
        }


    }
}
