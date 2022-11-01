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
            LayoutsComponentPositions = new HashSet<LayoutsComponentPosition>();
        }

        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
        public int ComponentId { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual ICollection<LayoutsComponentPosition> LayoutsComponentPositions { get; set; }
    }
}
