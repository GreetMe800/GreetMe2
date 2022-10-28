using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Decription { get; set; } = null!;
    }
}
