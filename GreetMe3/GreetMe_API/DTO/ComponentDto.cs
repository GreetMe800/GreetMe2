namespace GreetMe_API.DTO
{
    public class ComponentDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; }
 
        public ComponentDto()
        {
            
        }
        public ComponentDto(int id, string componentName)
        {
            Id = id;
            ComponentName = componentName;
        }


    }
}
