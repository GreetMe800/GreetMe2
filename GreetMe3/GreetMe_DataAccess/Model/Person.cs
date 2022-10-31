using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    [Table("persons")]
    public class Person
    {
        //id
        [Key]
        [Required]
        [Column(TypeName = "INT")]
        public int Id { get; set; }

        //fullname
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string FullName { get; set; } = null!;

        //dateofbirth
        [Required]
        [Column(TypeName = "DATE")]
        public DateTime DateOfBirth { get; set; }

        //hiringdate
        [Required]
        [Column(TypeName = "DATE")]
        public DateTime HiringDate { get; set; }

        //email
        [Required]
        [Column(TypeName = "VARCHAR")]
        [MaxLength(128)]
        public string Email { get; set; } = null!;
    }
}
