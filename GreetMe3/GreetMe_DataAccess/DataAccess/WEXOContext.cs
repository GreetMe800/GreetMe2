using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DataAccess
{
    public class WEXOContext : DbContext
    {
        //context
        public WEXOContext(DbContextOptions options) : base(options) { }

        //relations in class
        public DbSet<View> Views { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentPosition> ComponentPositions { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@(localdb)\\mssqllocaldb;Database=WEXO_GreetMe;integrated security=True;");
        }
    }
}
