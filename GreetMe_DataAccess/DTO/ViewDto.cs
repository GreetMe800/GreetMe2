using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DTO
{
    public class ViewDto
    {
        public int Id { get; set; }
        public string ViewName { get; set; }
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

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
    }
}
