using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DTO
{
    public class ViewDto
    {
        public int? Id { get; set;}
        public string ViewName { get; set; }
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

        public List<PersonDto>? BirthdaysToday { get; set; }

        public List<PersonDto>? AnniversarysToday { get; set; }

        // TODO: Tilføj menu object med hvilken uge det er og menuen for de dage

        public ViewDto()
        {

        }


        public ViewDto(int id, string viewName, bool hasCurrentDateTime, bool hasBirthDay, bool hasAnniversary, bool hasMenu)
        {
            Id = id;
            ViewName = viewName;
            HasCurrentDatetime = hasCurrentDateTime;
            HasBirthday = hasBirthDay;
            HasAnniversary = hasAnniversary;
            HasMenu = hasMenu;
        }



        public ViewDto(string viewName, bool hasCurrentDateTime, bool hasBirthDay, bool hasAnniversary, bool hasMenu)
        {
            ViewName = viewName;
            HasCurrentDatetime = hasCurrentDateTime;
            HasBirthday = hasBirthDay;
            HasAnniversary = hasAnniversary;
            HasMenu = hasMenu;

        }


        public ViewDto(int? id, string viewName, bool hasCurrentDatetime, bool hasBirthday, bool hasAnniversary, bool hasMenu)
        {
            Id = id;
            ViewName = viewName;
            HasCurrentDatetime = hasCurrentDatetime;
            HasBirthday = hasBirthday;
            HasAnniversary = hasAnniversary;
            HasMenu = hasMenu;
        }
    }
}
