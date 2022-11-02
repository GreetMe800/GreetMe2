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
            Views = new HashSet<View>();
            ComponentPositions = new HashSet<ComponentPosition>();
        }

        public int Id { get; set; }
        public string LayoutName { get; set; } = null!;

        public virtual ICollection<View> Views { get; set; }

        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }
    }
}
