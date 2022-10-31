using GreetMe_DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace GreetMe_DataAccess
{
    public class WEXOContext : DbContext
    {

        public DbSet<View> Views { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<ComponentPosition> ComponentPositions { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}
