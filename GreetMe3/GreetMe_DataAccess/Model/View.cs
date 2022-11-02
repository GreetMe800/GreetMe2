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
            Components = new HashSet<Component>();
        }

        public int Id { get; set; }
        public string ViewName { get; set; } = null!;

        public virtual Layout? Layout { get; set; }

        public virtual ICollection<Component> Components { get; set; }
    }
}
