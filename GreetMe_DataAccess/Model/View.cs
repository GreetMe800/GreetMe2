using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class View
    {
        public View()
        {
            Screens = new HashSet<Screen>();
        }

        public int Id { get; set; }
        public string ViewName { get; set; } = null!;
        public bool HasCurrentDatetime { get; set; }
        public bool HasBirthday { get; set; }
        public bool HasAnniversary { get; set; }
        public bool HasMenu { get; set; }

        public virtual ICollection<Screen> Screens { get; set; }
    }
}
