using GreetMe_DataAccess.DTO;
using System.Drawing;

namespace GreetMe_MVC.Models.View
{
    public class DetailViewModel
    {

        public int Id { get; set; }
        public string ViewName { get; set; }
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

        public List<PersonDto> BirthdaysToday { get; set; }

        public List<PersonDto> AnniversarysToday { get; set; }



        public DetailViewModel(ViewDto viewDto) 
        {
            BirthdaysToday = new List<PersonDto>();
            AnniversarysToday = new List<PersonDto>();
            //Id = viewDto.Id;
            //ViewName = viewDto.ViewName;
            //HasCurrentDatetime = viewDto.HasCurrentDatetime;
            //BirthdaysToday = viewDto.BirthdaysToday;
            //AnniversarysToday = viewDto.AnniversarysToday;
            HasAnniversary = false;
            HasBirthday = true;
            PersonDto dto = new PersonDto()
            {
                DateOfBirth = DateTime.Now,
                HiringDate = DateTime.Now,
                FullName = "agemam",
                Id = 2

            };

            PersonDto dto2 = new PersonDto()
            {
                DateOfBirth = DateTime.Now,
                HiringDate = DateTime.Now,
                FullName = "agemamnon",
                Id = 2

            };

            AnniversarysToday.Add(dto);
            BirthdaysToday.Add(dto2);



        }



    }
}
