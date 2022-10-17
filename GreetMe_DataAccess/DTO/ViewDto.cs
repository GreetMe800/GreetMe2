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

        public ViewDto()
        {

        }

        public ViewDto(int id, string viewName)
        {
            Id = id;
            ViewName = viewName;
        }
    }
}
