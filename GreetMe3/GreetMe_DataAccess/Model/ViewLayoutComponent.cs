using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class ViewLayoutComponent
    {
        public int ViewId { get; set; }
        public int LayoutId { get; set; }
        public int ComponentId { get; set; }
        public int ComponentPosition { get; set; }

        public virtual Component Component { get; set; } = null!;
        public virtual Layout Layout { get; set; } = null!;
        public virtual View View { get; set; } = null!;
    }
}
