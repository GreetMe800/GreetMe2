using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    public partial class View
    {
        public int Id { get; set; }
        public string ViewName { get; set; } = null!;

        public virtual Layout? Layout { get; set; }
    }
}
