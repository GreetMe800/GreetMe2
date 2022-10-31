using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_DataAccess.Model
{
    public partial class Layout
    {
        public int Id { get; set; }
        public string LayoutName { get; set; } = null!;
    }
}
