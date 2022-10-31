using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetMe_DataAccess.Model
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; } = null!;
    }
}
