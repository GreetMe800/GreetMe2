using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public partial class ComponentView
    {
        public int ComponentId { get; set; }
        public int ViewId { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual View ComponentNavigation { get; set; } = null!;
    }
}
