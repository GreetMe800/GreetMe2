using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    [Table("menus")]
    public class Menu
    {
        //id
        [Required]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        //menuname
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string MenuName { get; set; } = null!;

        //startdate
        [Required]
        [Column(TypeName = "DATE")]
        public DateTime StartDate { get; set; }

        //enddate
        [Column(TypeName = "DATE")]
        public DateTime? EndDate { get; set; }

        //decription
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(1000)]
        public string Description { get; set; } = null!;
    }
}
