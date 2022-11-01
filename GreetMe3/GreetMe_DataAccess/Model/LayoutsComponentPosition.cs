using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public partial class LayoutsComponentPosition
    {
        public int ComponentId { get; set; }
        public int ComponentPositionId { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual ComponentPosition ComponentPosition { get; set; } = null!;
    }
}
