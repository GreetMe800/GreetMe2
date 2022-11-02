using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_DataAccess.Model
{
    public partial class Layout
    {
        public Layout()
        {
            ComponentPositions = new HashSet<ComponentPosition>();
        }

        public int ViewId { get; set; }
        public string LayoutName { get; set; } = null!;

        public virtual View View { get; set; } = null!;

        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }
    }
}
