using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ComponentDto
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;

        //public List<object> ComponentObjects { get; set; } lav senere

        public ComponentDto()
        {

        }

        
        


    }
}
