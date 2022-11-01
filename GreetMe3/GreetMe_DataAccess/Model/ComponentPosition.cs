using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public partial class ComponentPosition
    {
        public ComponentPosition()
        {
            Components = new HashSet<Component>();
        }

        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public int ComponentId { get; set; }

        public virtual Component Component { get; set; } = null!;

        public virtual ICollection<Component> Components { get; set; }
    }
}
