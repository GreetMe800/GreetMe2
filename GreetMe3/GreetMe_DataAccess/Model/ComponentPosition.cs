using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public partial class ComponentPosition
    {
        public ComponentPosition()
        {
            Layouts = new HashSet<Layout>();
        }

        public int Id { get; set; }
        public int Position { get; set; }
        public int ComponentId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual Component Component { get; set; } = null!;

        public virtual ICollection<Layout> Layouts { get; set; }
    }
}
