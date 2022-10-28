namespace GreetMe_API.DTO
{
    public class LayoutDto
    {
        public int Id { get; }
        public string LayoutName { get; set; }
        
        public LayoutDto()
        {

        }

        public LayoutDto(int id, string layoutName)
        {
            Id = id;
            LayoutName = layoutName;
        }
    }
}
