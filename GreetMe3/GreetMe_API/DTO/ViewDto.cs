

using GreetMe_DataAccess.Model;

namespace GreetMe_API.DTO
{
    public class ViewDto
    {
        public int? Id { get; set; }
        public string ViewName { get; set; } = null!;
        public virtual LayoutDto? LayoutDto { get; set; }

        public ViewDto()
        {

        }
        public ViewDto(int id, string viewName, LayoutDto layoutDto)
        {
            Id = id;
            ViewName = viewName;
            LayoutDto = layoutDto;
        }
    }
}
