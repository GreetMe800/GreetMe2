using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DataAccess
{
    public class LayoutContext : DbContext
    {
        //context
        public LayoutContext(DbContextOptions options) : base(options) { }

        //relations in class
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<ComponentPosition> ComponentPositions { get; set; }
        public DbSet<View> Views { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@(localdb)\\mssqllocaldb;Database=WEXO_GreetMe;integrated security=True;");
        }
    }
}
