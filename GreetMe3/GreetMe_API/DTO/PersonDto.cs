namespace GreetMe_API.DTO
{
    public class PersonDto
    {
        public int Id { get; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }

        public PersonDto()
        {

        }

        public PersonDto(int id, string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);

            Id = id;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
            Email = email;
        }

        public PersonDto(string fullName, DateTime dateOfBirth, DateTime hiringDate, string email)
        {
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);
            HiringDate = new DateTime(HiringDate.Year, HiringDate.Month, HiringDate.Day);

            FullName = fullName;
            DateOfBirth = dateOfBirth;
            HiringDate = hiringDate;
            Email = email;
        }
        public PersonDto(string fullName, DateTime dateOfBirth)
        {
            DateOfBirth = new DateTime(DateOfBirth.Year, DateOfBirth.Month, DateOfBirth.Day);

            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }
    }
}
