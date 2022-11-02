namespace GreetMe_API.DTO
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = null!;

        public MenuDto()
        {

        }

        public MenuDto(int id, string menuName, DateTime startDate, DateTime? endDate, string description)
        {
            Id = id;
            MenuName = menuName;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }

    }
}
