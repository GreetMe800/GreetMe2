using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GreetMe_DataAccess.Model
{
    [Table("layouts")]
    public class Layout
    {
        public Layout()
        {
            ComponentPositions = new HashSet<ComponentPosition>();
        }

        //id
        [Key]
        [Required]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        //name
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string LayoutName { get; set; } = null!;

        /* Many to One relations */
        //views
        public virtual ICollection<View> Views { get; set; } = new List<View>();

        /* Many to Many relations */
        //Component Position
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }
    }
}
