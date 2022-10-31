using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    public partial class View
    {
        public View()
        {
            InverseLayout = new HashSet<View>();
        }

        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
        public int LayoutId { get; set; }

        public virtual View Layout { get; set; } = null!;
        public virtual ComponentView? ComponentView { get; set; }
        public virtual ICollection<View> InverseLayout { get; set; }
    }
}
