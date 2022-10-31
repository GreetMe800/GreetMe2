using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    [Table("views")]
    public class View
    {
        public View()
        {
            Components = new HashSet<Component>();
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
        public string ViewName { get; set; } = null!;

        /* One to Many relation */
        //layout
        [Required]
        [Column(TypeName = "INT")]
        public int LayoutId { get; set; }
        [ForeignKey("LayoutId")]
        public Layout Layout { get; set; } = null!;

        /* Many to mmany relations */
        //components
        public virtual ICollection<Component> Components { get; set; }
    }
}
