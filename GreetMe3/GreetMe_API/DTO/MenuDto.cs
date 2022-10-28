namespace GreetMe_API.DTO
{
    public class MenuDto
    {
        public int Id { get; }
        public string MenuName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Descriptionn { get; set; }

        public MenuDto()
        {

        }

        public MenuDto(int id, string menuName, DateTime startDate, DateTime? endDate, string description)
        {
            Id = id;
            MenuName = menuName;
            StartDate = startDate;
            EndDate = endDate;
            Descriptionn = description;
        }

    }
}
