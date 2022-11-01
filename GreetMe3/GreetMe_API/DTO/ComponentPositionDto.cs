namespace GreetMe_API.DTO
{
    public class ComponentPositionDto
    {
        public int Id { get; set; }
        public int Position { get; set; }

        public ComponentPositionDto()
        {

        }

        public ComponentPositionDto(int id, int position)
        {
            Id = id;
            Position = position;
        }
    }

}
