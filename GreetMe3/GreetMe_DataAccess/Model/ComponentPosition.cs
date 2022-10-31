using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.Model
{
    public class ComponentPosition
    {
        public ComponentPosition()
        {
            Layouts = new HashSet<Layout>();
        }

        //id
        [Key]
        [Required]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        //position
        [Required]
        [Column(TypeName = "INT")]
        public int Position { get; set; }

        /* one to Many relation */
        //layout
        [Required]
        [Column(TypeName = "INT")]
        public int ComponentId { get; set; }
        [ForeignKey("ComponentId")]
        public Component Component { get; set; } = null!;

        /* Many to Many relations */
        //Component Position
        public virtual ICollection<Layout> Layouts { get; set; }
    }
}
