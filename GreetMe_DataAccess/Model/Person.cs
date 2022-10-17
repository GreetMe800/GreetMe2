using System;
using System.Collections.Generic;

namespace GreetMe_DataAccess.Model
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
