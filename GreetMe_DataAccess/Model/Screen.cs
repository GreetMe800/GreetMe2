using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class Screen
    {
        public int Id { get; set; }
        public string ScreenName { get; set; } = null!;
        public int? ViewId { get; set; }

        public virtual View? View { get; set; }
    }
}
