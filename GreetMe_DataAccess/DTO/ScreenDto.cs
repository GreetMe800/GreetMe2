using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DTO
{
    public class ScreenDto
    {
        public int Id { get; set; }
        public string ScreenName { get; set; }
        public ViewDto View { get; set; }

        public ScreenDto()
        {

        }

        public ScreenDto(int id, string screenName, ViewDto view)
        {
            Id = id;
            ScreenName = screenName;
            View = view;
        }
    }
}
