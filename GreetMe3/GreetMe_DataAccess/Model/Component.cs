using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    [Table("components")]
    public class Component
    {
        public Component()
        {
            ComponentPositions = new HashSet<ComponentPosition>();
            Views = new HashSet<View>();
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
        public string ComponentName { get; set; } = null!;

        /* Many to One relations */
        //views
        public virtual ICollection<ComponentPosition> ComponentPositions { get; set; }

        /* Many to Many relations */
        //Component Position
        public virtual ICollection<View> Views { get; set; }
    }
}
