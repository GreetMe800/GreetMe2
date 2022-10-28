using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class Component
    {
        public int Id { get; set; }
        public string ComponentName { get; set; } = null!;
    }
}
