using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetMe_DataAccess.DataAccess
{
    public class ViewContext : DbContext
    {
        //context
        public ViewContext(DbContextOptions options) : base(options) { }

        //relations in class
        public DbSet<View> Views { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Component> Components { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
